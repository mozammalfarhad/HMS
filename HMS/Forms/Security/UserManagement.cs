using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HMS.Forms.BaseForms;
using HMS.BLL;
using System.Web.Security;
using ComponentFactory.Krypton.Toolkit;

namespace HMS.Forms.Security
{
    public partial class UserManagement : BaseDataGrid
    {
        string UserName;
        private int clubID;
        ComboBox ddlClubShadow = new ComboBox();
        ComboBox ddlRoleShadow = new ComboBox();
        
        public UserManagement()
        {
            InitializeComponent();
        }

        public UserManagement(int _clubID, string _UserName)
        {
            InitializeComponent();
            clubID = _clubID;
            UserName = "SystemAdmin";
      
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            UserName = "SystemAdmin";
            BindRole();
           // Membership.CreateUser("Admin", "12345ABC?!", "admin@mail.com");
          
            BindData();
        }

        private void LoadClub()
        {
            //DataTable dtClub;
            //if (clubID != 0)
            //    dtClub = new bllClub().GetByClubID(clubID);
            //else
            //{
            //    dtClub = new bllClub().GetList();

            //    ddlClub.Items.Add("All");
            //    ddlClubShadow.Items.Add("0");
            //}
            //foreach (DataRow dr in dtClub.Rows)
            //{
            //    ddlClub.Items.Add(dr["ClubName"].ToString());
            //    ddlClubShadow.Items.Add(dr["ClubID"].ToString());
            //}
            //if (clubID > 0)
            //    ddlClub.SelectedIndex = 0;
        }

        private void BindRole()
        {
            if (Roles.IsUserInRole(UserName, "SystemAdmin"))
            {
                ddlRole.Items.Add("All");
                ddlRole.Items.Add("SystemAdmin");
                ddlRole.Items.Add("Admin");
                ddlRole.Items.Add("Laboratorist");
                ddlRole.Items.Add("Operator");
            }
            else if (Roles.IsUserInRole("Admin", "Admin"))
            {
                ddlRole.Items.Add("Admin");
                ddlRole.Items.Add("Laboratorist");
                ddlRole.Items.Add("Operator");
            }
            ddlRole.SelectedIndex = 0;
        }

        void BindData()
        {
            string Criteria = "";
            DataView dv;
            //if (clubID > 0)
            //    dv = new bllUser().GetSystemUsers().DefaultView;
            //else
            //{
                dv = new bllUser().GetSystemUsers().DefaultView;
                //if (ddlClub.SelectedIndex != -1 && ddlClub.SelectedIndex != 0)
                //{
                //    Criteria = "ClubID=" + ddlClubShadow.Items[ddlClub.SelectedIndex].ToString();
                //}
           // }
                if (ddlRole.Text != "All")
                {
                    if (Criteria == "")
                        Criteria = "RoleName='" + ddlRole.Text + "'";
                    else
                        Criteria += " And RoleName='" + ddlRole.Text + "'";
                }
                dv.RowFilter = Criteria;
            dv.Sort = "RoleName, UserName ASC";
            DataTable dt;
            dt = dv.ToTable();
            dgvMain.AutoGenerateColumns = false;
            dgvMain.DataSource = dt;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMain.Rows.Count == 0 || dgvMain.SelectedRows.Count == 0)
                {
                    KryptonMessageBox.Show("Please select one or more user.", "User Management.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (KryptonMessageBox.Show("Sure to remove?", "User Management.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                foreach (DataGridViewRow row in dgvMain.SelectedRows)
                {
                    string EditUserName = row.Cells["UserNameX"].Value.ToString();
                    if (EditUserName == UserName)
                    {
                        KryptonMessageBox.Show("The User is currently logged in, cannot delete.", "User Management.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    if (EditUserName == "SystemAdmin")
                    {
                        KryptonMessageBox.Show("Built in User, cannot delete.", "User Management.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    Membership.DeleteUser(EditUserName, true);
                    new bllUser().Delete(EditUserName);
                    new bllAudit().Insert("Security", "User Deleted.", "User Name: " + EditUserName, UserName);
                }
                BindData();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "User Management.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //log.LogWarnWithException("Error", ex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMain.Rows.Count == 0 || dgvMain.SelectedRows.Count == 0)
            {
                KryptonMessageBox.Show("Select a user.", "User Management.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string EditUserName = dgvMain.SelectedRows[0].Cells["UserNameX"].Value.ToString();
                int UDUserId =Convert.ToInt32(dgvMain.SelectedRows[0].Cells["UDUserId"].Value.ToString());
            UserEditForm meX = new UserEditForm(UserName, UDUserId,EditUserName);
            DialogResult dr = meX.ShowDialog();
            if (dr == DialogResult.Yes)
                BindData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchTop_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (dgvMain.Rows.Count == 0 || dgvMain.SelectedRows.Count == 0)
            {
                KryptonMessageBox.Show("Select a user.", "User Management.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string EditUserName = dgvMain.SelectedRows[0].Cells["UserNameX"].Value.ToString();
            ResetPassword meX = new ResetPassword(UserName, EditUserName);
            meX.ShowDialog();
        }

        //private void dgvMain_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    string EditUserName = dgvMain.SelectedRows[0].Cells["UserNamex"].Value.ToString();
        //    UserEditForm meX = new UserEditForm(UserName, clubID, EditUserName);
        //    meX.ShowDialog();
        //}

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string EditUserName = dgvMain.SelectedRows[0].Cells["UserNameX"].Value.ToString();
            UserEditForm meX = new UserEditForm(UserName, clubID, EditUserName);
            meX.ShowDialog();
        }
    }
}
