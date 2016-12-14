using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HMS.Forms.BaseForms;
using ComponentFactory.Krypton.Toolkit;
using System.Web.Security;
using HMS.BLL;

namespace HMS.Forms.Security
{
    public partial class ResetPassword : BaseGeneralSetup
    {
        private string UserName;
        private string EditUserName;
        
        public ResetPassword()
        {
            InitializeComponent();
        }

        public ResetPassword(string _UserName, string _EditUserName)
        {
             InitializeComponent();
            UserName = _UserName;
            EditUserName = _EditUserName;
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = EditUserName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidation())
                {
                    EP.Clear();
                    MembershipUser user = Membership.GetUser(txtUserName.Text);
                    
                    string oldPassword = user.ResetPassword();


                    if (user.ChangePassword(oldPassword, tbxPassword.Text))
                    {

                        new bllAudit().Insert("Security", "Reset Password", "User:" + txtUserName.Text, UserName);

                        KryptonMessageBox.Show("User saved successfully!", "Reset Password.", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);
                    }


                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Reset Password.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        bool CheckValidation()
        {

            if (!tbxPassword.Text.Any())
            {
                EP.SetError(tbxPassword, "Password must be provided");
                return false;
            }

            if (!tbxConfirmPassword.Text.Any())
            {
                EP.SetError(tbxConfirmPassword, "Confirm Password must be provided");
                return false;
            }

            if (tbxConfirmPassword.Text != tbxPassword.Text)
            {
                EP.SetError(tbxConfirmPassword, "Password and Confirm Password must be same");
                return false;
            }


            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
