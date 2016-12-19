using ComponentFactory.Krypton.Toolkit;
using HMS.App_Code.BLL;
using HMS.Forms.BaseForms;
using HMS.Model;
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

namespace HMS.Report
{
    public partial class RefererDetails : BaseDataGrid
    {
        string UserName;
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        string pdfFileName = string.Empty;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        DataTable dt;
        public RefererDetails()
        {
            InitializeComponent();
            LoadConsultant();
            BindData();
        }

        private void LoadConsultant()
        {
            DataTable ConsultantList = new bllConsultant().GetAllConsultantList();
            if (ConsultantList.Rows.Count > 0)
            {
                DataRow dr = ConsultantList.NewRow(); //Create New Row
                dr["ConsultantName"] = "Select";              // Set Column Value
                dr["ConsultantId"] = "0";
                ConsultantList.Rows.InsertAt(dr, 0);
                ConsultantList.DefaultView.Sort = "ConsultantId asc";
                comReferrer.DataSource = ConsultantList;
                comReferrer.DisplayMember = "ConsultantName";
                comReferrer.ValueMember = "ConsultantId";
                comReferrer.SelectedIndex = 0;
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearchTop_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
           
                var Criteria = GetCriteria();

                dt = new bllReferrerFeeDetails().GetAllWithPagination(CurrentPage * PageSize, PageSize, Criteria, false);

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
                        dr["PatientCode"],
                        dr["Name"],     
                        dr["Email"],  
                        dr["Address"],     
                         dr["Gender"],
                        dr["Age"],                       
                        dr["ConsultantName"],
                         dr["ReferFee"]
                 
                    });
                }
                managePaging();
        }


        private string GetCriteria()
        {
            string critaria="";
            if(comReferrer.SelectedIndex > 0)
            {
                critaria = " ReferById = '" + comReferrer.SelectedValue+"'";
            }
            if(DateFrom.Checked && DateTo.Checked)
            {
                if (critaria != "")
                    critaria = critaria + " and ";
                critaria =critaria+ " ReceiveDate between '" + DateFrom.Value + "' and '" + DateTo.Value+ "' ";
            }
            return critaria;
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

        private void btnViewPdf_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable courseDt = new bllReferrerFeeDetails().GetAllWithoutPagination(GetCriteria());

            //   // this.Cursor = Cursors.WaitCursor;
            //    Rpt_RefererFeeDetails rpt = new Rpt_RefererFeeDetails();
            //    rpt.SetDataSource(courseDt);

            //    // rpt.SetParameterValue("LogoPath", Application.StartupPath + @"\logo-url.jpg");
            //    //rpt.SetParameterValue("ReportName", "Tournament List");
            //    //rpt.SetParameterValue("Date", "Date: " + DateTime.Today.ToString("dd-MMM-yyyy"));
            //    ReportViewer frm = new ReportViewer();
            //    frm.CRV.ReportSource = rpt;
            //    frm.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    KryptonMessageBox.Show(ex.Message);
            //   // this.Cursor = Cursors.Default;
            //    return;
            //}
            try
            {
                DataTable courseDt = new bllReferrerFeeDetails().GetRefereerSummeryByDateRange(Convert.ToDateTime(DateFrom.Value), Convert.ToDateTime(DateTo.Value), Convert.ToInt32(comReferrer.SelectedValue));

               // this.Cursor = Cursors.WaitCursor;
                Rpt_RefererSummeryByDateRangeAll rpt = new Rpt_RefererSummeryByDateRangeAll();
                rpt.SetDataSource(courseDt);

                rpt.SetParameterValue("LogoPath", Application.StartupPath + @"\Images\" + Default.logoPath);
                rpt.SetParameterValue("FromDate", DateFrom.Text);
                rpt.SetParameterValue("ToDate", DateTo.Text);
                rpt.SetParameterValue("CompanyName", Default.companyName);
                rpt.SetParameterValue("Address", Default.companyAddress + ", Telephone : " + Default.Telephone);
                ReportViewer frm = new ReportViewer();
                frm.CRV.ReportSource = rpt;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message);
               // this.Cursor = Cursors.Default;
                return;
            }
        }

       
    }
}
