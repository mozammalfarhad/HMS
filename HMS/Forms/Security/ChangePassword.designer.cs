namespace HMS.Forms.Security
{
    partial class ChangePassword
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
            this.tbxretype = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbxNewPw = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbxOldPw = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblOldPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNewPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblRetypePassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseContainer)).BeginInit();
            this.pnlBaseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseControlContainer)).BeginInit();
            this.pnlBaseControlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Size = new System.Drawing.Size(494, 31);
            this.hdrBaseCaption.Values.Description = "";
            this.hdrBaseCaption.Values.Heading = "* Password must contain at least five characters";
            this.hdrBaseCaption.Values.Image = null;
            // 
            // pnlBaseContainer
            // 
            this.pnlBaseContainer.Size = new System.Drawing.Size(494, 192);
            // 
            // pnlBaseButtonContainer
            // 
            this.pnlBaseButtonContainer.Location = new System.Drawing.Point(0, 223);
            this.pnlBaseButtonContainer.Size = new System.Drawing.Size(494, 64);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(371, 12);
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(251, 12);
            this.btnSave.Values.Text = "Change";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlBaseControlContainer
            // 
            this.pnlBaseControlContainer.Controls.Add(this.lblOldPassword);
            this.pnlBaseControlContainer.Controls.Add(this.lblNewPassword);
            this.pnlBaseControlContainer.Controls.Add(this.lblRetypePassword);
            this.pnlBaseControlContainer.Controls.Add(this.tbxNewPw);
            this.pnlBaseControlContainer.Controls.Add(this.tbxOldPw);
            this.pnlBaseControlContainer.Controls.Add(this.tbxretype);
            this.pnlBaseControlContainer.Location = new System.Drawing.Point(52, 27);
            this.pnlBaseControlContainer.Size = new System.Drawing.Size(391, 139);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.tbxretype, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.tbxOldPw, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.tbxNewPw, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.lblRetypePassword, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.lblNewPassword, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.lblOldPassword, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.brdContainerTop, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerBottom, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerLeft, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerRight, 0);
            // 
            // bdrContainerRight
            // 
            this.bdrContainerRight.Location = new System.Drawing.Point(390, 1);
            this.bdrContainerRight.Size = new System.Drawing.Size(1, 137);
            this.bdrContainerRight.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerLeft
            // 
            this.bdrContainerLeft.Size = new System.Drawing.Size(1, 137);
            this.bdrContainerLeft.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerBottom
            // 
            this.bdrContainerBottom.Location = new System.Drawing.Point(0, 138);
            this.bdrContainerBottom.Size = new System.Drawing.Size(391, 1);
            this.bdrContainerBottom.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // brdContainerTop
            // 
            this.brdContainerTop.Size = new System.Drawing.Size(391, 1);
            this.brdContainerTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.Size = new System.Drawing.Size(494, 1);
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // tbxretype
            // 
            this.tbxretype.Location = new System.Drawing.Point(144, 85);
            this.tbxretype.Name = "tbxretype";
            this.tbxretype.PasswordChar = '●';
            this.tbxretype.Size = new System.Drawing.Size(212, 20);
            this.tbxretype.TabIndex = 8;
            this.tbxretype.UseSystemPasswordChar = true;
            this.tbxretype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxretype_KeyPress);
            // 
            // tbxNewPw
            // 
            this.tbxNewPw.Location = new System.Drawing.Point(144, 59);
            this.tbxNewPw.Name = "tbxNewPw";
            this.tbxNewPw.PasswordChar = '●';
            this.tbxNewPw.Size = new System.Drawing.Size(212, 20);
            this.tbxNewPw.TabIndex = 7;
            this.tbxNewPw.UseSystemPasswordChar = true;
            this.tbxNewPw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxOldPw_KeyPress);
            // 
            // tbxOldPw
            // 
            this.tbxOldPw.Location = new System.Drawing.Point(144, 33);
            this.tbxOldPw.Name = "tbxOldPw";
            this.tbxOldPw.PasswordChar = '●';
            this.tbxOldPw.Size = new System.Drawing.Size(212, 20);
            this.tbxOldPw.TabIndex = 6;
            this.tbxOldPw.UseSystemPasswordChar = true;
            this.tbxOldPw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxOldPw_KeyPress);
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.Location = new System.Drawing.Point(35, 33);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(85, 20);
            this.lblOldPassword.TabIndex = 9;
            this.lblOldPassword.Values.Text = "Old Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Location = new System.Drawing.Point(35, 59);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(90, 20);
            this.lblNewPassword.TabIndex = 9;
            this.lblNewPassword.Values.Text = "New Password";
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.Location = new System.Drawing.Point(35, 85);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(103, 20);
            this.lblRetypePassword.TabIndex = 9;
            this.lblRetypePassword.Values.Text = "Retype Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 287);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseContainer)).EndInit();
            this.pnlBaseContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseControlContainer)).EndInit();
            this.pnlBaseControlContainer.ResumeLayout(false);
            this.pnlBaseControlContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxretype;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxNewPw;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxOldPw;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblOldPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNewPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRetypePassword;
    }
}