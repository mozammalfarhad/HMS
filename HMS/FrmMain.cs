using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using CrystalDecisions.Web;
using HMS.App_Code.BLL;
using HMS.Views;
using HMS.Forms.BaseForms;
using HMS.Forms.DatabaseOperations;
using HMS.Forms.ListForms;
using HMS.Forms.Security;
using HMS.Forms.SetupForms;
using HMS.Model;
using HMS.Report;
using HMS.Report.Dataset;
using HMS.Report.ReportForms;

//using BGFHandicapApp.Forms.Security;
//using BGFHandicapApp.Forms.ListForms;
//using BGFHandicapApp.Forms.UploadDownload;
//using BGFHandicapApp.Forms.DatabaseOperations;
//using BGFHandicapApp.Forms.CompanyForms;

namespace HMS.Views
{
    public partial class FrmMain : KryptonForm
    {
        string UserName;
        string RoleName;
        int ClubID;
        //ImportForm imX;
        //MemberEntry memberEntry;
        //ScoreEntry sce;
        //MemberList memberList;
        //ScoreList scoreList;
        //LogForm logX;
        //MemberReport memberReport;
        private UserForm userForm;
        private UserManagement userManagement;
        private ChangePassword changePassword;
        //private Report.ReportMain reportMain;
        //private BackUpForm baX;
        //private TournamentEntry tour;
        //private PublishSchedule publishSchedule;
        //private DefaultSettings defaultSettings;
        //private FiscalYearList  fiscalYearList;
        //private FiscalYearEntry fiscalYearEntry;

        public FrmMain()
        {
            InitializeComponent();

            timer2.Enabled = false;
        }

        public FrmMain(string _UserName, string _RoleName, int _ClubID)
        {
            InitializeComponent();
            UserName = _UserName;
            RoleName = _RoleName;
            ClubID = _ClubID;

            Default.UserName = _UserName;
            DataTable dt = new bllCompanyInfo().GetCompanyInfo();
            if (dt.Rows.Count > 0)
            {

                Default.companyName = dt.Rows[0]["ComapayName"].ToString();
                Default.companyAddress = dt.Rows[0]["Address"].ToString();
                Default.logoPath = dt.Rows[0]["Logo"].ToString();
                Default.Telephone = dt.Rows[0]["Tel"].ToString();
                Default.Mobile = dt.Rows[0]["Mobile"].ToString();
                Default.Fax = dt.Rows[0]["Fax"].ToString();
                Default.Email = dt.Rows[0]["Email"].ToString();
                Default.Web = dt.Rows[0]["Web"].ToString();

            }
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            sbUserName.Text = UserName;
        }

        private void miFile_Exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void miHelpAbout_Click(object sender, System.EventArgs e)
        {
            //AboutUs frm = new AboutUs();
            //frm.ShowDialog();
        }

        private void showToolbarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (showToolbarToolStripMenuItem.Checked)
            {
                tbrMain.Hide();
                showToolbarToolStripMenuItem.Checked = false;
            }
            else
            {
                tbrMain.Show();
                showToolbarToolStripMenuItem.Checked = true;
            }
        }

        private void showStatusbarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (showStatusbarToolStripMenuItem.Checked)
            {
                stbStatusBar.Hide();
                showStatusbarToolStripMenuItem.Checked = false;
            }
            else
            {
                stbStatusBar.Show();
                showStatusbarToolStripMenuItem.Checked = true;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem5_Click(object sender, System.EventArgs e)
        {
            //DepartmentEntry frm = new DepartmentEntry();
            //frm.ShowDialog();
            //if (imX == null)
            //{
            //    imX = new CompanyEntry(UserName, ClubID);
            //    imX.MdiParent = this;
            //    imX.Show();
            //}
            //else
            //{
            //    tabForms.SelectTab("ImportForm");
            //    imX.Select();
            //}
        }


        private void scoreToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //if (sce == null)
            //{
            //    sce = new ScoreEntry(ClubID, 0);
            //    sce.MdiParent = this;
            //    sce.Show();
            //}
            //else
            //{
            //    tabForms.SelectTab("ScoreEntry");
            //    sce.Select();
            //}
        }

