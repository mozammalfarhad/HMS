namespace HMS.Forms.BaseForms
{
    partial class BaseNavigator
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
            this.bdrButtonTop = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
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
            this.pnlBaseButtonContainer.Controls.Add(this.bdrButtonTop);
            this.pnlBaseButtonContainer.Controls.Add(this.btnClose);
            this.pnlBaseButtonContainer.Controls.Add(this.btnSave);
            this.pnlBaseButtonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBaseButtonContainer.Location = new System.Drawing.Point(0, 508);
            this.pnlBaseButtonContainer.Name = "pnlBaseButtonContainer";
            this.pnlBaseButtonContainer.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.pnlBaseButtonContainer.Size = new System.Drawing.Size(794, 64);
            this.pnlBaseButtonContainer.TabIndex = 3;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.bdrButtonTop.Location = new System.Drawing.Point(0, 0);
            this.bdrButtonTop.Name = "bdrButtonTop";
            this.bdrButtonTop.Size = new System.Drawing.Size(794, 1);
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
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
            // BaseNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.pnlBaseButtonContainer);
            this.Controls.Add(this.hdrBaseCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BaseNavigator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base Navigator";
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonHeader hdrBaseCaption;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel pnlBaseButtonContainer;
        public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge bdrButtonTop;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
    }
}