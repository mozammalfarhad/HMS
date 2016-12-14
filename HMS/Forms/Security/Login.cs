using System;
using System.Data;
using System.Windows.Forms;
using HMS.BLL;
using HMS.Properties;
using ComponentFactory.Krypton.Toolkit;
using HMS.Forms;
using HMS.Views;
using System.Web.Security;

namespace HMS.Forms.Security
{
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName) || string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                ChkRemember.CheckState = CheckState.Unchecked;
            }
            else
            {
                tbxUserName.Text = Properties.Settings.Default.UserName;
                tbxPassword.Text = Properties.Settings.Default.Password;
                ChkRemember.CheckState = CheckState.Checked;
            }
            tbxUserName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                RememberMe();
                bool isValid = false;
                isValid = Membership.ValidateUser(tbxUserName.Text, tbxPassword.Text);
            
                string RoleForUser = "";
                if (isValid)
                {
                    RoleForUser = Roles.GetRolesForUser(tbxUserName.Text)[0];
                    if (RoleForUser != "SystemAdmin")
                    {
                        DataTable  dt = new bllUser().GetByUserName(tbxUserName.Text);
                    }
                    GenerateSessionID();
                    DefaultSettingsCheck();
                    new FrmMain(tbxUserName.Text, RoleForUser, 0).Show();
                    this.Hide();
                }
                else
                {
                    KryptonMessageBox.Show("Invalid login.", "Login.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //log.LogErrorWithException("Warn",ex);
            }
        }

        private void DefaultSettingsCheck()
        {
            //if (Settings.Default.FromDateForLoadData < DateTime.Now.AddYears(-10))
            //{
                Settings.Default.DateFormat = "Year";
                Settings.Default.ToDate = DateTime.Now.Date;
                Settings.Default.Save();
            //}
        }

        private void GenerateSessionID()
        {
            string st = "";
            //DataTable dt = new bllCourse().GetByClubID(ClubID);
            //if (dt.Rows.Count > 0)
            //    st = dt.Rows[0]["CourseName"].ToString() + "_";
            st = st + DateTime.Now.ToString("dd/MM/yyyy");
            st = st.Replace("/", "");
            Settings.Default.SessionID = st;
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(null, null);
        }

        private void tbxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            RememberMe();
            base.OnClosing(e);
        }

        private void RememberMe()
        {
            if (ChkRemember.Checked)
            {
                Settings.Default.UserName = tbxUserName.Text;
                Settings.Default.Password = tbxPassword.Text;
            }
            else
            {
                Settings.Default.UserName = string.Empty;
                Settings.Default.Password = string.Empty;
            }
            Settings.Default.Save();
        }        
    }
}
