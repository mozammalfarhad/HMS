using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HMS.App_Code.BLL;
using HMS.Forms.BaseForms;

namespace HMS.Forms.SetupForms
{
    public partial class VacuumEntry : BaseGeneralSetup
    {
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        DataTable dtData = new DataTable();
        DataTable pdfDt = new DataTable();
        string pdfFileName = string.Empty;
        private int _ID;
        DataTable dtg;
        public VacuumEntry()
        {
            InitializeComponent();
            LoadTestType();
            LoadService();
            btnDelete.Enabled = false;
            BindData();
        }
        private void LoadTestType()
        {
            DataTable dtTypeList = new bllServiceType().GetAll();
            if (dtTypeList.Rows.Count > 0)
            {
                DataRow dr = dtTypeList.NewRow();
                dr["TypeId"] = "0";
                dr["TypeName"] = "Select";
                dtTypeList.Rows.Add(dr);
                dtTypeList.DefaultView.Sort = "TypeId asc";
                ddlTestType.DataSource = dtTypeList;
                ddlTestType.DisplayMember = "TypeName";
                ddlTestType.ValueMember = "TypeId";
                ddlTestType.SelectedIndex = 0;
            }


        }
        private void LoadService()
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
            DataRow dr = dt.NewRow();
            dr["ServiceId"] = "0";
            dr["ServiceName"] = "Select";
            dt.Rows.InsertAt(dr, 0);
            dt.DefaultView.Sort = "ServiceId asc";
            ddlService.DataSource = dt;
            ddlService.DisplayMember = "ServiceName";
            ddlService.ValueMember = "ServiceId";
            ddlService.SelectedIndex = 0;

        }
        //private readonly int _ID;
        //public VacuumEntry(int ID, VacuumForm vacuumForm = VacuumForm.Edit)
        //{
        //    InitializeComponent();
        //    LoadTestType();
        //    LoadService();
        //    _ID = ID;
        //    if (ID == 0)
        //    {
        //        hdrBaseCaption.Text = "Add Vacuum";

        //    }
        //    else if (vacuumForm != VacuumForm.View && ID > 0)
        //    {
        //        LoadVacuum();
        //        hdrBaseCaption.Text = "Edit Vacuum Details";
        //        btnSave.Text = "Update";
        //    }
        //    if (vacuumForm == VacuumForm.View)
        //    {
        //        LoadVacuum();
        //        btnSave.Visible = false;
        //        hdrBaseCaption.Text = "Vacuum Details";

        //    }
        //}

