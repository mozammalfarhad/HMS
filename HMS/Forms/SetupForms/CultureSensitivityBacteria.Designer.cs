namespace HMS.Forms.SetupForms
{
    partial class CultureSensitivityBacteria
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
            this.dsfdsgds = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbxDescription = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnServiceSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbxBacteriaName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dgvMain = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.BacteriaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BacteriaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Values.Heading = "Bacteria Entry";
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
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonGroupBox1, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.brdContainerTop, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerBottom, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerLeft, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerRight, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.dgvMain, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.lblPageNumber, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.lblPagingSummery, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.ddlPage, 0);
            // 
            // bdrContainerRight
            // 
            this.bdrContainerRight.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerLeft
            // 
            this.bdrContainerLeft.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerBottom
            // 
            this.bdrContainerBottom.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // brdContainerTop
            // 
            this.brdContainerTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(46, 21);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.dsfdsgds);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbxDescription);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnCancel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnDelete);
            this.kryptonGroupBox1.Panel.Controls.Add(this.BtnServiceSave);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbxBacteriaName);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(548, 128);
            this.kryptonGroupBox1.TabIndex = 4;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // dsfdsgds
            // 
            this.dsfdsgds.Location = new System.Drawing.Point(51, 44);
            this.dsfdsgds.Name = "dsfdsgds";
            this.dsfdsgds.Size = new System.Drawing.Size(68, 20);
            this.dsfdsgds.TabIndex = 22;
            this.dsfdsgds.Values.Text = "Desciption";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(184, 44);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(219, 34);
            this.tbxDescription.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(408, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(295, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BtnServiceSave
            // 
            this.BtnServiceSave.Location = new System.Drawing.Point(184, 89);
            this.BtnServiceSave.Name = "BtnServiceSave";
            this.BtnServiceSave.Size = new System.Drawing.Size(90, 25);
            this.BtnServiceSave.TabIndex = 18;
            this.BtnServiceSave.Values.Text = "Save";
            this.BtnServiceSave.Click += new System.EventHandler(this.BtnServiceSave_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(51, 14);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel1.TabIndex = 16;
            this.kryptonLabel1.Values.Text = "Bacteria Name";
            // 
            // tbxBacteriaName
            // 
            this.tbxBacteriaName.Location = new System.Drawing.Point(184, 14);
            this.tbxBacteriaName.Name = "tbxBacteriaName";
            this.tbxBacteriaName.Size = new System.Drawing.Size(219, 20);
            this.tbxBacteriaName.TabIndex = 14;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BacteriaId,
            this.BacteriaName,
            this.Description});
            this.dgvMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMain.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvMain.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvMain.Location = new System.Drawing.Point(46, 158);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(548, 219);
            this.dgvMain.TabIndex = 33;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            // 
            // BacteriaId
            // 
            this.BacteriaId.DataPropertyName = "BacteriaId";
            this.BacteriaId.HeaderText = "BacteriaId";
            this.BacteriaId.Name = "BacteriaId";
            this.BacteriaId.ReadOnly = true;
            this.BacteriaId.Visible = false;
            // 
            // BacteriaName
            // 
            this.BacteriaName.DataPropertyName = "BacteriaName";
            this.BacteriaName.HeaderText = "Bacteria Name";
            this.BacteriaName.Name = "BacteriaName";
            this.BacteriaName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // ddlPage
            // 
            this.ddlPage.DropDownWidth = 82;
            this.ddlPage.Location = new System.Drawing.Point(252, 383);
            this.ddlPage.Name = "ddlPage";
            this.ddlPage.Size = new System.Drawing.Size(82, 21);
            this.ddlPage.TabIndex = 36;
            // 
            // lblPagingSummery
            // 
            this.lblPagingSummery.Location = new System.Drawing.Point(340, 383);
            this.lblPagingSummery.Name = "lblPagingSummery";
            this.lblPagingSummery.Size = new System.Drawing.Size(92, 20);
            this.lblPagingSummery.TabIndex = 35;
            this.lblPagingSummery.Values.Text = "Page Summary";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Location = new System.Drawing.Point(156, 383);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(86, 20);
            this.lblPageNumber.TabIndex = 34;
            this.lblPageNumber.Values.Text = "Page Number";
            // 
            // CultureSensitivityBacteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CultureSensitivityBacteria";
            this.Text = "Culture Sensitivity Bacteria";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnServiceSave;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxBacteriaName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvMain;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlPage;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblPagingSummery;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblPageNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel dsfdsgds;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn BacteriaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BacteriaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}