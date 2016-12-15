namespace HMS.Forms.SetupForms
{
    partial class ReferFeeEntry
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
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.NumReferParcent = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnServiceSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.comService = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvMain = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ReferFeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlPage = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblPagingSummery = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPageNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseContainer)).BeginInit();
            this.pnlBaseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseControlContainer)).BeginInit();
            this.pnlBaseControlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Values.Heading = "Add Refer Fee";
            this.hdrBaseCaption.Values.Image = null;
            // 
            // btnClose
            // 
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Values.Text = "Save";
            this.btnSave.Visible = false;
            // 
            // pnlBaseControlContainer
            // 
            this.pnlBaseControlContainer.Controls.Add(this.ddlPage);
            this.pnlBaseControlContainer.Controls.Add(this.lblPagingSummery);
            this.pnlBaseControlContainer.Controls.Add(this.lblPageNumber);
            this.pnlBaseControlContainer.Controls.Add(this.dgvMain);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonGroupBox1);
            this.pnlBaseControlContainer.Location = new System.Drawing.Point(109, 28);
            this.pnlBaseControlContainer.Size = new System.Drawing.Size(584, 430);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonGroupBox1, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.dgvMain, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.brdContainerTop, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerBottom, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerLeft, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerRight, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.lblPageNumber, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.lblPagingSummery, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.ddlPage, 0);
            // 
            // bdrContainerRight
            // 
            this.bdrContainerRight.Location = new System.Drawing.Point(583, 1);
            this.bdrContainerRight.Size = new System.Drawing.Size(1, 428);
            this.bdrContainerRight.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerLeft
            // 
            this.bdrContainerLeft.Size = new System.Drawing.Size(1, 428);
            this.bdrContainerLeft.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerBottom
            // 
            this.bdrContainerBottom.Location = new System.Drawing.Point(0, 429);
            this.bdrContainerBottom.Size = new System.Drawing.Size(584, 1);
            this.bdrContainerBottom.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // brdContainerTop
            // 
            this.brdContainerTop.Size = new System.Drawing.Size(584, 1);
            this.brdContainerTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            this.bdrButtonTop.Visible = false;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(26, 11);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnCancel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.NumReferParcent);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnDelete);
            this.kryptonGroupBox1.Panel.Controls.Add(this.BtnServiceSave);
            this.kryptonGroupBox1.Panel.Controls.Add(this.comService);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(531, 145);
            this.kryptonGroupBox1.TabIndex = 4;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(424, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(424, 58);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(21, 20);
            this.kryptonLabel5.TabIndex = 9;
            this.kryptonLabel5.Values.Text = "%";
            // 
            // NumReferParcent
            // 
            this.NumReferParcent.Location = new System.Drawing.Point(199, 58);
            this.NumReferParcent.Name = "NumReferParcent";
            this.NumReferParcent.Size = new System.Drawing.Size(228, 20);
            this.NumReferParcent.TabIndex = 8;
            this.NumReferParcent.TextChanged += new System.EventHandler(this.NumReferParcent_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(311, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BtnServiceSave
            // 
            this.BtnServiceSave.Location = new System.Drawing.Point(200, 95);
            this.BtnServiceSave.Name = "BtnServiceSave";
            this.BtnServiceSave.Size = new System.Drawing.Size(90, 25);
            this.BtnServiceSave.TabIndex = 6;
            this.BtnServiceSave.Values.Text = "Save";
            this.BtnServiceSave.Click += new System.EventHandler(this.BtnServiceSave_Click);
            // 
            // comService
            // 
            this.comService.DropDownWidth = 229;
            this.comService.Location = new System.Drawing.Point(199, 21);
            this.comService.Name = "comService";
            this.comService.Size = new System.Drawing.Size(229, 21);
            this.comService.TabIndex = 4;
            this.comService.SelectedIndexChanged += new System.EventHandler(this.comService_SelectedIndexChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(166, 56);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(13, 20);
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = ":";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(166, 19);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(13, 20);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = ":";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(75, 56);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(61, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Refer Fee";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(75, 19);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(85, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Service Name";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReferFeeId,
            this.ServiceName,
            this.FeePercent});
            this.dgvMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMain.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvMain.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvMain.Location = new System.Drawing.Point(30, 167);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(527, 228);
            this.dgvMain.TabIndex = 5;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            // 
            // ReferFeeId
            // 
            this.ReferFeeId.DataPropertyName = "ReferFeeId";
            this.ReferFeeId.HeaderText = "ReferFeeId";
            this.ReferFeeId.Name = "ReferFeeId";
            this.ReferFeeId.ReadOnly = true;
            this.ReferFeeId.Visible = false;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "Sevice Name";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // FeePercent
            // 
            this.FeePercent.DataPropertyName = "FeePercent";
            this.FeePercent.HeaderText = "Fee Percent";
            this.FeePercent.Name = "FeePercent";
            this.FeePercent.ReadOnly = true;
            // 
            // ddlPage
            // 
            this.ddlPage.DropDownWidth = 82;
            this.ddlPage.Location = new System.Drawing.Point(256, 401);
            this.ddlPage.Name = "ddlPage";
            this.ddlPage.Size = new System.Drawing.Size(82, 21);
            this.ddlPage.TabIndex = 28;
            // 
            // lblPagingSummery
            // 
            this.lblPagingSummery.Location = new System.Drawing.Point(344, 401);
            this.lblPagingSummery.Name = "lblPagingSummery";
            this.lblPagingSummery.Size = new System.Drawing.Size(92, 20);
            this.lblPagingSummery.TabIndex = 27;
            this.lblPagingSummery.Values.Text = "Page Summary";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Location = new System.Drawing.Point(160, 401);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(86, 20);
            this.lblPageNumber.TabIndex = 26;
            this.lblPageNumber.Values.Text = "Page Number";
            // 
            // ReferFeeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ReferFeeEntry";
            this.Text = "Refer Fee Entry";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseContainer)).EndInit();
            this.pnlBaseContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseControlContainer)).EndInit();
            this.pnlBaseControlContainer.ResumeLayout(false);
            this.pnlBaseControlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comService;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnServiceSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvMain;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox NumReferParcent;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlPage;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblPagingSummery;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblPageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferFeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeePercent;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
    }
}