        private void LoadVacuum()
        {
            DataTable dt = new bllVacuum().GetByID(_ID);

            if (dt.Rows.Count > 0)
            {
                tbxVacuumName.Text = dt.Rows[0]["VacuumName"].ToString();
                tbxDescription.Text = dt.Rows[0]["VacuumDescription"].ToString();
                tbxPrice.Text = dt.Rows[0]["VacuumPrice"].ToString();
                ddlService.SelectedValue = dt.Rows[0]["ServiceId"].ToString();
                btnDelete.Enabled = true;
                BtnServiceSave.Text = "Update";
                btnCancel.Visible = true;

            }
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
        void SaveData()
        {

            try
            {
                if (tbxVacuumName.Text == "")
                {
                    KryptonMessageBox.Show("Vacuum Name must be needed!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ddlService.SelectedIndex <= 0)
                {
                    KryptonMessageBox.Show("Please select a service", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (tbxPrice.Text == "")
                {
                    KryptonMessageBox.Show("Price must needed", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {

                    int success = new bllVacuum().Insert(Convert.ToInt32(ddlService.SelectedValue), tbxVacuumName.Text, tbxDescription.Text, Convert.ToDecimal(tbxPrice.Text));
                    if (success > 0)
                    {
                        KryptonMessageBox.Show("Vacuum saved successfully!", "Add Vacuum.", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Common.ClearForm(pnlBaseControlContainer);
                    }
                    else
                    {
                        KryptonMessageBox.Show("Vacuum saved failed!", "Add Vacuum.", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {


            }
        }


        void UpdateData()
        {
            try
            {
                if (tbxVacuumName.Text == "")
                {
                    KryptonMessageBox.Show("Vacuum Name must be needed!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ddlService.SelectedIndex<=0)
                {
                    KryptonMessageBox.Show("Please select a service", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (tbxPrice.Text == "")
                {
                    KryptonMessageBox.Show("Price must needed", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {

                    int success = new bllVacuum().Update(_ID, Convert.ToInt32(ddlService.SelectedValue), tbxVacuumName.Text, tbxDescription.Text,Convert.ToDecimal(tbxPrice.Text));
                    if (success > 0)
                    {
                        KryptonMessageBox.Show("Consult updated successfully!", "Update Consult.", MessageBoxButtons.OK,
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
                        KryptonMessageBox.Show("Consult updated failed!", "Update Consult.", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
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

                dtg = new bllVacuum().GetList(CurrentPage * PageSize, PageSize, "", false);
                dtData = new DataTable();
                dtData = dtg;
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
                        dr["VacuumId"],
                        dr["ServiceId"],   
                        dr["ServiceName"],
                        dr["VacuumName"],    
                        dr["VacuumDescription"],
                        dr["VacuumPrice"],
                        dr["TypeId"]
                    });

                    dgvMain.Rows[RowNum].Tag = dr["VacuumId"];
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
            dgvMain.Columns["ServiceName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["ServiceName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["VacuumName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["VacuumName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["VacuumDescription"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["VacuumDescription"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["VacuumPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["VacuumPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _ID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value);
            LoadVacuum();
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
                int success = new bllVacuum().Delete(_ID);
                if (success > 0)
                {
                    KryptonMessageBox.Show("Vacuum deleted successfully!", "Deleted Vacuum", MessageBoxButtons.OK,
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
                    KryptonMessageBox.Show("The Vacuum deleted Fail!", "Deleted Vacuum.", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("The Vacuum deleted Fail!", "Deleted Vacuum.", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void ddlService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtg != null && _ID <= 0)
            {
                DataView dv;
                if (ddlTestType.SelectedIndex != 0)
                    dv = new DataView(dtg, "TypeId = " + ddlTestType.SelectedValue + " and ServiceId = " + ddlService.SelectedValue, "", DataViewRowState.CurrentRows);
                else
                    dv = new DataView(dtg, "TypeId = " + ddlTestType.SelectedValue, "", DataViewRowState.CurrentRows);
                dgvMain.Rows.Clear();
                foreach (DataRow dr in dv.ToTable().Rows)
                {
                    int RowNum = dgvMain.Rows.Add(
                          new object[] {
                       dr["VacuumId"],
                        dr["ServiceId"],   
                        dr["ServiceName"],
                        dr["VacuumName"],    
                        dr["VacuumDescription"],
                        dr["VacuumPrice"],
                        dr["TypeId"]
                    });

                    dgvMain.Rows[RowNum].Tag = dr["VacuumId"];
                }
                ChangeDataGridHeader();
                managePaging();

            }
        }

        private void ddlTestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadService();
            if (dtg != null && _ID <= 0)
            {
                DataView dv;
                if (ddlTestType.SelectedIndex != 0)
                    dv = new DataView(dtg, "TypeId = " + ddlTestType.SelectedValue, "", DataViewRowState.CurrentRows);
                else
                    dv = new DataView(dtg, "", "", DataViewRowState.CurrentRows);
                dgvMain.Rows.Clear();
                foreach (DataRow dr in dv.ToTable().Rows)
                {
                    int RowNum = dgvMain.Rows.Add(
                          new object[] {
                       dr["VacuumId"],
                        dr["ServiceId"],   
                        dr["ServiceName"],
                        dr["VacuumName"],    
                        dr["VacuumDescription"],
                        dr["VacuumPrice"],
                        dr["TypeId"]
                    });

                    dgvMain.Rows[RowNum].Tag = dr["VacuumId"];
                }
                ChangeDataGridHeader();
                managePaging();

            }
        }
    }
}
