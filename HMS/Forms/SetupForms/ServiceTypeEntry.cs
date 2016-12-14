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
using HMS.Forms.BaseForms;
using HMS.App_Code.BLL;

namespace HMS.Forms.SetupForms
{
    public partial class ServiceTypeEntry : BaseGeneralSetup
    {
        bllServiceType objServiceType = new bllServiceType();
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        DataTable dtData = new DataTable();
        DataTable pdfDt = new DataTable();
        string pdfFileName = string.Empty;
        private int _ID;
        public ServiceTypeEntry()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            BindData();
        }
        //public ServiceTypeEntry(int ID,ServiceTypeForm  servicetypeform=ServiceTypeForm.Edit)
        //{
        //    InitializeComponent();
        //    _ID = ID;
        //    if (ID == 0)
        //    {
        //        hdrBaseCaption.Text = "Add Service Type";

        //    }
        //    else
        //    {
        //        LoadServiceType();
        //        hdrBaseCaption.Text = "Edit Service Type Details";
        //        btnSave.Text = "Update";
        //    }
        //    if (servicetypeform == ServiceTypeForm.View)
        //    {
        //        LoadServiceType();
        //        btnSave.Visible = false;
        //        hdrBaseCaption.Text = "Service Type Details";

        //    }
        //}
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            int success = new bllServiceType().Insert(tbxTypeName.Text.Trim());
            if (success > 0)
            {
                KryptonMessageBox.Show("Data inserted successfully.", "Insert", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            }
            else
            {
                KryptonMessageBox.Show("Data inserted failed!.", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveData()
        {
            int success = new bllServiceType().Insert(tbxTypeName.Text.Trim());
            if (success > 0)
            {
                KryptonMessageBox.Show("Data inserted successfully.", "Insert", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                Common.ClearFormWithoutGrid(pnlBaseControlContainer);
            }
            else
            {
                KryptonMessageBox.Show("Data inserted failed!.", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }


        private void UpdateData()
        {
            int success = new bllServiceType().Update(_ID,tbxTypeName.Text.Trim());
            if (success > 0)
            {
                KryptonMessageBox.Show("Data updated successfully.", "Data Update", MessageBoxButtons.OK,
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
                KryptonMessageBox.Show("Data updated failed!.", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
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


        protected void BindData()
        {
            try
            {

                DataTable dt = objServiceType.GetList(CurrentPage * PageSize, PageSize, "", false);
                dtData = new DataTable();
                dtData = dt;
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
                        dr["TypeId"],
                        dr["TypeName"]
                    });

                    dgvMain.Rows[RowNum].Tag = dr["TypeId"];
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
            dgvMain.Columns["TypeName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["TypeName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int success = new dalServiceType().Delete(_ID);
            if (success > 0)
            {
                KryptonMessageBox.Show("Service Type deleted successfully!", "Deleted Refer Fee", MessageBoxButtons.OK,
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
                KryptonMessageBox.Show("The Service Type deleted Fail!", "Deleted Refer Fee.", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _ID = -1;
            btnCancel.Visible = false;
            btnDelete.Enabled = false;
            BtnServiceSave.Text = "Save";
            tbxTypeName.Text = "";
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _ID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value);
            LoadServiceType();
        }


        private void LoadServiceType()
        {
            DataTable dt = new bllServiceType().GetByID(_ID);

            if (dt.Rows.Count > 0)
            {
                tbxTypeName.Text = dt.Rows[0]["TypeName"].ToString();
                btnDelete.Enabled = true;
                BtnServiceSave.Text = "Update";
                btnCancel.Visible = true;
            }
        }
    }
}
