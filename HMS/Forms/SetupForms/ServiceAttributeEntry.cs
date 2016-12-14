using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HMS.App_Code.BLL;
using HMS.Forms.BaseForms;

namespace HMS.Forms.SetupForms
{
    public partial class ServiceAttributeEntry : BaseGeneralSetup
    {
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        DataTable dtData = new DataTable();
        DataTable pdfDt = new DataTable();
        string pdfFileName = string.Empty;
        private int _ID;
        public ServiceAttributeEntry()
        {
            InitializeComponent();
            LoadTestType();
            LoadTest();
            LoadUnit(); btnDelete.Enabled = false;
            BindData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadTest()
        {
            DataTable dt = new DataTable();
            if (ddlTestType.SelectedIndex > 0)
            {
                dt = new bllService().GetByTypeID(Convert.ToInt32(ddlTestType.SelectedValue));
            }
            else
            {
                dt = new bllService().GetAll();
            }
            ddlService.DataSource = dt;
            DataRow dr = dt.NewRow();
            dr["ServiceName"] = "Select";              // Set Column Value
            dr["ServiceId"] = "0";
            dt.Rows.InsertAt(dr, 0);
            ddlService.DisplayMember = "ServiceName";
            ddlService.ValueMember = "ServiceId";
            ddlService.SelectedIndex = 0;


        }
        private void LoadUnit()
        {
            DataTable dt = new bllUnit().GetList();
            DataRow dr = dt.NewRow(); //Create New Row
            dr["UnitName"] = "Select";              // Set Column Value
            dr["UnitId"] = "0";
            dt.Rows.InsertAt(dr, 0);
            dt.DefaultView.Sort = "UnitId asc";
            ddlUnit.DataSource = dt;
            ddlUnit.ValueMember = "UnitId";
            ddlUnit.DisplayMember = "UnitName";
            ddlUnit.SelectedIndex = 0;

        }
        private void LoadTestType()
        {
            DataTable dt = new bllServiceType().GetAll();
          
            DataRow dr = dt.NewRow();
            dr["TypeName"] = "Select";              // Set Column Value
            dr["TypeId"] = "0";
            dt.Rows.InsertAt(dr, 0);
            ddlTestType.DataSource = dt;
            ddlTestType.DisplayMember = "TypeName";
            ddlTestType.ValueMember = "TypeId";
            ddlTestType.SelectedIndex = 0;


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void ddlTestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTest();
        }

        private void BtnServiceSave_Click(object sender, EventArgs e)
        {
            if (_ID > 0)
            {
                UpdateData();
            }
            else
            {
                SaveData();
                BindData();
            }
        }


        protected void BindData()
        {
            try
            {
                DataTable dt = new bllServiceAttribute().GetList(CurrentPage * PageSize, PageSize, "", false);
                if (dt.Rows.Count > 0)
                    TotalRec = Convert.ToInt32(dt.Rows[0]["TotalRecords"].ToString());
                else
                {
                    TotalRec = 0;
                    lblPagingSummery.Text = "";
                }
                dgvMain.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    int RowNum = dgvMain.Rows.Add(
                        new object[] {
                        dr["SerAtId"],
                        dr["AttributeName"],     
                        dr["ServiceShortName"],
                        dr["MaleNormalRange"],
                        dr["FemaleNormalRange"],     
                        dr["UnitName"],     
                        dr["Comment"]
                    });
                    dgvMain.Rows[RowNum].Tag = dr["SerAtId"];
                }
                ChangeDataGridHeader();
                managePaging();
            }
            catch (Exception ex)
            {
            }
        }
        void SaveData()
        {

            try
            {
                if (ddlService.SelectedIndex <= 0)
                {
                    KryptonMessageBox.Show("Please select a service.", "Warning", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                    ddlService.Focus();
                    return;
                }
                else if(ddlUnit.SelectedIndex <=0)
                {
                    KryptonMessageBox.Show("Please select a Unit.", "Warning", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                    ddlUnit.Focus();
                    return;
                }
                int unit = 0;
                if (ddlUnit.SelectedIndex > 0)
                {
                    unit = Convert.ToInt32(ddlUnit.SelectedValue);
                }
                int success = new bllServiceAttribute().Insert(Convert.ToInt32(ddlService.SelectedValue), tbxAttribute.Text, tbxMaleNormalRange.Text, tbxFemaleNormalRange.Text, unit, tbxComments.Text.Trim());
                if (success > 0)
                {
                    KryptonMessageBox.Show("Service inserted successfully.", "Insert", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Common.ClearForm(pnlBaseControlContainer);

                }
                else
                {
                    KryptonMessageBox.Show("Service inserted failed.", "Insert Failed", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {


            }
        }
        protected void managePaging()
        {
            ddlPage.Items.Clear();
            if (TotalRec > 0)
            {
                int numberOfPages;
                int numberOfRecords = TotalRec;
                int currentPage = CurrentPage;
                StringBuilder strSummary = new StringBuilder();
                if (numberOfRecords > PageSize)
                {
                    numberOfPages = (int)Math.Ceiling((double)numberOfRecords / (double)PageSize);
                }
                else
                {
                    numberOfPages = 1;
                }
                strSummary.Append("Displaying ");
                int floor = (currentPage * PageSize) + 1;
                strSummary.Append(floor.ToString());
                strSummary.Append("-");
                int ceil = ((currentPage * PageSize) + PageSize);
                if (ceil > numberOfRecords)
                {
                    strSummary.Append(numberOfRecords.ToString());
                }
                else
                {
                    strSummary.Append(ceil.ToString());
                }
                strSummary.Append(" of About ");
                strSummary.Append(numberOfRecords.ToString());
                strSummary.Append(" Records");
                lblPagingSummery.Text = strSummary.ToString();
                for (int i = 1; i <= numberOfPages; i++)
                    ddlPage.Items.Add(i.ToString());
                if (ddlPage.Items.Count >= currentPage)
                    ddlPage.SelectedIndex = currentPage;
            }
        }
        private void ChangeDataGridHeader()
        {
            dgvMain.Columns["AttributeName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["AttributeName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["ServiceShortName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["ServiceShortName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["MaleNormalRange"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["MaleNormalRange"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["FemaleNormalRange"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["FemaleNormalRange"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["UnitName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["UnitName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Comment"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Comment"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }  
        void UpdateData()
        {
            try
            {
                decimal rate = 0.0M;
                decimal discount = 0.0M;
                if (ddlService.SelectedIndex <= 0)
                {
                    KryptonMessageBox.Show("Please select a service.", "Warning", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                    ddlService.Focus();
                    return;
                }
                else if (ddlUnit.SelectedIndex <= 0)
                {
                    KryptonMessageBox.Show("Please select a Unit.", "Warning", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                    ddlUnit.Focus();
                    return;
                }
                int unit = 0;
                if (ddlUnit.SelectedIndex > 0)
                {
                    unit = Convert.ToInt32(ddlUnit.SelectedValue);
                }
                int success = new bllServiceAttribute().Update(_ID,Convert.ToInt32(ddlService.SelectedValue), tbxAttribute.Text, tbxMaleNormalRange.Text, tbxFemaleNormalRange.Text, unit,tbxComments.Text.Trim());
                if (success > 0)
                {
                    KryptonMessageBox.Show("Service Attribute Upadated successfully.", "Updated", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Common.ClearForm(pnlBaseControlContainer);
                    BindData();
                    _ID = -1;
                    BtnServiceSave.Text = "Save";
                    btnDelete.Enabled = false;
                    btnCancel.Visible = false;

                }
                else
                {
                    KryptonMessageBox.Show("Service Attribute updated failed.", "Updated Failed", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {


            }

        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _ID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value);
            DataTable dt = new bllServiceAttribute().GetByID(_ID);

            if (dt.Rows.Count > 0)
            {
                ddlTestType.SelectedValue = dt.Rows[0]["TypeId"].ToString();
                ddlService.SelectedValue = dt.Rows[0]["ServiceId"].ToString();
                tbxAttribute.Text = dt.Rows[0]["AttributeName"].ToString();
                tbxComments.Text = dt.Rows[0]["Comment"].ToString();
                tbxFemaleNormalRange.Text = dt.Rows[0]["FemaleNormalRange"].ToString();
                tbxMaleNormalRange.Text = dt.Rows[0]["MaleNormalRange"].ToString();
                ddlUnit.SelectedValue = dt.Rows[0]["UnitId"].ToString();
                btnDelete.Enabled = true;
                BtnServiceSave.Text = "Update";
                btnCancel.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _ID = -1;
            btnCancel.Visible = false;
            btnDelete.Enabled = false;
            BtnServiceSave.Text = "Save";
            Common.ClearFormWithoutGrid(pnlBaseControlContainer);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int success = new bllServiceAttribute().Delete(_ID);
                if (success > 0)
                {
                    KryptonMessageBox.Show("Service Attribute deleted successfully!", "Deleted Service Attribute", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    Common.ClearForm(pnlBaseControlContainer);
                    BindData();
                    _ID = -1;
                    BtnServiceSave.Text = "Save";
                    btnDelete.Enabled = false;
                    btnCancel.Visible = false;
                }
                else
                {
                    KryptonMessageBox.Show("The Service Attribute deleted Fail!", "Deleted Service Attribute.", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("The Service Attribute deleted Fail!", "Deleted Attribute Service.", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
