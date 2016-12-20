using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HMS.App_Code.BLL;
using HMS.Forms.BaseForms;
using HMS.Model;

namespace HMS.Report.ReportForms
{
    public partial class PatientGroupWiseTestDetails : BaseDataGrid
    {
        public PatientGroupWiseTestDetails()
        {
            InitializeComponent();
        }

        private void btnSearchTop_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            
            
                try
                {  
                    DataTable dt =new DataTable();
                    dt = new bllGroupWisePatientTestDetails().GetGroupWisePatientTestDetails(
                            Convert.ToDateTime(Convert.ToDateTime(FromDate.Text).ToString("yyyy-MM-dd")),
                            Convert.ToDateTime(Convert.ToDateTime(ToDate.Text).ToString("yyyy-MM-dd")));
                    if (dt.Rows.Count > 0)
                    {
                        Rpt_GroupWisePatientTestDetails rpt = new Rpt_GroupWisePatientTestDetails();
                        rpt.SetDataSource(dt);
                        rpt.SetParameterValue("Logo", Application.StartupPath + @"\Images\" + Default.logoPath);
                        rpt.SetParameterValue("FromDate", FromDate.Text);
                        rpt.SetParameterValue("ToDate", ToDate.Text);
                        rpt.SetParameterValue("CompanyName", Default.companyName);
                        rpt.SetParameterValue("Address", Default.companyAddress + ", Telephone : " + Default.Telephone);
                        crystalReportViewer.ReportSource = rpt;
                    }
                     
                    
                }
                catch (Exception ex)
                {
                    KryptonMessageBox.Show(ex.Message);
                    return;
                }
            }
        

        

        private void btnViewPdf_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
