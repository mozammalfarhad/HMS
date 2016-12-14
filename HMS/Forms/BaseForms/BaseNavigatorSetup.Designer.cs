namespace HMS.Forms.BaseForms
{
    partial class BaseNavigatorSetup
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
            this.hdrBaseCaption = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.pnlBaseButtonContainer = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.navBaseContainer = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBaseContainer)).BeginInit();
            this.navBaseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdrBaseCaption.Location = new System.Drawing.Point(0, 0);
            this.hdrBaseCaption.Name = "hdrBaseCaption";
            this.hdrBaseCaption.Size = new System.Drawing.Size(794, 31);
            this.hdrBaseCaption.TabIndex = 1;
            this.hdrBaseCaption.Values.Heading = "Caption";
            this.hdrBaseCaption.Values.Image = null;
            // 
            // pnlBaseButtonContainer
            // 
            this.pnlBaseButtonContainer.Controls.Add(this.btnClose);
            this.pnlBaseButtonContainer.Controls.Add(this.btnSave);
            this.pnlBaseButtonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBaseButtonContainer.Location = new System.Drawing.Point(0, 508);
            this.pnlBaseButtonContainer.Name = "pnlBaseButtonContainer";
            this.pnlBaseButtonContainer.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.pnlBaseButtonContainer.Size = new System.Drawing.Size(794, 64);
            this.pnlBaseButtonContainer.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Location = new System.Drawing.Point(671, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 40);
            this.btnClose.TabIndex = 22;
            this.btnClose.Values.Text = "Close";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(551, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 40);
            this.btnSave.TabIndex = 21;
            this.btnSave.Values.Text = "Save";
            // 
            // navBaseContainer
            // 
            this.navBaseContainer.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.navBaseContainer.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.navBaseContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBaseContainer.Location = new System.Drawing.Point(0, 31);
            this.navBaseContainer.Name = "navBaseContainer";
            this.navBaseContainer.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.navBaseContainer.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.navBaseContainer.SelectedIndex = 0;
            this.navBaseContainer.Size = new System.Drawing.Size(794, 477);
            this.navBaseContainer.TabIndex = 4;
            this.navBaseContainer.Text = "Base Navigator";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(792, 450);
            this.kryptonPage1.Text = "kryptonPage1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "EDE73BD6140C4C8CB5B1C1681B2AD51C";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(792, 450);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "C54B003E12B74A9C1A825D7F3964164F";
            // 
            // BaseNavigatorSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.navBaseContainer);
            this.Controls.Add(this.pnlBaseButtonContainer);
            this.Controls.Add(this.hdrBaseCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BaseNavigatorSetup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base Navigator Setup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBaseContainer)).EndInit();
            this.navBaseContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonHeader hdrBaseCaption;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel pnlBaseButtonContainer;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        public ComponentFactory.Krypton.Navigator.KryptonNavigator navBaseContainer;
    }
}