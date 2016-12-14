namespace HMS.Forms.BaseForms
{
    partial class BaseGeneralSetup
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
            this.pnlBaseContainer = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlBaseControlContainer = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bdrContainerRight = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.bdrContainerLeft = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.bdrContainerBottom = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.brdContainerTop = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.pnlBaseButtonContainer = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bdrButtonTop = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseContainer)).BeginInit();
            this.pnlBaseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseControlContainer)).BeginInit();
            this.pnlBaseControlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdrBaseCaption.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.hdrBaseCaption.Location = new System.Drawing.Point(0, 0);
            this.hdrBaseCaption.Name = "hdrBaseCaption";
            this.hdrBaseCaption.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.hdrBaseCaption.Size = new System.Drawing.Size(794, 26);
            this.hdrBaseCaption.TabIndex = 0;
            this.hdrBaseCaption.Values.Heading = "Caption";
            this.hdrBaseCaption.Values.Image = null;
            // 
            // pnlBaseContainer
            // 
            this.pnlBaseContainer.Controls.Add(this.pnlBaseControlContainer);
            this.pnlBaseContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaseContainer.Location = new System.Drawing.Point(0, 26);
            this.pnlBaseContainer.Name = "pnlBaseContainer";
            this.pnlBaseContainer.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive;
            this.pnlBaseContainer.Size = new System.Drawing.Size(794, 482);
            this.pnlBaseContainer.TabIndex = 1;
            // 
            // pnlBaseControlContainer
            // 
            this.pnlBaseControlContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBaseControlContainer.Controls.Add(this.bdrContainerRight);
            this.pnlBaseControlContainer.Controls.Add(this.bdrContainerLeft);
            this.pnlBaseControlContainer.Controls.Add(this.bdrContainerBottom);
            this.pnlBaseControlContainer.Controls.Add(this.brdContainerTop);
            this.pnlBaseControlContainer.Location = new System.Drawing.Point(73, 36);
            this.pnlBaseControlContainer.Name = "pnlBaseControlContainer";
            this.pnlBaseControlContainer.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.pnlBaseControlContainer.Size = new System.Drawing.Size(649, 411);
            this.pnlBaseControlContainer.TabIndex = 0;
            // 
            // bdrContainerRight
            // 
            this.bdrContainerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.bdrContainerRight.Location = new System.Drawing.Point(648, 1);
            this.bdrContainerRight.Name = "bdrContainerRight";
            this.bdrContainerRight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bdrContainerRight.Size = new System.Drawing.Size(1, 409);
            this.bdrContainerRight.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerLeft
            // 
            this.bdrContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.bdrContainerLeft.Location = new System.Drawing.Point(0, 1);
            this.bdrContainerLeft.Name = "bdrContainerLeft";
            this.bdrContainerLeft.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bdrContainerLeft.Size = new System.Drawing.Size(1, 409);
            this.bdrContainerLeft.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerBottom
            // 
            this.bdrContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdrContainerBottom.Location = new System.Drawing.Point(0, 410);
            this.bdrContainerBottom.Name = "bdrContainerBottom";
            this.bdrContainerBottom.Size = new System.Drawing.Size(649, 1);
            this.bdrContainerBottom.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // brdContainerTop
            // 
            this.brdContainerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.brdContainerTop.Location = new System.Drawing.Point(0, 0);
            this.brdContainerTop.Name = "brdContainerTop";
            this.brdContainerTop.Size = new System.Drawing.Size(649, 1);
            this.brdContainerTop.StateCommon.Color1 = System.Drawing.Color.White;
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
            this.pnlBaseButtonContainer.TabIndex = 2;
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
            // BaseGeneralSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.pnlBaseContainer);
            this.Controls.Add(this.pnlBaseButtonContainer);
            this.Controls.Add(this.hdrBaseCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BaseGeneralSetup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base General Setup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseContainer)).EndInit();
            this.pnlBaseContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseControlContainer)).EndInit();
            this.pnlBaseControlContainer.ResumeLayout(false);
            this.pnlBaseControlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonHeader hdrBaseCaption;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel pnlBaseContainer;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel pnlBaseButtonContainer;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel pnlBaseControlContainer;
        public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge bdrContainerRight;
        public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge bdrContainerLeft;
        public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge bdrContainerBottom;
        public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge brdContainerTop;
        public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge bdrButtonTop;

    }
}