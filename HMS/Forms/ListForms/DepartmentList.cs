using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HMS.App_Code.BLL;
using HMS.Forms.BaseForms;
using HMS.Forms.SetupForms;
using iTextSharp.text;

namespace HMS.Forms.ListForms
{
    public partial class DepartmentList : BaseDataGrid
    {
        string UserName;
        bllDepartment objDepartment = new bllDepartment();
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        DataTable dtData = new DataTable();
        DataTable pdfDt = new DataTable();
        string pdfFileName = string.Empty;
        public DepartmentList()
        {
            InitializeComponent();
            BindData();
            LoadDepartment();
        }

        private void LoadDepartment()
        {
             dtData = new bllDepartment().GetList(CurrentPage * PageSize, PageSize, "", false);
            if (dtData.Rows.Count > 0)
            {
                DataRow dr = dtData.NewRow(); //Create New Row
                dr["DepName"] = "Select";              // Set Column Value
                dr["DepId"] = "0";
                dtData.Rows.InsertAt(dr, 0);
                dtData.DefaultView.Sort = "DepId asc";
                ddlDepartment.DataSource = dtData;
                ddlDepartment.DisplayMember = "DepName";
                ddlDepartment.ValueMember = "DepId";
                ddlDepartment.SelectedIndex = 0;
            }
        }
        protected void BindData()
        {
            try
            {
                DataTable dt;
                var Criteria = GetCriteria();
                dt = new bllDepartment().GetList(CurrentPage * PageSize, PageSize, Criteria, false);
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
                        dr["DepId"],
                        dr["DepName"],     
                        dr["Description"]
                    });
                    dgvMain.Rows[RowNum].Tag = dr["DepId"];
                }
                ChangeDataGridHeader();
                managePaging();
                tbxSearch.Focus();
            }
            catch (Exception ex)
            {
            }
        }

        private string GetCriteria()
        {
            string Criteria = "";
            if (tbxSearch.Text.Trim() != "")
            {
                Criteria = "(DepName like '%" + tbxSearch.Text.Trim() + "%' " +
                           "or Description like '%" + tbxSearch.Text.Trim() + "%')";
            }
            if (ddlDepartment.SelectedIndex != -1)
            {
                Criteria = "";
                if (Criteria == "")
                    Criteria = "DepId=" + ddlDepartment.SelectedValue;
                else
                    Criteria += " And DepId=" + ddlDepartment.SelectedValue;
                
            }
            return Criteria;
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

        private void btnSearchTop_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMain.Rows.Count == 0 || dgvMain.SelectedRows.Count == 0)
            {
                KryptonMessageBox.Show("Select A Department", "Department List.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = int.Parse(dgvMain.CurrentRow.Cells[0].Value.ToString());
            //DepartmentEntry meX = new DepartmentEntry( ID);
            //DialogResult dr = meX.ShowDialog();
            //ddlPage.Items.Clear();
            //if (dr == DialogResult.Yes)
            //{
            //    BindData();
            //}

        }
        private void ddlPage_DropDownClosed(object sender, EventArgs e)
        {
            CurrentPage = ddlPage.SelectedIndex;
            BindData();
        }
       
        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value); ;
            //DepartmentEntry meX = new DepartmentEntry(ID, DepartmentForm.View);
            //meX.ShowDialog();

        }

        private void btnViewPdf_Click(object sender, EventArgs e)
        {
            ViewPdf();
        }
        private void ViewPdf()
        {

            var Criteria = GetCriteria();
            dtData = new bllDepartment().GetList(CurrentPage * PageSize, PageSize, Criteria, false);
            pdfDt.Clear();
            pdfDt.Columns.AddRange(new[] { new DataColumn(), new DataColumn(), new DataColumn(), new DataColumn(), 
                    new DataColumn(), new DataColumn(), new DataColumn(), new DataColumn(), 
                    new DataColumn(), new DataColumn() , new DataColumn()});
            foreach (DataRow dr in dtData.Rows)
            {
                pdfDt.Rows.Add(
                    dr["DepName"],
                    dr["Description"]
                );
            }

            //return pdfDt;
            var columnNames = new[] { "Department", "Description" };
            string printInfo = "Date: " + DateTime.Today.ToString("dd-MMM-yyyy");
            pdfFileName = new Exporter().ExportToPDF("Hospital Management System", "Department List", Criteria, printInfo, columnNames, pdfDt, "DepartmentList");
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;
            string filename = "";
            string filePath = String.Format(@"{0}\HMS\UserFile\{1}DepartmentList\", Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), filename);
            filename = String.Format(@"{0}{1}_{2}.pdf", filePath, "DepartmentList" + filename, DateTime.Now.ToString("ddMMMyy"));
            startInfo.FileName = filename;
            process.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
