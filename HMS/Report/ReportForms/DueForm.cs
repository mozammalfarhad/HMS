using ComponentFactory.Krypton.Toolkit;
using HMS.App_Code.BLL;
using HMS.Forms.BaseForms;
using HMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace HMS.Report.ReportForms
{
    public partial class DueForm : BaseDataGrid
    {
        DateTime DateFrom;
        DateTime DateTo ;
        DataTable courseDt = new DataTable();
        public DueForm()
        {
            InitializeComponent();
            GetUsers();
        }

        private void GetUsers()
        {
            string[] rolesArray;
            MembershipUserCollection  users;
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

        private void btnSearchTop_Click(object sender, EventArgs e)
        {
            try
            {
                

                //string localPath = string.Empty;
                //var fbd = new FolderBrowserDialog();
                //if (fbd.ShowDialog() == DialogResult.OK)
                //{
                //  //  localPath = fbd.SelectedPath + "\\ReferrerFeeDetails_" + DateTime.Today.Date.ToString("dd_MMM_yyyy_") + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond + ".pdf";

              //  this.Cursor = Cursors.WaitCursor;
                Rpt_DueCollectionList rpt = new Rpt_DueCollectionList();
                rpt.SetDataSource(LoadData());

                rpt.SetParameterValue("LogoPath", Application.StartupPath + @"\Images\" + Default.logoPath);
                rpt.SetParameterValue("CompanyName", Default.companyName);
                rpt.SetParameterValue("Address", Default.companyAddress + ", Telephone : " + Default.Telephone);
                crystalReportViewer.ReportSource = rpt;
                //  rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, localPath);
                // this.Cursor = Cursors.Default;
                // KryptonMessageBox.Show("Referrer Fee Details Exported successfully!", "Referrer Fee Details.", MessageBoxButtons.OK,
                //                      MessageBoxIcon.Information);
                // Process.Start(localPath);
                //  }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message);
               // this.Cursor = Cursors.Default;
                return;
            }
        }


        private DataTable LoadData()
        {
            DataView dv;
            if (DateFrom.Equals("{01/Jan/0001 00:00:00}") || FromDate.Value < DateFrom || ToDate.Value > DateTo)
            {
                DateFrom = FromDate.Value;
                DateTo = ToDate.Value;
                courseDt = new bllCollection().GetDueCollection(FromDate.Value, ToDate.Value);
            }

            if (ddlUsers.SelectedIndex!=0)
            {
                dv = new DataView(courseDt, " UserName = '" + ddlUsers.Text+"'", "", DataViewRowState.CurrentRows);
            }
            else
            {
                dv = new DataView(courseDt, "", "", DataViewRowState.CurrentRows);
            }

            return dv.ToTable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
