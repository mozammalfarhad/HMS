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
    public partial class DailySummeryStatement : BaseDataGrid
    {
        public DailySummeryStatement()
        {
            InitializeComponent();
            ReportType.SelectedIndex = 0;
            GetUsers();
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
                    if(ReportType.SelectedIndex==0)
                    {
                        dt = new bllStatement().GetDailySummaryStatement(ddlUsers.Text,
                             Convert.ToDateTime(Convert.ToDateTime(FromDate.Text).ToString("yyyy-MM-dd")),
                             Convert.ToDateTime(Convert.ToDateTime(ToDate.Text).ToString("yyyy-MM-dd")));
                        DataTable SubDt = new bllStatement().GetDailySummaryStatementSubReportData(ddlUsers.Text,
                             Convert.ToDateTime(Convert.ToDateTime(FromDate.Text).ToString("yyyy-MM-dd")),
                             Convert.ToDateTime(Convert.ToDateTime(ToDate.Text).ToString("yyyy-MM-dd")));
                        if (dt.Rows.Count > 0)
                        {
                            rptDailySummeryStatement rpt = new rptDailySummeryStatement();
                            rpt.SetDataSource(dt);
                            rpt.Subreports[0].SetDataSource(SubDt);
                            rpt.SetParameterValue("Logo", Application.StartupPath + @"\Images\" + Default.logoPath);
                            rpt.SetParameterValue("FromDate", FromDate.Text);
                            rpt.SetParameterValue("ToDate", ToDate.Text);
                            rpt.SetParameterValue("CompanyName", Default.companyName);
                            rpt.SetParameterValue("Address", Default.companyAddress + ", Telephone : " + Default.Telephone);
                            crystalReportViewer.ReportSource = rpt;
                        }
                    }
                    else if (ReportType.SelectedIndex == 1)
                    {
                        dt = new bllStatement().GetLedgerStatement(ddlUsers.Text,
                             Convert.ToDateTime(Convert.ToDateTime(FromDate.Text).ToString("yyyy-MM-dd")),
                             Convert.ToDateTime(Convert.ToDateTime(ToDate.Text).ToString("yyyy-MM-dd")));
                        if (dt.Rows.Count > 0)
                        {
                            LedgerStatement rpt = new LedgerStatement();
                            rpt.SetDataSource(dt);
                            rpt.SetParameterValue("Logo", Application.StartupPath + @"\Images\" + Default.logoPath);
                            rpt.SetParameterValue("FromDate", FromDate.Text);
                            rpt.SetParameterValue("ToDate", ToDate.Text);
                            rpt.SetParameterValue("CompanyName", Default.companyName);
                            rpt.SetParameterValue("Address", Default.companyAddress + ", Telephone : " + Default.Telephone);
                            crystalReportViewer.ReportSource = rpt;
                        }
                    }
                    else
                    {
                        dt = new bllStatement().GetLedgerStatementDetails(ddlUsers.Text,
                             Convert.ToDateTime(Convert.ToDateTime(FromDate.Text).ToString("yyyy-MM-dd")),
                             Convert.ToDateTime(Convert.ToDateTime(ToDate.Text).ToString("yyyy-MM-dd")));
                        if (dt.Rows.Count > 0)
                        {
                            LedgerStatementDetails rpt = new LedgerStatementDetails();
                            rpt.SetDataSource(dt);
                            rpt.SetParameterValue("Logo", Application.StartupPath + @"\Images\" + Default.logoPath);
                            rpt.SetParameterValue("FromDate", FromDate.Text);
                            rpt.SetParameterValue("ToDate", ToDate.Text);
                            rpt.SetParameterValue("CompanyName", Default.companyName);
                            rpt.SetParameterValue("Address", Default.companyAddress + ", Telephone : " + Default.Telephone);
                            crystalReportViewer.ReportSource = rpt;
                        }
                    }
                     
                    
                }
                catch (Exception ex)
                {
                    KryptonMessageBox.Show(ex.Message);
                    return;
                }
            }
        

        private void GetUsers()
        {
            string[] rolesArray;
            MembershipUserCollection users;
            string[] usersInRole;
            rolesArray = Roles.GetRolesForUser(HMS.Properties.Settings.Default.UserName); //Roles.GetAllRoles();
            string rolename = rolesArray[0].ToString();
            users = Membership.GetAllUsers();  //Membership.GetAllUsers();
            ddlUsers.Items.Add("Select");
            foreach (var item in users)
            {
                ddlUsers.Items.Add(item);//
            }
            ddlUsers.SelectedIndex = 0;
            
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
