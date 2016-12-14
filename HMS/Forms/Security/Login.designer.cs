namespace HMS.Forms.Security
    {
        partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ChkRemember = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.lblRemainder = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bdrContainerBottom = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.bdrContainerRight = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.bdrContainerLeft = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.brdContainerTop = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.tbxPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbxUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.vitlThemeManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.vitlCustomTheme = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.pnlButton = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bdrButtonTop = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.pnlContainer = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).BeginInit();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChkRemember
            // 
            this.ChkRemember.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.ChkRemember.Location = new System.Drawing.Point(96, 84);
            this.ChkRemember.Name = "ChkRemember";
            this.ChkRemember.Size = new System.Drawing.Size(106, 20);
            this.ChkRemember.TabIndex = 12;
            this.ChkRemember.Text = "Remember me.";
            this.ChkRemember.Values.Text = "Remember me.";
            // 
            // lblRemainder
            // 
            this.lblRemainder.Location = new System.Drawing.Point(27, 6);
            this.lblRemainder.Name = "lblRemainder";
            this.lblRemainder.Size = new System.Drawing.Size(216, 20);
            this.lblRemainder.TabIndex = 11;
            this.lblRemainder.Values.Text = "Please type in your ID and Password...";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.bdrContainerBottom);
            this.kryptonPanel2.Controls.Add(this.bdrContainerRight);
            this.kryptonPanel2.Controls.Add(this.bdrContainerLeft);
            this.kryptonPanel2.Controls.Add(this.brdContainerTop);
            this.kryptonPanel2.Controls.Add(this.ChkRemember);
            this.kryptonPanel2.Controls.Add(this.lblRemainder);
            this.kryptonPanel2.Controls.Add(this.tbxPassword);
            this.kryptonPanel2.Controls.Add(this.tbxUserName);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Location = new System.Drawing.Point(27, 24);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel2.Size = new System.Drawing.Size(291, 110);
            this.kryptonPanel2.TabIndex = 10;
            // 
            // bdrContainerBottom
            // 
            this.bdrContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdrContainerBottom.Location = new System.Drawing.Point(1, 109);
            this.bdrContainerBottom.Name = "bdrContainerBottom";
            this.bdrContainerBottom.Size = new System.Drawing.Size(289, 1);
            this.bdrContainerBottom.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerRight
            // 
            this.bdrContainerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.bdrContainerRight.Location = new System.Drawing.Point(290, 1);
            this.bdrContainerRight.Name = "bdrContainerRight";
            this.bdrContainerRight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bdrContainerRight.Size = new System.Drawing.Size(1, 109);
            this.bdrContainerRight.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerLeft
            // 
            this.bdrContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.bdrContainerLeft.Location = new System.Drawing.Point(0, 1);
            this.bdrContainerLeft.Name = "bdrContainerLeft";
            this.bdrContainerLeft.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bdrContainerLeft.Size = new System.Drawing.Size(1, 109);
            this.bdrContainerLeft.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // brdContainerTop
            // 
            this.brdContainerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.brdContainerTop.Location = new System.Drawing.Point(0, 0);
            this.brdContainerTop.Name = "brdContainerTop";
            this.brdContainerTop.Size = new System.Drawing.Size(291, 1);
            this.brdContainerTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(96, 58);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '●';
            this.tbxPassword.Size = new System.Drawing.Size(167, 20);
            this.tbxPassword.TabIndex = 7;
            this.tbxPassword.UseSystemPasswordChar = true;
            this.tbxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPassword_KeyDown);
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(96, 32);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(167, 20);
            this.tbxUserName.TabIndex = 6;
            this.tbxUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUserName_KeyPress);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(28, 58);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Password";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(28, 32);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel1.TabIndex = 8;
            this.kryptonLabel1.Values.Text = "User ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(221, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnLogin.Location = new System.Drawing.Point(104, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Values.Text = "Log In";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // vitlThemeManager
            // 
            this.vitlThemeManager.GlobalPalette = this.vitlCustomTheme;
            this.vitlThemeManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // vitlCustomTheme
            // 
            this.vitlCustomTheme.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.vitlCustomTheme.LabelStyles.LabelBoldControl.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.vitlCustomTheme.LabelStyles.LabelNormalControl.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.vitlCustomTheme.LabelStyles.LabelNormalPanel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.bdrButtonTop);
            this.pnlButton.Controls.Add(this.btnLogin);
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 158);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm;
            this.pnlButton.Size = new System.Drawing.Size(344, 64);
            this.pnlButton.TabIndex = 12;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.bdrButtonTop.Location = new System.Drawing.Point(0, 0);
            this.bdrButtonTop.Name = "bdrButtonTop";
            this.bdrButtonTop.Size = new System.Drawing.Size(344, 1);
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.kryptonPanel2);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.pnlContainer.Size = new System.Drawing.Size(344, 158);
            this.pnlContainer.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(344, 222);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

            }

            #endregion

            private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
            private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
            private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxPassword;
            private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxUserName;
            private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
            private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
            private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
            private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRemainder;
            private ComponentFactory.Krypton.Toolkit.KryptonCheckBox ChkRemember;
            private ComponentFactory.Krypton.Toolkit.KryptonPalette vitlCustomTheme;
            public ComponentFactory.Krypton.Toolkit.KryptonManager vitlThemeManager;
            private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlButton;
            public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge bdrButtonTop;
            public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge brdContainerTop;
            public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge bdrContainerLeft;
            public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge bdrContainerRight;
            public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge bdrContainerBottom;
            private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlContainer;

        }
    }
