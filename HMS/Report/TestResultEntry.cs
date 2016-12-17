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
using System.Diagnostics;
using HMS.Forms.SetupForms;
using HMS.Model;

namespace HMS.Report
{
    public partial class TestResultEntry : BaseDataGrid
    {
        DataTable dt;
        private int _id;
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        public TestResultEntry()
        {
            InitializeComponent();
        }
        private int _ScheduleID;
        private int _PatientID;
        private int _TestID;
        private int _ServiceID;
        private Bitmap imgDelete;
        private Bitmap imgEdit;
        private Bitmap imgCreate;
        public TestResultEntry(int ScheduleID)
        {
            InitializeComponent();
            dt = new bllTestWithSchedule().GetPatientServiceBySchedId(ScheduleID);
            //   dgvTestWithSchedule.DataSource = dt;
            imgDelete = new Bitmap(Application.StartupPath + @"\Images\" + "Delete.gif");
            imgEdit = new Bitmap(Application.StartupPath + @"\Images\" + "update.jpg");
            imgCreate = new Bitmap(Application.StartupPath + @"\Images\" + "Create.gif");
            LoadGridData(dt);
            LoadPatient();
            _id = ScheduleID;
            _ScheduleID = ScheduleID;
            //   BindData();
        }


        private void LoadPatient()
        {
            DataTable ServiceType = new bllServiceType().GetAll();
            DataRow dr = ServiceType.NewRow();
            dr["TypeId"] = "0";
            dr["TypeName"] = "Select Service Type";
            ServiceType.Rows.InsertAt(dr, 0);
            ComServiceType.DataSource = ServiceType;
            ComServiceType.DisplayMember = "TypeName";
            ComServiceType.ValueMember = "TypeId";
            ComServiceType.SelectedIndex = 0;
            //PatientCode

        }
        private void BindData()
        {
            DataTable dt = new bllTestWithSchedule().GetPatientServiceBySchedId(_ScheduleID);
            if (dt.Rows.Count > 0)
            {
                TotalRec = dt.Rows.Count;
                lblPatientName.Text = dt.Rows[0]["Name"].ToString();
                lblTotalFee.Text = dt.Rows[0]["PayableAmt"].ToString();
                _PatientID = Convert.ToInt32(dt.Rows[0]["PatientId"].ToString());

                dgvMain.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    int RowNum = dgvMain.Rows.Add(
                        new object[]
                        {
                            dr["SheduleId"],
                            dr["TestId"],
                            dr["PatientId"],
                            dr["ServiceId"],
                            dr["ServiceName"],
                            dr["Rate"],
                            dr["Status"]

                        });

                    dgvMain.Rows[RowNum].Cells[8].ToolTipText = "Delete";
                    dgvMain.Rows[RowNum].Cells[8].Value = imgDelete;
                    string status = dr["Status"].ToString();
                    if (status != "Pending")
                    {
                        dgvMain.Rows[RowNum].Cells[7].ToolTipText = "Edit";
                        dgvMain.Rows[RowNum].Cells[7].Value = imgEdit;
                    }
                    else
                    {
                        dgvMain.Rows[RowNum].Cells[7].ToolTipText = "Entry";
                        dgvMain.Rows[RowNum].Cells[7].Value = imgCreate;
                    }
                    dgvMain.Rows[RowNum].Tag = dr["TestId"].ToString();
                }
                managePaging();
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
        private void LoadGridData(DataTable dtl)
        {
            if (dtl.Rows.Count > 0)
            {
                TotalRec = dtl.Rows.Count;
                lblPatientName.Text = dt.Rows[0]["Name"].ToString();
                lblTotalFee.Text = dt.Rows[0]["PayableAmt"].ToString();
                _PatientID = Convert.ToInt32(dt.Rows[0]["PatientId"].ToString());


                dgvMain.Rows.Clear();
                foreach (DataRow dr in dtl.Rows)
                {
                    int RowNum = dgvMain.Rows.Add(
                        new object[]
                        {
                            dr["SheduleId"],
                            dr["TestId"],
                            dr["PatientId"],
                            dr["ServiceId"],
                            dr["ServiceName"],
                            dr["Rate"],
                            dr["Status"]

                        });
                    dgvMain.Rows[RowNum].Cells[8].ToolTipText = "Delete";
                    dgvMain.Rows[RowNum].Cells[8].Value = imgDelete;
                    string status = dr["Status"].ToString();
                    if (status != "Pending")
                    {
                        dgvMain.Rows[RowNum].Cells[7].ToolTipText = "Edit";
                        dgvMain.Rows[RowNum].Cells[7].Value = imgEdit;
                    }
                    else
                    {
                        dgvMain.Rows[RowNum].Cells[7].ToolTipText = "Entry";
                        dgvMain.Rows[RowNum].Cells[7].Value = imgCreate;
                    }

                    dgvMain.Rows[RowNum].Cells[8].ToolTipText = "Delete";

                    dgvMain.Rows[RowNum].Cells[8].Value = imgDelete;
                    dgvMain.Rows[RowNum].Tag = dr["TestId"].ToString();
                }

                managePaging();
            }
            else
            {
                dgvMain.Rows.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int _ScheduleID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value);
            int _TestID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[1].Value);
            int _PatientID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[2].Value);
            int _ServiceID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[3].Value);
            DataGridViewCell dvcell = new DataGridViewButtonCell();
            dvcell.ToolTipText = dgvMain.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText.ToString();
            if (dvcell.ToolTipText.ToString() == "Delete")
            {

                if (KryptonMessageBox.Show("Sure to remove?", "Test delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                int Success = new bllTestWithSchedule().Delete(_ScheduleID, _TestID);
                if (Success > 0)
                {
                    KryptonMessageBox.Show("Test removed successfully!", "Patient Test.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    //BindData();
                    LoadGridData(dt);
                }
                else
                {
                    KryptonMessageBox.Show("Test removed failed!", "Patient Test.", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (dvcell.ToolTipText.ToString() == "Entry")
            {

                TestResultDetailEntry frm = new TestResultDetailEntry(_TestID, _ScheduleID, _ServiceID, _PatientID, "Entry");
                frm.ShowDialog();
            }
            else if (dvcell.ToolTipText.ToString() == "Edit")
            {
                TestResultDetailEntry frm = new TestResultDetailEntry(_TestID, _ScheduleID, _ServiceID, _PatientID, "Edit");
                frm.ShowDialog();
                //TestResultEntry frm = new TestResultEntry(ScheduleID);
                // frm.ShowDialog();
            }

        }

        private void TbxServiceName_Enter(object sender, EventArgs e)
        {
            if (TbxServiceName.Text == "Service Name")
                TbxServiceName.Text = "";
        }

        private void TbxServiceName_Leave(object sender, EventArgs e)
        {
            if (TbxServiceName.Text == "")
                TbxServiceName.Text = "Service Name";
        }

        private void TbxServiceName_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dtr = new DataView(dt, "ServiceName like '%" + TbxServiceName.Text + "%'", "", DataViewRowState.CurrentRows);
            LoadGridData(dtr.ToTable());
        }

        private void ComServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComServiceType.SelectedIndex != 0)
            {

                DataView d = new DataView(dt, "TypeId = '" + ComServiceType.SelectedValue + "'", "", DataViewRowState.CurrentRows);
                LoadGridData(d.ToTable());
                TbxServiceName.Text = "Service Name";
            }
            else
            {
                LoadGridData(dt);
                TbxServiceName.Text = "Service Name";
            }
        }

        private void btnViewPdf_Click(object sender, EventArgs e)
        {
            if (ComServiceType.SelectedIndex != 0)
            {
                ViewPdfForServiceType();
            }
            else
            {
                ViewPdfWithoutServiceType();
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            TestEntry frm = new TestEntry(_ScheduleID, _PatientID, "AddTest");
            frm.ShowDialog();

        }
        private void ViewPdfForServiceType()
        {
            //crs = cmbCourse.SelectedIndex > 0 ? cmbCourseShadow.Items[cmbCourse.SelectedIndex].ToString() : "0";  
            try
            {
                int serviceId = Convert.ToInt32(ComServiceType.SelectedValue);
                DataTable courseDt = new bllReportData().GetTestCatagoryReport(_id, serviceId);



                //dt = new bllTournament().GetListWithFiltering();
                int TotalRec = 0;
                if (courseDt.Rows.Count > 0)
                {
                    string localPath = string.Empty;
                    var fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        localPath = fbd.SelectedPath + "\\BloodChemistry" + DateTime.Today.Date.ToString("dd_MMM_yyyy_") + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond + ".pdf";
                        this.Cursor = Cursors.WaitCursor;
                        Rpt_BloodChemistry rpt = new Rpt_BloodChemistry();
                        rpt.SetDataSource(courseDt);
                        rpt.SetParameterValue("LogoPath", Application.StartupPath + @"\Images\" + Default.logoPath);
                        rpt.SetParameterValue("CompanyName", Default.companyName);
                        rpt.SetParameterValue("Address", Default.companyAddress + ", Telephone : " + Default.Telephone);

                        rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, localPath);
                        this.Cursor = Cursors.Default;
                        KryptonMessageBox.Show("Patient Test Report Exported successfully!", "Patient Test Result.", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                        Process.Start(localPath);
                    }
                }
                else
                {
                    KryptonMessageBox.Show("All report result are panding, No Report to view");
                    return;
                }


            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
                return;
            }
        }

        private void ViewPdfWithoutServiceType()
        {
            //crs = cmbCourse.SelectedIndex > 0 ? cmbCourseShadow.Items[cmbCourse.SelectedIndex].ToString() : "0";  
            try
            {
                DataTable courseDt = new bllReportData().GetTestCatagoryReport(_id, 0);


                DataView view = new DataView(courseDt);
                DataTable distinctValues = view.ToTable(true, "TypeName");



                int TotalRec = 0;
                if (courseDt.Rows.Count > 0)
                {
                    string localPath = string.Empty;
                    var fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        localPath = fbd.SelectedPath + "\\BloodChemistry" + DateTime.Today.Date.ToString("dd_MMM_yyyy_") + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond + ".pdf";
                        this.Cursor = Cursors.WaitCursor;

                        if (distinctValues.Rows.Count > 1)
                        {
                            Rpt_AllTypeResult rpt = new Rpt_AllTypeResult();
                            rpt.SetDataSource(courseDt);
                            rpt.SetParameterValue("LogoPath", Application.StartupPath + @"\Images\" + Default.logoPath);
                            rpt.SetParameterValue("CompanyName", Default.companyName);
                            rpt.SetParameterValue("Address", Default.companyAddress + ", Telephone : " + Default.Telephone);

                            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, localPath);
                        }
                        else
                        {
                            Rpt_BloodChemistry rpt = new Rpt_BloodChemistry();
                            rpt.SetDataSource(courseDt);
                            rpt.SetParameterValue("LogoPath", Application.StartupPath + @"\Images\" + Default.logoPath);
                            rpt.SetParameterValue("CompanyName", Default.companyName);
                            rpt.SetParameterValue("Address", Default.companyAddress + ", Telephone : " + Default.Telephone);

                            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, localPath);
                        }

                        this.Cursor = Cursors.Default;
                        KryptonMessageBox.Show("Patient Test Report Exported successfully!", "Patient Test Result.", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                        Process.Start(localPath);
                    }
                }
                else
                {
                    KryptonMessageBox.Show("All report result are panding, No Report to view");
                    return;
                }


            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
                return;
            }
        }
    }
}

