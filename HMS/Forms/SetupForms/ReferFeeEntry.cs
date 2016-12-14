using ComponentFactory.Krypton.Toolkit;
using HMS.App_Code.BLL;
using HMS.App_Code.DAL;
using HMS.Forms.BaseForms;
using HMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms.SetupForms
{
    public partial class ReferFeeEntry : BaseGeneralSetup
    {
        private DataTable Service;
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        DataTable dtData = new DataTable();
        DataTable pdfDt = new DataTable();
        string pdfFileName = string.Empty;
        private int _ID;
        public ReferFeeEntry()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            LoadServices();
            BindData();
        }

        private void LoadServices()
        {

            Service = new dalService().GetAll();
            if (Service.Rows.Count > 0)
            {
                DataRow dr = Service.NewRow(); //Create New Row
                dr["ServiceName"] = "Select";              // Set Column Value
                dr["ServiceId"] = "0";
                Service.Rows.InsertAt(dr, 0);
                Service.DefaultView.Sort = "ServiceId asc";
                comService.DataSource = Service;
                comService.DisplayMember = "ServiceName";
                comService.ValueMember = "ServiceId";
                comService.SelectedIndex = 0;
            }
        }

        private void NumReferParcent_TextChanged(object sender, EventArgs e)
        {
                double parsedValue;

                if (!double.TryParse(NumReferParcent.Text, out parsedValue))
                {
                  NumReferParcent.Text= "";
                }
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

        private void SaveData()
        {
            if (comService.SelectedIndex == 0)
            {
                KryptonMessageBox.Show("Please select service name", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }
            else if(NumReferParcent.Text=="")
            {
                KryptonMessageBox.Show("Please enter refer fee", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }
            ReferFee refer = new ReferFee();
            refer.ServiceId = Convert.ToInt16(comService.SelectedValue);
            refer.FeePercent = Convert.ToInt32(NumReferParcent.Text);
            int success = new bllReferFee().Insert(refer);
            if (success != -1)
            {
                KryptonMessageBox.Show("Refer Fee saved successfully!", "Add Refer Fee", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Common.ClearForm(pnlBaseControlContainer);
            }
            else
            {
                KryptonMessageBox.Show("The Refer Fee already saved!", "Add Refer Fee.", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        void UpdateData()
        {
            if (comService.SelectedIndex == 0)
            {
                KryptonMessageBox.Show("Please select service name", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }
            else if (NumReferParcent.Text == "")
            {
                KryptonMessageBox.Show("Please enter refer fee", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }
            ReferFee refer = new ReferFee();
            refer.ReferFeeId = _ID;
            refer.ServiceId = Convert.ToInt16(comService.SelectedValue);
            refer.FeePercent = Convert.ToInt32(NumReferParcent.Text);
            int success = new bllReferFee().Update(refer);
            if (success >0)
            {
                KryptonMessageBox.Show("Refer Fee uptated successfully!", "Update Refer Fee", MessageBoxButtons.OK,
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
                KryptonMessageBox.Show("The Refer Fee uptated Fail!", "Uptated Refer Fee.", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void BindData()
        {
            try
            {
                DataTable dt;
                dt = new dalReferFee().GetList(CurrentPage * PageSize, PageSize, "", false);
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
                        dr["ReferFeeId"],
                        dr["ServiceName"],     
                        dr["FeePercent"]
                    });
                    dgvMain.Rows[RowNum].Tag = dr["ReferFeeId"];
                }
                ChangeDataGridHeader();
                managePaging();
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
            dgvMain.Columns["ReferFeeId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["ServiceName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["ServiceName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["FeePercent"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["FeePercent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _ID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value);
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new bllReferFee().GetByID(_ID);

            if (dt.Rows.Count > 0)
            {
                comService.SelectedValue = dt.Rows[0]["ServiceId"].ToString();
                NumReferParcent.Text = dt.Rows[0]["FeePercent"].ToString();
                btnDelete.Enabled = true;
                BtnServiceSave.Text = "Update";
                btnCancel.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
               int success= new bllReferFee().Delete(_ID);
                if(success>0)
                {
                    KryptonMessageBox.Show("Refer Fee deleted successfully!", "Deleted Refer Fee", MessageBoxButtons.OK,
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
                    KryptonMessageBox.Show("The Refer Fee deleted Fail!", "Deleted Refer Fee.", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _ID = -1;
            btnCancel.Visible = false;
            btnDelete.Enabled = false;
            BtnServiceSave.Text = "Save";
            comService.SelectedIndex = 0;
            NumReferParcent.Text = "";
        }
    }
}
