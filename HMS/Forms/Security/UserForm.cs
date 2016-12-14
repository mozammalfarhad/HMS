using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Web.Security;
using HMS.BLL;
using HMS.Forms.BaseForms;

namespace HMS.Forms.Security
{
    public partial class UserForm : BaseGeneralSetup
    {
        private int ClubID;
        private string UserName;
        
        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(string _UserName, int _clubID)
        {
             InitializeComponent();
            UserName = _UserName;
            ClubID = _clubID;
          
           
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
           // LoadClub();
            BindRole();
        }

        //private void LoadClub()
        //{
        //    ddlClub.DisplayMember = "ClubName";
        //    ddlClub.ValueMember = "ClubID";

        //    DataTable dtClub;
        //    if (ClubID != 0)
        //        dtClub = new bllClub().GetByClubID(ClubID);
        //    else
        //        dtClub = new bllClub().GetList();

        //    ddlClub.DataSource = dtClub;

        //    if (ClubID > 0)
        //        ddlClub.SelectedIndex = 0;
        //}


        private void BindRole()
        {
            //if (Roles.IsUserInRole(UserName, "SystemAdmin"))
            //{
               ddlRole.Items.Add("SystemAdmin");
               ddlRole.Items.Add("Admin");
               ddlRole.Items.Add("Laboratorist");
               ddlRole.Items.Add("Operator");
            //}

            //else if (Roles.IsUserInRole("Admin", "Admin"))
            //{
            //    ddlRole.Items.Add("Admin");
            //    ddlRole.Items.Add("Laboratorist");
            //    ddlRole.Items.Add("Operator");
            //}

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidation())
                {
                    EP.Clear();

                    MembershipCreateStatus mcs;

                    Membership.CreateUser(txtUserName.Text, tbxPassword.Text, tbxEmail.Text, "A", "B", true, out mcs);

                    if (mcs == MembershipCreateStatus.Success)
                    {
                      
                        Roles.AddUserToRole(txtUserName.Text, ddlRole.Text);

                        new bllUser().Insert(0, txtUserName.Text.Trim(), tbxName.Text.Trim(),  tbxMobileNo.Text.Trim());

                        new bllAudit().Insert("Security", "User Created", "User Name: " + txtUserName.Text + " Role: " + ddlRole.Text, UserName);


                        KryptonMessageBox.Show("User saved successfully.", "User Information.", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);

                        ClearControls();

                    }
                    else
                    {
                        KryptonMessageBox.Show(mcs.ToString(), "User Information.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "User Information.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //logging.LogErrorWithException("Saving Error",ex);
            }
        }


        private void ClearControls()
        {
            tbxName.Clear();
            tbxMobileNo.Clear();
            txtUserName.Clear();
            ddlRole.SelectedIndex = -1;
            tbxPassword.Clear();
            tbxConfirmPassword.Clear();
            tbxEmail.Clear();
        }

        bool CheckValidation()
        {
            if (!tbxName.Text.Any())
            {
                EP.SetError(tbxName, "Full Name must be provided");
                return false;
            }

            if (!tbxMobileNo.Text.Any())
            {
                EP.SetError(tbxMobileNo, "Mobile No must be provided");
                return false;
            }

            if (!txtUserName.Text.Any())
            {
                EP.SetError(txtUserName, "User Name must be provided");
                return false;
            }

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

            if (!tbxEmail.Text.Any())
            {
                EP.SetError(tbxEmail, "Email must be provided");
                return false;
            }

            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void tbxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
