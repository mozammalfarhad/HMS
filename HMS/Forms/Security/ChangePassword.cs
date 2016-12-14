using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HMS.Forms.BaseForms;
using System.Web.Security;
using ComponentFactory.Krypton.Toolkit;

namespace HMS.Forms.Security
{
    public partial class ChangePassword : BaseGeneralSetup
    {
        private String userName;
        
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(String _userName)
        {
            InitializeComponent();
            userName = _userName;            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxNewPw.Text == tbxretype.Text)
                {
                    MembershipUser mu = Membership.GetUser(userName);
                    bool d = mu.ChangePassword(tbxOldPw.Text, tbxretype.Text);
                    if (d == true)
                        KryptonMessageBox.Show("Password changed successfully!", "Change Password.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        KryptonMessageBox.Show("Password Not Changed.", "Change Password.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    KryptonMessageBox.Show("Password Does not Match.", "Change Password.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Password input error!", "Change Password.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //log.LogErrorWithException("Error",ex);
            }
        }

        private void tbxOldPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void tbxretype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSave_Click(sender, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
