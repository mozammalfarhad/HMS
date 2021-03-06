﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HMS.App_Code.BLL;
using HMS.Forms.BaseForms;
using HMS.Properties;
using HMS.Forms.ListForms;

namespace HMS.Report
{
    public partial class PatientTestDetails : BaseDataGrid
    {
        public bool patientForCollection = false;
        public PatientTestDetails()
        {
            InitializeComponent();
           
            BindData();
            LoadPatient();
            FromDate.Format = DateTimePickerFormat.Custom;
            FromDate.CustomFormat = "dd/mm/yyyy";
            ToDate.Format = DateTimePickerFormat.Custom;
            ToDate.CustomFormat = "dd/mm/yyyy";
            
        }
        string UserName;
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        string pdfFileName = string.Empty;
        private void LoadPatient()
        {
            ddlPatient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ddlPatient.AutoCompleteSource = AutoCompleteSource.ListItems;
            DataTable dtPatient = new bllPatient().GetAll();
            DataRow dr = dtPatient.NewRow();
            dr["PatientID"] = "0";
            dr["PatientName"] = "Select";
            dtPatient.Rows.InsertAt(dr, 0);
            ddlPatient.DataSource = dtPatient;
            ddlPatient.DisplayMember = "PatientName";
            ddlPatient.ValueMember = "PatientID";
          
            ddlPatient.SelectedIndex = 0;
            //PatientCode

        }


        private void tbxPatientCode_TextChanged(object sender, EventArgs e)
        {
            tbxPatientCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbxPatientCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TextBox t = sender as TextBox;
            if (tbxPatientCode.Text != null)
            {
                //say you want to do a search when user types 3 or more chars
                if (tbxPatientCode.Text.Length >= 3)
                {
                    AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                    DataTable dtPatient = new bllPatient().GetAll();
                    foreach (DataRow dr in dtPatient.Rows)
                    {
                        col.Add(dr["PatientCode"].ToString());
                    }

                    tbxPatientCode.AutoCompleteCustomSource = col;
                  
                }
            }
        }

        private void btnViewPdf_Click(object sender, EventArgs e)
        {
            ViewPdf();
        }

        

        private void BindData()
        {
            int patientID = 0;
            if (ddlPatient.SelectedIndex > 0)
            {
                patientID = Convert.ToInt32(ddlPatient.SelectedValue);
            }
            try
            {
                var Criteria = GetCriteria();

                DataTable dt = new bllPatientServicDetails().GetList(CurrentPage * PageSize, PageSize, Criteria, false);
           
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
                        dr["PatientID"],
                        dr["PatientCode"],     
                        dr["Name"],  
                        //dr["Email"],   
                      //  dr["Address"],
                        dr["MobileNo"],     
                         dr["GenderAge"],
                        //dr["Age"],
                        dr["BloodGroup"],  
                       
                        dr["ReferBy"],
                         dr["SheduleId"],

                         dr["ReceiveDate"],
                        dr["ReceiveTime"],
                         dr["DeliveryDate"],
                        dr["DeliveryTime"],
                        dr["PayableAmt"],

                         dr["totalDiscount"],
                        dr["PaidAmount"],
                         dr["Status"]
                 
                    });

                    //string imagepath = dr["Image"].ToString();
                    //if (imagepath != "")
                    //{
                    //    img = new Bitmap(Application.StartupPath + @"\Images\" + imagepath);
                    //}
                    //else
                    //{
                    //    img = new Bitmap(Application.StartupPath + @"\Images\" + "user-blank.PNG");
                    //}
                    //dgvMain.Rows[RowNum].Cells[16].Value = img;
                    dgvMain.Rows[RowNum].Tag = dr["SheduleId"].ToString();
                }




