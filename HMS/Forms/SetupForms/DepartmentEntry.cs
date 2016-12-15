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
    public partial class DepartmentEntry : BaseGeneralSetup
    {
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        DataTable dtData = new DataTable();
        DataTable pdfDt = new DataTable();
        DataTable dtg;
        string pdfFileName = string.Empty;
        public DepartmentEntry()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            BindData();
        }
        private int _ID;
        private void LoadDepartment()
        {
            DataTable dt = new bllDepartment().GetByID(_ID);

            if (dt.Rows.Count > 0)
            {
                tbxDepartment.Text = dt.Rows[0]["DepName"].ToString();
                tbxDescription.Text = dt.Rows[0]["Description"].ToString();
                btnDelete.Enabled = true;
                BtnServiceSave.Text = "Update";
                btnCancel.Visible = true;
            }
        }
        protected void BindData()
        {
            try
            {
                dtg = new bllDepartment().GetList(CurrentPage * PageSize, PageSize, "", false);
                if (dtg.Rows.Count > 0)
                    TotalRec = Convert.ToInt32(dtg.Rows[0]["TotalRecords"].ToString());
                else
                {
                    TotalRec = 0;
                    lblPagingSummery.Text = "";
                }
                dgvMain.Rows.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    int RowNum = dgvMain.Rows.Add(
                        new object[] {
                        dr["DepId"],
                        dr["DepName"],     
                        dr["Description"]
                    });
                    dgvMain.Rows[RowNum].Tag = dr["DepId"];
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


                int success = new bllDepartment().Insert(tbxDepartment.Text, tbxDescription.Text);
                if (success>0)
                {
                    KryptonMessageBox.Show("Department saved successfully!", "Add Department.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Common.ClearForm(pnlBaseControlContainer);
                }
                else
                {
                    KryptonMessageBox.Show("Department saved failed!", "Add Department.", MessageBoxButtons.OK,
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
            dgvMain.Columns["DepId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["DepName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Description"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        void UpdateData()
        {
            try
            {
                int success = new bllDepartment().Update(_ID,tbxDepartment.Text, tbxDescription.Text);
                if (success>0)
                {
                    KryptonMessageBox.Show("Department updated successfully!", "Update Department.", MessageBoxButtons.OK,
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
                    KryptonMessageBox.Show("Department updated failed!", "Update Department.", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ID > 0)
            {
                UpdateData();
            }
            else
            {
                SaveData();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int success = new bllDepartment().Delete(_ID);
            if (success > 0)
            {
                KryptonMessageBox.Show("Department deleted successfully!", "Deleted Refer Fee", MessageBoxButtons.OK,
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
                KryptonMessageBox.Show("The Department deleted Fail!", "Deleted Refer Fee.", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _ID = -1;
            btnCancel.Visible = false;
            btnDelete.Enabled = false;
            BtnServiceSave.Text = "Save";
            tbxDepartment.Text = "";
            tbxDescription.Text = "";
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _ID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value);
            LoadDepartment();
        }

        private void tbxDepartment_TextChanged(object sender, EventArgs e)
        {
            if (dtg != null && _ID <= 0)
            {
                DataView dv = new DataView(dtg, "DepName like '%" + tbxDepartment.Text + "%'", "", DataViewRowState.CurrentRows);
                dgvMain.Rows.Clear();
                foreach (DataRow dr in dv.ToTable().Rows)
                {
                    int RowNum = dgvMain.Rows.Add(
                        new object[] {
                        dr["DepId"],
                        dr["DepName"],     
                        dr["Description"]
                    });
                    dgvMain.Rows[RowNum].Tag = dr["DepId"];
                }
                ChangeDataGridHeader();
                managePaging();

            }
        }


    }
}