        private void memberToolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            PatientEntry pa = new PatientEntry();
            pa.ShowDialog();
        }

        private void scoreToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            //if (scoreList == null)
            //{
            //    scoreList = new ScoreList(ClubID, UserName);
            //    scoreList.MdiParent = this;
            //    scoreList.Show();
            //}
            //else
            //{
            //    //tabForms.SelectTab("ScoreEditForm");
            //    tabForms.SelectTab("ScoreList");
            //    scoreList.Select();
            //}
        }

        private void toolStripMenuItem3_Click(object sender, System.EventArgs e)
        {
            //baX = new BackUpForm(UserName);
            //baX.ShowDialog();
            BackUpForm frm = new BackUpForm(UserName);
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, System.EventArgs e)
        {
            RestoreDataForm reX = new RestoreDataForm(UserName);
            reX.ShowDialog();
        }

        private void logToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //if (logX == null)
            //{
            //    logX = new LogForm();
            //    logX.MdiParent = this;
            //    logX.Show();
            //}
            //else
            //{
            //    tabForms.SelectTab("LogForm");
            //    logX.Select();
            //}
        }



        #region Tabbed MDI

        private void frmMain_MdiChildActivate(object sender, System.EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                tabForms.Visible = false;
            // If no any child form, hide tabControl 
            else
            {
                this.ActiveMdiChild.WindowState =
                FormWindowState.Maximized;
                // Child form always maximized
                // If child form is new and no has tabPage,
                // create new tabPage 
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child
                    // form caption 
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Name = ActiveMdiChild.Name;
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms;
                    tabForms.SelectedTab = tp;
                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosing += new FormClosingEventHandler(ActiveMdiChild_FormClosing);
                }
                if (!tabForms.Visible) tabForms.Visible = true;
            }
        }

        private void ActiveMdiChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
            //imX = null;
            //memberEntry = null;
            //sce = null;
            //scoreList = null;
            //memberList = null;
            //logX = null;
            //tour = null;
            //tour = null;
            //tour = null;
            //tournamentList = null;
            //publishSchedule = null;
            //defaultSettings = null;
            //memberReport = null;
            //reportMain = null;
            //baX = null;
            //userForm = null;
            //userManagement = null;
            //changePassword = null;
        }

        private void tabForms_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if ((tabForms.SelectedTab != null) && (tabForms.SelectedTab.Tag != null))
                (tabForms.SelectedTab.Tag as Form).Select();
        }

        #endregion

        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text == "")
            {
                e.Item.Visible = false;
            }
        }



        private void BtnTournamentListClick(object sender, System.EventArgs e)
        {
            //if (tournamentList == null)
            //{
            //    tournamentList = new TournamentList(ClubID, UserName);
            //    tournamentList.MdiParent = this;
            //    tournamentList.Show();
            //}
            //else
            //{
            //    tabForms.SelectTab("TournamentList");
            //    tournamentList.Select();
            //}
        }

        private void userManualToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Manual.pdf");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Manual.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //if (reportMain == null)
            //{
            //    reportMain = new Report.ReportMain(ClubID, UserName);
            //    reportMain.MdiParent = this;
            //    reportMain.Show();
            //}
            //else
            //{
            //    tabForms.SelectTab("ReportMain");
            //}
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            //if (reportMain == null)
            //{
            //    reportMain = new Report.ReportMain(ClubID, UserName);
            //    reportMain.MdiParent = this;
            //    reportMain.Show();
            //}
            //else
            //{
            //    tabForms.SelectTab("ReportMain");
            //}
        }

        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {
            PatientTestDetails pfrm = new PatientTestDetails();
            pfrm.patientForCollection = true;
            pfrm.ShowDialog();
        }

        private void tsUpdateCheck_Click(object sender, EventArgs e)
        {


            RunTrueUpdateClient();
        }

        private void RunTrueUpdateClient()
        {
            bool bReturn = true;
            try
            {
                var UpdateProcess = new Process();
                UpdateProcess.StartInfo.FileName = string.Format("{0}\\" + "Updater.exe", Application.StartupPath);
                UpdateProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                bReturn = UpdateProcess.Start();
            }
            catch (Win32Exception e)
            {
                bReturn = false;
            }
            return;
        }



        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (userForm == null)
                {
                    userForm = new UserForm(UserName, ClubID);
                    userForm.MdiParent = this;
                    userForm.Show();
                }
                else
                {
                    tabForms.SelectTab("UserForm");
                    userForm.Select();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (changePassword == null)
                {
                    changePassword = new ChangePassword(UserName);
                    changePassword.MdiParent = this;
                    changePassword.Show();
                }
                else
                {
                    tabForms.SelectTab("ChangePassword");
                    changePassword.Select();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (userManagement == null)
                {
                    userManagement = new UserManagement(ClubID, UserName);
                    userManagement.MdiParent = this;
                    userManagement.Show();
                }
                else
                {
                    tabForms.SelectTab("UserManagement");
                    userManagement.Select();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CompanySetupMenu_Click(object sender, EventArgs e)
        {
            DepartmentEntry frm = new DepartmentEntry();
            frm.ShowDialog();
        }

        private void UnitSetupMenu_Click(object sender, EventArgs e)
        {
            ServiceTypeEntry frm = new ServiceTypeEntry();
            frm.ShowDialog();
        }

        private void departmentSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultantEntry frm = new ConsultantEntry();
            frm.ShowDialog();

        }

        private void divisionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DivisionEntry frm = new DivisionEntry();
            //frm.ShowDialog();
        }

        private void functionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FunctionEntry frm = new FunctionEntry();
            //frm.ShowDialog();
        }



        private void fiscalYearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentList frm = new DepartmentList();
            frm.ShowDialog();
        }

        private void companyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DoctorList frm = new DoctorList();
            //frm.ShowDialog();

        }

        private void functionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientList frm = new PatientList();
            frm.ShowDialog();
        }

        private void divisionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DivisionList frm = new DivisionList();
            //frm.ShowDialog();
        }

        private void categoryWiseEmployerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CategoryWiseEmployerReport cr = new CategoryWiseEmployerReport();

            //cr.Show();
        }
        private void inOutTimeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //InOutTimeReportForm ifrm = new InOutTimeReportForm();

            //ifrm.Show();
        }
        private void unitListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UnitList frm = new UnitList();
            //frm.ShowDialog();
        }
        private void designationListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DesignationList frm = new DesignationList();
            //frm.ShowDialog();
        }
        private void facilityHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FacilityHome frm=new FacilityHome();
            //frm.ShowDialog();
        }
        private void doctorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultantEntry frm = new ConsultantEntry();
            frm.ShowDialog();
        }
        private void serviceTypeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceTypeList frm = new ServiceTypeList();
            frm.ShowDialog();
        }
        private void serviceEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceEntry frm = new ServiceEntry();
            frm.ShowDialog();
        }
        private void testEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestEntry frm = new TestEntry();
            frm.ShowDialog();
        }
        private void PSSEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PatientServiceScheduleEntry frm = new PatientServiceScheduleEntry();
            frm.ShowDialog();
        }
        private void doctorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultantEntry frm = new ConsultantEntry();
            frm.ShowDialog();
        }
        private void unitEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitEntry frm = new UnitEntry();
            frm.ShowDialog();
        }
        private void serviceAttributeEntrySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceAttributeEntry frm = new ServiceAttributeEntry();
            frm.ShowDialog();
        }
        private void consultantListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultantList frm = new ConsultantList();
            frm.ShowDialog();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestEntry frm = new TestEntry();
            frm.ShowDialog();
        }

        private void vacuumEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VacuumEntry frm = new VacuumEntry();
            frm.ShowDialog();
        }

        private void vacuumListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VacuumList frm = new VacuumList();
            frm.ShowDialog();

        }

        private void referFeeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferFeeEntry frms = new ReferFeeEntry();
            frms.ShowDialog();
        }

        private void patientTestDetailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientTestDetails frm = new PatientTestDetails();
            frm.ShowDialog();
        }

        private void companyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyInfo com = new CompanyInfo();
            com.ShowDialog();
        }

        private void DailySummeryStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.ReportForms.DailySummeryStatement frm = new Report.ReportForms.DailySummeryStatement();
            frm.ShowDialog();
        }

        private void referrerFeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefererDetails frm = new RefererDetails();
            frm.ShowDialog();
        }

        private void dueListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DueForm dfr = new DueForm();
            dfr.ShowDialog();
        }
    }
}