              //  ChangeDataGridHeader();
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
                Criteria = "(PatientCode like '%" + tbxPatientCode.Text.Trim() + "%' " +
                           " or Name like '%" + tbxSearch.Text.Trim() + "%'" + "  or Gender like '%" + tbxSearch.Text.Trim() + "%'" + " or Email like '%" + tbxSearch.Text.Trim() + "%'" + " or Status like '%" + tbxSearch.Text.Trim() + "%'" + " or MobileNo like '%" + tbxSearch.Text.Trim() + "%')";
            }
            else if (tbxPatientCode.Text.Trim() != "")
            {
                if (Criteria == "")

                Criteria = "(PatientCode = '" + tbxPatientCode.Text.Trim() + "')";
                else
                    Criteria += " And PatientCode='" + tbxPatientCode.Text.Trim() + "'";
            }
            else if (tbxMobile.Text.Trim() != "")
            {
                if (Criteria == "")

                    Criteria = "(MobileNo = '" + tbxMobile.Text.Trim() + "')";
                else
                    Criteria += " And MobileNo='" + tbxMobile.Text.Trim() + "'";
            }
            else if (FromDate.Text.Trim() != "" && ToDate.Text.Trim() != "")
            {
                if (FromDate.Checked && ToDate.Checked)
                {
                    if (Criteria == "")

                        Criteria = "(ReceiveDate between '" + FromDate.Text.Trim() + "' And '" + ToDate.Text.Trim() +
                                   "')";
                    else
                        Criteria += " And (ReceiveDate between '" + FromDate.Text.Trim() + "' And '" +
                                    ToDate.Text.Trim() + "')";
                }
            }
            else if (FromDate.Text.Trim() != "")
            {
                if (FromDate.Checked)
                {
                    if (Criteria == "")

                        Criteria = "(ReceiveDate = '" + FromDate.Text.Trim() + "')";
                    else
                        Criteria += " And ReceiveDate='" + FromDate.Text.Trim() + "'";
                }
            }
            else if (ToDate.Text.Trim() != "")
            {
                if (ToDate.Checked)
                {
                    if (Criteria == "")

                        Criteria = "(ReceiveDate = '" + FromDate.Text.Trim() + "')";
                    else
                        Criteria += " And ReceiveDate='" + FromDate.Text.Trim() + "'";
                }
            }
            
            if (ddlPatient.SelectedIndex >0)
            {
                Criteria = "";
                if (Criteria == "")
                    Criteria = "PatientID=" + ddlPatient.SelectedValue;
                else
                    Criteria += " And PatientID=" + ddlPatient.SelectedValue;

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
            dgvMain.Columns["ConsultantCode"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["ConsultantName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["ConsultantAddress"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["ConsultantMobileNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["ConsultantEmail"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["DepName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["ConsultantGender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["ConsultantQualification"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // dgvMain.Columns["ConsultantImage"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void ViewPdf()
        {
            int patientID = 0;
            int ScheduleID = 0;
            //crs = cmbCourse.SelectedIndex > 0 ? cmbCourseShadow.Items[cmbCourse.SelectedIndex].ToString() : "0";  
            try
            {
                if (dgvMain.Rows.Count == 0 || dgvMain.SelectedRows.Count == 0)
                {
                    KryptonMessageBox.Show("Select A Service Type", "Service Type List.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    patientID = int.Parse(dgvMain.CurrentRow.Cells[0].Value.ToString());
                    ScheduleID = int.Parse(dgvMain.CurrentRow.Cells[7].Value.ToString());
                }


                DataTable courseDt = new bllPatientServicDetails().GetPatientServicDetailsByID(patientID, ScheduleID);
                 
          
               
                //dt = new bllTournament().GetListWithFiltering();
                int TotalRec = 0;
                if (courseDt.Rows.Count > 0)
                    TotalRec = courseDt.Rows.Count;
                else
                {
                    TotalRec = 0;
                }

                string localPath = string.Empty;
                var fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    localPath = fbd.SelectedPath + "\\PatientTestDetails_" + DateTime.Today.Date.ToString("dd_MMM_yyyy_") + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond + ".pdf";
                    this.Cursor = Cursors.WaitCursor;
                    rptPatientServiceDetails rpt = new rptPatientServiceDetails();
                    rpt.SetDataSource(courseDt);

                    //rpt.SetParameterValue("ClubName", _ClubName);
                    rpt.SetParameterValue("LogoPath",Application.StartupPath + @"\logo-url.jpg");
                    //rpt.SetParameterValue("ReportName", "Tournament List");
                    //rpt.SetParameterValue("Date", "Date: " + DateTime.Today.ToString("dd-MMM-yyyy"));

                    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, localPath);
                    this.Cursor = Cursors.Default;
                    KryptonMessageBox.Show("Patient Test Details Exported successfully!", "Patient Test Details.", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);
                    Process.Start(localPath);
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void tbxMobile_TextChanged(object sender, EventArgs e)
        {
            tbxMobile.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbxMobile.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TextBox t = sender as TextBox;
            if (tbxMobile.Text != null)
            {
                //say you want to do a search when user types 3 or more chars
                if (tbxMobile.Text.Length >= 3)
                {
                    AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                    DataTable dtPatient = new bllPatient().GetAll();
                    foreach (DataRow dr in dtPatient.Rows)
                    {
                        col.Add(dr["MobileNo"].ToString());
                    }

                    tbxMobile.AutoCompleteCustomSource = col;

                }
            }
        }

        private void btnSearchTop_Click(object sender, EventArgs e)
        {
            BindData();
        }


        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ScheduleID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[7].Value);
            if(!patientForCollection)
            {
                TestResultEntry frm = new TestResultEntry(ScheduleID);
                frm.ShowDialog();
            }
            else
            {
                CollectionList cfrm = new CollectionList(ScheduleID);
                cfrm.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
        
        //private void bgwPdf_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    ViewPdf();
        //}

        //private void bgwPdf_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    Process.Start(pdfFileName);
        //    bgwPdf.Dispose();
        //}
    }
}
