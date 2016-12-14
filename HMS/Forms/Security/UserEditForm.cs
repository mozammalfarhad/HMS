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
using HMS.BLL;

namespace HMS.Forms.Security
{
    public partial class UserEditForm : BaseGeneralSetup
    {

        private int ID;
        private string EditUserName;
        private string UserName;

        public UserEditForm()
        {
            InitializeComponent();
        }

        public UserEditForm(string _UserName, int _ID, string _EditUserName)
        {
            InitializeComponent();
            UserName = _UserName;
            ID = _ID;
            EditUserName = _EditUserName;            
            //if (ID > 0)
            //    ddlClub.Enabled = false;
            hdrBaseCaption.Text = "Edit User";
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {
            BindRole();
            LoadControl();
        }

       

        private void BindRole()
        {
            if (Roles.IsUserInRole(UserName, "SystemAdmin"))
            {
                ddlRole.Items.Add("SystemAdmin");
                ddlRole.Items.Add("Admin");
                ddlRole.Items.Add("Operator");
            }
            else if (Roles.IsUserInRole(UserName, "Admin"))
            {
                ddlRole.Items.Add("Admin");
                ddlRole.Items.Add("COperator");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidation())
                {
                    EP.Clear();

                    MembershipUser mu = Membership.GetUser(EditUserName);
                    mu.Email = tbxEmail.Text;
                    Membership.UpdateUser(mu);
                    Roles.RemoveUserFromRoles(mu.UserName, Roles.GetRolesForUser(mu.UserName));
                    Roles.AddUserToRole(EditUserName, ddlRole.Text);
                   
                    
                    new bllUser().Insert(ID,EditUserName,  tbxName.Text,tbxMobileNo.Text);
                    new bllAudit().Insert("Security", "User Edited", "User Name: " + mu.UserName, UserName);
                    KryptonMessageBox.Show("User saved successfully!", "Edit User.", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Edit User.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //logging.LogErrorWithException("Saving Error",ex);
            }
        }

        void LoadControl()
        {
            try
            {
                if (EditUserName != "")
                {
                    MembershipUser mu = Membership.GetUser(EditUserName);
                    txtUserName.Text = mu.UserName;
                    tbxEmail.Text = mu.Email;
                    string RoleName = Roles.GetRolesForUser(mu.UserName)[0];
                    for (int i = 0; i < ddlRole.Items.Count; i++)
                    {
                        if (ddlRole.Items[i].ToString() == RoleName)
                        {
                            ddlRole.SelectedIndex = i;
                            break;
                        }
                    }
                    DataTable dt = new bllUser().GetByUserName(mu.UserName);
                    if (dt.Rows.Count > 0)
                    {
                        //if (dt.Rows[0]["ClubName"].ToString() != "")
                        //{
                        //    ddlClub.SelectedValue = dt.Rows[0]["ClubID"].ToString();
                        //}
                        tbxName.Text = dt.Rows[0]["FullName"].ToString();
                        tbxMobileNo.Text = dt.Rows[0]["MobileNo"].ToString();

                        //if (Common.IsDate(dt.Rows[0]["ExpiryDate"].ToString()))
                        //    dpDate.Value = DateTime.Parse(dt.Rows[0]["ExpiryDate"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                //logging.LogErrorWithException("Error Loading data by tournament ID", ex);
            }
        }

        private void ClearControls()
        {
            tbxName.Clear();
           
            txtUserName.Clear();
            ddlRole.SelectedIndex = -1;
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
            if (!tbxEmail.Text.Any())
            {
                EP.SetError(tbxEmail, "Email must be provided");
                return false;
            }
            return true;
        }

        private void ddlClub_KeyDown(object sender, KeyEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
