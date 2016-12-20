using ComponentFactory.Krypton.Toolkit;
using HMS.App_Code.BLL;
using HMS.Forms.BaseForms;
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
    public partial class CultureSensitivityBacteria : BaseGeneralSetup
    {
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        DataTable dtData = new DataTable();
        DataTable pdfDt = new DataTable();
        DataTable dtg;
        private int _ID;
        public CultureSensitivityBacteria()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            BindData();
        }


        protected void BindData()
        {
            try
            {
                dtg = new bllCultureSensitivityBacteria().GetList(CurrentPage * PageSize, PageSize, "", false);
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
                        dr["BacteriaId"],
                        dr["BacteriaName"],
                         dr["Description"]
                    });
                    dgvMain.Rows[RowNum].Tag = dr["BacteriaId"];
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


                int success = new bllCultureSensitivityBacteria().Insert(new Model.CultureSensitivityBacteria(0, tbxBacteriaName.Text, tbxDescription.Text));
                if (success > 0)
                {
                    KryptonMessageBox.Show("Medicine saved successfully!", "Add Medicine.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Common.ClearForm(pnlBaseControlContainer);
                }
                else
                {
                    KryptonMessageBox.Show("Medicine saved failed!", "Add Medicine.", MessageBoxButtons.OK,
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
            dgvMain.Columns["BacteriaName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["BacteriaName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Description"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void UpdateData()
        {
            try
            {
                int success = new bllCultureSensitivityBacteria().Update(new Model.CultureSensitivityBacteria(_ID, tbxBacteriaName.Text, tbxDescription.Text));
                if (success > 0)
                {
                    KryptonMessageBox.Show("Madicine updated successfully!", "Update Madicine.", MessageBoxButtons.OK,
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
                    KryptonMessageBox.Show("Madicine updated failed!", "Update Madicine.", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
            int success = new bllCultureSensitivityBacteria().Delete(_ID);
            if (success > 0)
            {
                KryptonMessageBox.Show("Madicine deleted successfully!", "Deleted Madicine", MessageBoxButtons.OK,
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
            tbxBacteriaName.Text = "";
            tbxDescription.Text = "";
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _ID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value);
            tbxBacteriaName.Text = dgvMain.SelectedRows[0].Cells[1].Value.ToString();
            tbxDescription.Text = dgvMain.SelectedRows[0].Cells[2].Value.ToString();
            btnDelete.Enabled = true;
            BtnServiceSave.Text = "Update";
            btnCancel.Visible = true;
        }
    }
}
