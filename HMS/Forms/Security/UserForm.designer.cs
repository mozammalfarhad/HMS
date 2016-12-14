namespace HMS.Forms.Security
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbxConfirmPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbxPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ddlRole = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tbxName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbxEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbxMobileNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseContainer)).BeginInit();
            this.pnlBaseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseControlContainer)).BeginInit();
            this.pnlBaseControlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Size = new System.Drawing.Size(654, 26);
            this.hdrBaseCaption.Values.Description = "";
            this.hdrBaseCaption.Values.Heading = "Add User";
            this.hdrBaseCaption.Values.Image = null;
            // 
            // pnlBaseContainer
            // 
            this.pnlBaseContainer.Size = new System.Drawing.Size(654, 352);
            // 
            // pnlBaseButtonContainer
            // 
            this.pnlBaseButtonContainer.Location = new System.Drawing.Point(0, 378);
            this.pnlBaseButtonContainer.Size = new System.Drawing.Size(654, 64);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(251, 12);
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(131, 12);
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlBaseControlContainer
            // 
            this.pnlBaseControlContainer.Controls.Add(this.tbxConfirmPassword);
            this.pnlBaseControlContainer.Controls.Add(this.tbxPassword);
            this.pnlBaseControlContainer.Controls.Add(this.ddlRole);
            this.pnlBaseControlContainer.Controls.Add(this.tbxName);
            this.pnlBaseControlContainer.Controls.Add(this.tbxEmail);
            this.pnlBaseControlContainer.Controls.Add(this.tbxMobileNo);
            this.pnlBaseControlContainer.Controls.Add(this.txtUserName);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonLabel3);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonLabel2);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonLabel15);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonLabel14);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonLabel6);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonLabel4);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonLabel1);
            this.pnlBaseControlContainer.Location = new System.Drawing.Point(63, 14);
            this.pnlBaseControlContainer.Size = new System.Drawing.Size(500, 300);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.brdContainerTop, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerBottom, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerLeft, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerRight, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonLabel4, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonLabel6, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonLabel14, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonLabel15, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonLabel2, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonLabel3, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.txtUserName, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.tbxMobileNo, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.tbxEmail, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.tbxName, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.ddlRole, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.tbxPassword, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.tbxConfirmPassword, 0);
            // 
            // bdrContainerRight
            // 
            this.bdrContainerRight.Location = new System.Drawing.Point(499, 1);
            this.bdrContainerRight.Size = new System.Drawing.Size(1, 298);
            this.bdrContainerRight.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerLeft
            // 
            this.bdrContainerLeft.Size = new System.Drawing.Size(1, 298);
            this.bdrContainerLeft.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerBottom
            // 
            this.bdrContainerBottom.Location = new System.Drawing.Point(0, 299);
            this.bdrContainerBottom.Size = new System.Drawing.Size(500, 1);
            this.bdrContainerBottom.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // brdContainerTop
            // 
            this.brdContainerTop.Size = new System.Drawing.Size(500, 1);
            this.brdContainerTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.Size = new System.Drawing.Size(654, 1);
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(173, 191);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.PasswordChar = '*';
            this.tbxConfirmPassword.Size = new System.Drawing.Size(269, 20);
            this.tbxConfirmPassword.TabIndex = 25;
            this.tbxConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxConfirmPassword_KeyDown);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(173, 165);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(269, 20);
            this.tbxPassword.TabIndex = 24;
            this.tbxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxConfirmPassword_KeyDown);
            // 
            // ddlRole
            // 
            this.ddlRole.DropDownWidth = 121;
            this.ddlRole.Location = new System.Drawing.Point(173, 111);
            this.ddlRole.Name = "ddlRole";
            this.ddlRole.Size = new System.Drawing.Size(269, 21);
            this.ddlRole.TabIndex = 23;
            this.ddlRole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxConfirmPassword_KeyDown);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(173, 35);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(269, 20);
            this.tbxName.TabIndex = 14;
            this.tbxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxConfirmPassword_KeyDown);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(173, 85);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(269, 20);
            this.tbxEmail.TabIndex = 26;
            this.tbxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxEmail_KeyDown);
            // 
            // tbxMobileNo
            // 
            this.tbxMobileNo.Location = new System.Drawing.Point(173, 61);
            this.tbxMobileNo.Name = "tbxMobileNo";
            this.tbxMobileNo.Size = new System.Drawing.Size(269, 20);
            this.tbxMobileNo.TabIndex = 19;
            this.tbxMobileNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxConfirmPassword_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(173, 138);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(269, 20);
            this.txtUserName.TabIndex = 21;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxConfirmPassword_KeyDown);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(58, 111);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabel3.TabIndex = 11;
            this.kryptonLabel3.Values.Text = "Role";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(58, 85);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel2.TabIndex = 9;
            this.kryptonLabel2.Values.Text = "Email";
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(58, 191);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(109, 20);
            this.kryptonLabel15.TabIndex = 10;
            this.kryptonLabel15.Values.Text = "Confirm Password";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(58, 165);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel14.TabIndex = 18;
            this.kryptonLabel14.Values.Text = "Password";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(58, 138);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(71, 20);
            this.kryptonLabel6.TabIndex = 15;
            this.kryptonLabel6.Values.Text = "User Name";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(58, 61);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel4.TabIndex = 16;
            this.kryptonLabel4.Values.Text = "Mobile No";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(58, 35);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "Full Name";
            // 
            // EP
            // 
            this.EP.ContainerControl = this;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 442);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseContainer)).EndInit();
            this.pnlBaseContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseControlContainer)).EndInit();
            this.pnlBaseControlContainer.ResumeLayout(false);
            this.pnlBaseControlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxConfirmPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlRole;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxMobileNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ErrorProvider EP;
    }
}