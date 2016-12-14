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
using HMS.Forms.SetupForms;
using ComponentFactory.Krypton.Toolkit;
using System.Diagnostics;

namespace HMS.Forms.ListForms
{
    public partial class DoctorList : BaseDataGrid
    {
        string UserName;
        bllDoctor objDepartment = new bllDoctor();
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        private AutoCompleteStringCollection namesCollection;
        DataTable dtDep = new DataTable();
        DataTable dtData ;
        DataTable pdfDt = new DataTable();
        string pdfFileName = string.Empty;
        public DoctorList()
        {
            InitializeComponent();
            BindData();
            LoadDepartment();
            bindTextBox();
        }

        private void LoadDepartment()
        {
            dtDep = new bllDepartment().GetAllList();
            if (dtDep.Rows.Count > 0)
            {
                DataRow dr = dtDep.NewRow(); //Create New Row
                dr["DepName"] = "Select";              // Set Column Value
                dr["DepId"] = "0";
                dtDep.Rows.InsertAt(dr, 0);
                dtDep.DefaultView.Sort = "DepId asc";
                ddlDepartment.DataSource = dtDep;
                ddlDepartment.DisplayMember = "DepName";
                ddlDepartment.ValueMember = "DepId";
                ddlDepartment.SelectedIndex = 0;
            }
        }
        protected void BindData()
        {
            try
            {
                var Criteria = GetCriteria();
                
                DataTable dt = new bllDoctor().GetList(CurrentPage * PageSize, PageSize, Criteria, false);
                dtData = new DataTable();
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
                        dr["DoctorId"],
                        dr["DoctorCode"],     
                        dr["Name"],    
                        dr["Address"],
                        dr["MobileNo"], 
                        dr["Email"], 
                        dr["DepartmentId"],    
                        dr["DepName"],
                        dr["Gender"],
                        dr["Qualification"],     
                        dr["Image"]
                    });
                    img = new Bitmap(Application.StartupPath + @"\Images\" + dr["Image"].ToString());
                    dgvMain.Rows[RowNum].Cells[10].Value = img;
                    dgvMain.Rows[RowNum].Tag = dr["DoctorId"];
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
                Criteria = "(DoctorCode like '%" + tbxSearch.Text.Trim() + "%' " +
                           " or Name like '%" + tbxSearch.Text.Trim() + "%'" + " or MobileNo like '%" + tbxSearch.Text.Trim() + "%')";
            }
            if (ddlDepartment.SelectedIndex != -1 && Convert.ToInt32(ddlDepartment.SelectedValue) != 0)
            {
                Criteria = "";
                if (Criteria == "")
                    Criteria = "DepartmentId=" + ddlDepartment.SelectedValue;
                else
                    Criteria += " And DepartmentId=" + ddlDepartment.SelectedValue;

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
            dgvMain.Columns["DoctorCode"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Address"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["MobileNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["DepName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Qualification"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Image"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMain.Rows.Count == 0 || dgvMain.SelectedRows.Count == 0)
            {
                KryptonMessageBox.Show("Select A Department", "Department List.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = int.Parse(dgvMain.CurrentRow.Cells[0].Value.ToString());
            ConsultantEntry meX = new ConsultantEntry(ID);
            DialogResult dr = meX.ShowDialog();
            ddlPage.Items.Clear();
            if (dr == DialogResult.Yes)
            {
                BindData();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }


        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value); ;
            ConsultantEntry meX = new ConsultantEntry(ID, ConsultantForm.View);
            meX.ShowDialog();
        }


        private void btnSearchTop_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            bool isMatch = false;
            if (tbxSearch.Text.Length == 0)
            {
                listBox1.Visible = false;
                return;
            }

            foreach (String s in tbxSearch.AutoCompleteCustomSource)
            {
                if (s.Contains(tbxSearch.Text))
                {
                    listBox1.Items.Add(s);
                    listBox1.Visible = true;
                    isMatch = true;
                }
            }
            if (!isMatch)
                listBox1.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxSearch.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            listBox1.Visible = false;
        }

        private void bindTextBox()
        {
            listBox1.BringToFront();
            namesCollection = new AutoCompleteStringCollection();
            DataTable AllCode=new bllDoctor().GetAllCode();
            foreach (DataRow r in AllCode.Rows)
                namesCollection.Add(r["DoctorCode"].ToString());
            tbxSearch.AutoCompleteMode = AutoCompleteMode.None;
            tbxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxSearch.AutoCompleteCustomSource = namesCollection;
        }

        private void btnViewPdf_Click(object sender, EventArgs e)
        {
            ViewPdf();
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
                    dr["DoctorCode"],
                    dr["Name"],
                      dr["Address"],
                    dr["MobileNo"],
                      dr["DepName"],
                    dr["Gender"],
                      dr["Qualification"]);
            }

            //return pdfDt;
            var columnNames = new[] { "DoctorCode", "Name", "Address", "MobileNo", "DepName", "Gender", "Qualification" };
            string printInfo = "Date: " + DateTime.Today.ToString("dd-MMM-yyyy");
            pdfFileName = new Exporter().ExportToPDF("Hospital Management System", "Doctor List", "", printInfo, columnNames, pdfDt, "DoctorList");
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;
            string filename = "";
            string filePath = String.Format(@"{0}\HMS\UserFile\PDF\{1}DoctorList\", Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), filename);
            filename = String.Format(@"{0}{1}_{2}.pdf", filePath, "DoctorList" + filename, DateTime.Now.ToString("ddMMMyy"));
            startInfo.FileName = filename;
            process.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
