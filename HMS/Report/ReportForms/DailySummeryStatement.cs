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
            GetUsers();
        }

        private void btnSearchTop_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            DataTable dt = new bllStatement().GetDailySummaryStatement(ddlUsers.SelectedText,
                Convert.ToDateTime(Convert.ToDateTime(FromDate.Text).ToString("yyyy-MM-dd")),
                Convert.ToDateTime(Convert.ToDateTime(ToDate.Text).ToString("yyyy-MM-dd")));
            if (dt.Rows.Count > 0)
            {
                try
                {  
                    string localPath = string.Empty;
                    var fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        localPath = fbd.SelectedPath + "\\DailySummeryStatement_" + DateTime.Today.Date.ToString("dd_MMM_yyyy_") +
                                    DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond + ".pdf";
                        this.Cursor = Cursors.WaitCursor;
                        rptDailySummeryStatement rpt = new rptDailySummeryStatement();
                        rpt.SetDataSource(dt);

                        rpt.SetParameterValue("Logo", Application.StartupPath + @"\Images\" + Default.logoPath);
                        rpt.SetParameterValue("FromDate", FromDate.Text);
                        rpt.SetParameterValue("ToDate", ToDate.Text);
                        rpt.SetParameterValue("CompanyName",Default.companyName );
                        //rpt.SetParameterValue("Date", "Date: " + DateTime.Today.ToString("dd-MMM-yyyy"));

                        rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, localPath);
                        this.Cursor = Cursors.Default;
                        KryptonMessageBox.Show("Daily summery statement exported successfully!", "Daily summery statement.",
                            MessageBoxButtons.OK,
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
        }

        private void GetUsers()
        {
            string[] rolesArray;
            string[] users;
            string[] usersInRole;
            rolesArray = Roles.GetRolesForUser(HMS.Properties.Settings.Default.UserName); //Roles.GetAllRoles();
            string rolename = rolesArray[0].ToString();
            users = Roles.GetUsersInRole(rolename); //Membership.GetAllUsers();
            foreach (var item in users)
            {
                ddlUsers.Items.Add(item);
            }
        }

        private void btnViewPdf_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }
    }
}
