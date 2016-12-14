namespace HMS.Forms.Security
{
    partial class UserEditForm
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
            this.ddlRole = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tbxName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbxEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbxMobileNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            this.hdrBaseCaption.Size = new System.Drawing.Size(705, 26);
            this.hdrBaseCaption.Values.Description = "";
            this.hdrBaseCaption.Values.Heading = "Edit User";
            this.hdrBaseCaption.Values.Image = null;
            // 
            // pnlBaseContainer
            // 
            this.pnlBaseContainer.Size = new System.Drawing.Size(705, 289);
            // 
            // pnlBaseButtonContainer
            // 
            this.pnlBaseButtonContainer.Location = new System.Drawing.Point(0, 315);
            this.pnlBaseButtonContainer.Size = new System.Drawing.Size(705, 64);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(315, 12);
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 12);
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlBaseControlContainer
            // 
            this.pnlBaseControlContainer.Controls.Add(this.tbxMobileNo);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonLabel5);
            this.pnlBaseControlContainer.Controls.Add(this.ddlRole);
            this.pnlBaseControlContainer.Controls.Add(this.tbxName);
            this.pnlBaseControlContainer.Controls.Add(this.tbxEmail);
            this.pnlBaseControlContainer.Controls.Add(this.txtUserName);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonLabel3);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonLabel2);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonLabel6);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonLabel1);
            this.pnlBaseControlContainer.Location = new System.Drawing.Point(63, 18);
            this.pnlBaseControlContainer.Size = new System.Drawing.Size(540, 240);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.brdContainerTop, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerBottom, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerLeft, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerRight, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonLabel6, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonLabel2, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonLabel3, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.txtUserName, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.tbxEmail, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.tbxName, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.ddlRole, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonLabel5, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.tbxMobileNo, 0);
            // 
            // bdrContainerRight
            // 
            this.bdrContainerRight.Location = new System.Drawing.Point(539, 1);
            this.bdrContainerRight.Size = new System.Drawing.Size(1, 238);
            this.bdrContainerRight.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerLeft
            // 
            this.bdrContainerLeft.Size = new System.Drawing.Size(1, 238);
            this.bdrContainerLeft.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerBottom
            // 
            this.bdrContainerBottom.Location = new System.Drawing.Point(0, 239);
            this.bdrContainerBottom.Size = new System.Drawing.Size(540, 1);
            this.bdrContainerBottom.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // brdContainerTop
            // 
            this.brdContainerTop.Size = new System.Drawing.Size(540, 1);
            this.brdContainerTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.Size = new System.Drawing.Size(705, 1);
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // ddlRole
            // 
            this.ddlRole.DropDownWidth = 121;
            this.ddlRole.Location = new System.Drawing.Point(181, 133);
            this.ddlRole.Name = "ddlRole";
            this.ddlRole.Size = new System.Drawing.Size(269, 21);
            this.ddlRole.TabIndex = 19;
            this.ddlRole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlClub_KeyDown);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(181, 54);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(269, 20);
            this.tbxName.TabIndex = 13;
            this.tbxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlClub_KeyDown);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(181, 159);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(269, 20);
            this.tbxEmail.TabIndex = 20;
            this.tbxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxEmail_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(181, 106);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(269, 20);
            this.txtUserName.TabIndex = 17;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlClub_KeyDown);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(90, 133);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabel3.TabIndex = 7;
            this.kryptonLabel3.Values.Text = "Role";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(90, 159);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Email";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(90, 106);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(71, 20);
            this.kryptonLabel6.TabIndex = 11;
            this.kryptonLabel6.Values.Text = "User Name";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(90, 54);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel1.TabIndex = 12;
            this.kryptonLabel1.Values.Text = "Full Name";
            // 
            // EP
            // 
            this.EP.ContainerControl = this;
            // 
            // tbxMobileNo
            // 
            this.tbxMobileNo.Location = new System.Drawing.Point(181, 80);
            this.tbxMobileNo.Name = "tbxMobileNo";
            this.tbxMobileNo.Size = new System.Drawing.Size(269, 20);
            this.tbxMobileNo.TabIndex = 22;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(86, 80);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel5.TabIndex = 21;
            this.kryptonLabel5.Values.Text = "Mobile No";
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 379);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UserEditForm";
            this.Text = "UserEditForm";
            this.Load += new System.EventHandler(this.UserEditForm_Load);
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

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlRole;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ErrorProvider EP;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxMobileNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
    }
}