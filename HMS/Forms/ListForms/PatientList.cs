using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.Forms.BaseForms;
using HMS.App_Code.BLL;
using System.Diagnostics;
using HMS.Forms.SetupForms;
using ComponentFactory.Krypton.Toolkit;

namespace HMS.Forms.ListForms
{
    public partial class PatientList : BaseDataGrid
    {
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        DataTable dtData;
        DataTable pdfDt = new DataTable();
        string pdfFileName = string.Empty;
        public PatientList()
        {
            InitializeComponent();
            BindData();
        }


        private void LoadDepartment()
        {
            //dtDep = new bllDepartment().GetAllList();
            //if (dtDep.Rows.Count > 0)
            //{
            //    DataRow dr = dtDep.NewRow(); //Create New Row
            //    dr["DepName"] = "Select";              // Set Column Value
            //    dr["DepId"] = "0";
            //    dtDep.Rows.InsertAt(dr, 0);
            //    dtDep.DefaultView.Sort = "DepId asc";
            //    ddlDepartment.DataSource = dtDep;
            //    ddlDepartment.DisplayMember = "DepName";
            //    ddlDepartment.ValueMember = "DepId";
            //    ddlDepartment.SelectedIndex = 0;
            //}
        }
        protected void BindData()
        {
            try
            {
                var Criteria = GetCriteria();

                DataTable dt = new bllPatient().GetList(CurrentPage * PageSize, PageSize, Criteria, false);

                dtData = dt;
                if (dt.Rows.Count > 0)
                    TotalRec = Convert.ToInt32(dt.Rows[0]["TotalRecords"].ToString());
                else
                {
                    TotalRec = 0;
                    lblPagingSummery.Text = "";
                }
                Bitmap img;
                if (!dgvMain.Columns.Contains("Image"))
                {

                    DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                    imageCol.HeaderText = "Image";
                    imageCol.Name = "Image";
                    imageCol.Width = 200;
                    imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dgvMain.Columns.Add(imageCol);
                }
                

                dgvMain.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    int RowNum = dgvMain.Rows.Add(
                        new object[] {
                        dr["PatientID"],
                        dr["PatientCode"],     
                        dr["Name"],    
                        dr["Email"],
                        dr["Address"], 
                        dr["MobileNo"], 
                        dr["Age"],    
                        dr["BloodGroup"],
                        dr["Gender"],
                        dr["RrefrById"],  
                        dr["DoctorName"], 
                        dr["Image"]
                    });
                    string imagepath = dr["Image"].ToString();
                    if (imagepath != "")
                    {
                        img = new Bitmap(Application.StartupPath + @"\Images\" + dr["Image"].ToString());
                    }
                    else
                    {
                        img = new Bitmap(Application.StartupPath + @"\Images\" + "user-blank.PNG");
                    }
                    dgvMain.Rows[RowNum].Cells[11].Value = img;
                    dgvMain.Rows[RowNum].Tag = dr["PatientID"];
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
                Criteria = "(PatientCode like '%" + tbxSearch.Text.Trim() + "%' " +
                           " or Name like '%" + tbxSearch.Text.Trim() + "%'" + " or MobileNo like '%" + tbxSearch.Text.Trim() + "%')";
            }
            //if (ddlDepartment.SelectedIndex != -1 && Convert.ToInt32(ddlDepartment.SelectedValue) != 0)
            //{
            //    Criteria = "";
            //    if (Criteria == "")
            //        Criteria = "DepartmentId=" + ddlDepartment.SelectedValue;
            //    else
            //        Criteria += " And DepartmentId=" + ddlDepartment.SelectedValue;

            //}
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
            dgvMain.Columns["PatientCode"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Address"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["MobileNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["BloodGroup"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Age"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["DoctorName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Image"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ViewPdf()
        {

            //var Criteria = GetCriteria();

            pdfDt.Clear();
            pdfDt.Columns.AddRange(new[] { new DataColumn(), new DataColumn(), new DataColumn(), new DataColumn(), 
                    new DataColumn(), new DataColumn(), new DataColumn(), new DataColumn(), 
                    new DataColumn(), new DataColumn() , new DataColumn()});
            foreach (DataRow dr in dtData.Rows)
            {
                pdfDt.Rows.Add(
                    dr["PatientCode"],
                    dr["Name"],
                      dr["Address"],
                    dr["Email"],
                      dr["MobileNo"],
                    dr["Gender"],
                      dr["BloodGroup"],
                      dr["Age"],
                      dr["DoctorName"]
                      );
            }

            //return pdfDt;
            var columnNames = new[] { "PatientCode", "Name", "Address", "Email", "MobileNo", "Gender", "BloodGroup", "Age","Refer By"  };
            string printInfo = "Date: " + DateTime.Today.ToString("dd-MMM-yyyy");
            pdfFileName = new Exporter().ExportToPDF("Hospital Management System", "Paient List", "", printInfo, columnNames, pdfDt, "PatientList");
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;
            string filename = "";
            string filePath = String.Format(@"{0}\HMS\UserFile\PDF\{1}PatientList\", Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), filename);
            filename = String.Format(@"{0}{1}_{2}.pdf", filePath, "PatientList" + filename, DateTime.Now.ToString("ddMMMyy"));
            startInfo.FileName = filename;
            process.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMain.Rows.Count == 0 || dgvMain.SelectedRows.Count == 0)
            {
                KryptonMessageBox.Show("Select A Patient", "Patient List.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = int.Parse(dgvMain.CurrentRow.Cells[0].Value.ToString());
            PatientEntry meX = new PatientEntry(ID);
            //Image image = (Image)(dgvMain.CurrentRow.Cells[11].Value);

            dgvMain.CurrentRow.Cells[11].Value = null;
           // image.Dispose();
            DialogResult dr = meX.ShowDialog();
            ddlPage.Items.Clear();
            Close();
            //if (dr == DialogResult.Yes)
            //{
            //    BindData();
            //}
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value); ;
            PatientEntry meX = new PatientEntry(ID, PatientForm.View);
            meX.ShowDialog();
        }

        private void btnSearchTop_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnViewPdf_Click(object sender, EventArgs e)
        {
            ViewPdf();
        }
    }
}
