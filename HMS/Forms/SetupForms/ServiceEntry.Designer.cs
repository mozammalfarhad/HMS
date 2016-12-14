namespace HMS.Forms.SetupForms
{
    partial class ServiceEntry
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
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ddlServiceType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbxService = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ckHasAttribute = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbxShortName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ddlUnit = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tbxNormalRangeM = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbxRate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblrate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbxDiscount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblDiscount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblpercent = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbxNormalRangeF = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnServiceSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvMain = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaleNormalRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FemaleNormalRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlPage = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblPagingSummery = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPageNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseContainer)).BeginInit();
            this.pnlBaseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseControlContainer)).BeginInit();
            this.pnlBaseControlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUnit)).BeginInit();
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
            this.hdrBaseCaption.Size = new System.Drawing.Size(847, 26);
            this.hdrBaseCaption.Values.Heading = "Add Service";
            this.hdrBaseCaption.Values.Image = null;
            // 
            // pnlBaseContainer
            // 
            this.pnlBaseContainer.Size = new System.Drawing.Size(847, 564);
            // 
            // pnlBaseButtonContainer
            // 
            this.pnlBaseButtonContainer.Location = new System.Drawing.Point(0, 590);
            this.pnlBaseButtonContainer.Size = new System.Drawing.Size(847, 64);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(723, 12);
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(574, 12);
            this.btnSave.Values.Text = "Save";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlBaseControlContainer
            // 
            this.pnlBaseControlContainer.Controls.Add(this.ddlPage);
            this.pnlBaseControlContainer.Controls.Add(this.dgvMain);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonGroupBox1);
            this.pnlBaseControlContainer.Controls.Add(this.lblPagingSummery);
            this.pnlBaseControlContainer.Controls.Add(this.lblPageNumber);
            this.pnlBaseControlContainer.Location = new System.Drawing.Point(75, 19);
            this.pnlBaseControlContainer.Size = new System.Drawing.Size(715, 528);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.brdContainerTop, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerBottom, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerLeft, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.lblPageNumber, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerRight, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.lblPagingSummery, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonGroupBox1, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.dgvMain, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.ddlPage, 0);
            // 
            // bdrContainerRight
            // 
            this.bdrContainerRight.Location = new System.Drawing.Point(714, 1);
            this.bdrContainerRight.Size = new System.Drawing.Size(1, 526);
            this.bdrContainerRight.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerLeft
            // 
            this.bdrContainerLeft.Size = new System.Drawing.Size(1, 526);
            this.bdrContainerLeft.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerBottom
            // 
            this.bdrContainerBottom.Location = new System.Drawing.Point(0, 527);
            this.bdrContainerBottom.Size = new System.Drawing.Size(715, 1);
            this.bdrContainerBottom.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // brdContainerTop
            // 
            this.brdContainerTop.Size = new System.Drawing.Size(715, 1);
            this.brdContainerTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.Size = new System.Drawing.Size(847, 1);
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(88, 16);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel2.TabIndex = 7;
            this.kryptonLabel2.Values.Text = "Test Type";
            // 
            // ddlServiceType
            // 
            this.ddlServiceType.DropDownWidth = 357;
            this.ddlServiceType.Location = new System.Drawing.Point(222, 14);
            this.ddlServiceType.Name = "ddlServiceType";
            this.ddlServiceType.Size = new System.Drawing.Size(357, 21);
            this.ddlServiceType.TabIndex = 6;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(88, 47);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel3.TabIndex = 8;
            this.kryptonLabel3.Values.Text = "Test Name";
            // 
            // tbxService
            // 
            this.tbxService.Location = new System.Drawing.Point(222, 45);
            this.tbxService.Name = "tbxService";
            this.tbxService.Size = new System.Drawing.Size(357, 20);
            this.tbxService.TabIndex = 9;
            // 
            // ckHasAttribute
            // 
            this.ckHasAttribute.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.ckHasAttribute.Location = new System.Drawing.Point(468, 140);
            this.ckHasAttribute.Name = "ckHasAttribute";
            this.ckHasAttribute.Size = new System.Drawing.Size(103, 20);
            this.ckHasAttribute.TabIndex = 3;
            this.ckHasAttribute.Text = "Has attribute ?";
            this.ckHasAttribute.Values.Text = "Has attribute ?";
            this.ckHasAttribute.CheckedChanged += new System.EventHandler(this.ckHasAttribute_CheckedChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(88, 140);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(131, 20);
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Text = "Female Normal Range";
            // 
            // tbxShortName
            // 
            this.tbxShortName.Location = new System.Drawing.Point(222, 77);
            this.tbxShortName.Name = "tbxShortName";
            this.tbxShortName.Size = new System.Drawing.Size(357, 20);
            this.tbxShortName.TabIndex = 13;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(88, 79);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(76, 20);
            this.kryptonLabel4.TabIndex = 12;
            this.kryptonLabel4.Values.Text = "Short Name";
            // 
            // ddlUnit
            // 
            this.ddlUnit.DropDownWidth = 121;
            this.ddlUnit.Location = new System.Drawing.Point(461, 110);
            this.ddlUnit.Name = "ddlUnit";
            this.ddlUnit.Size = new System.Drawing.Size(121, 21);
            this.ddlUnit.TabIndex = 17;
            // 
            // tbxNormalRangeM
            // 
            this.tbxNormalRangeM.Location = new System.Drawing.Point(222, 109);
            this.tbxNormalRangeM.Name = "tbxNormalRangeM";
            this.tbxNormalRangeM.Size = new System.Drawing.Size(233, 20);
            this.tbxNormalRangeM.TabIndex = 16;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(88, 111);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(119, 20);
            this.kryptonLabel5.TabIndex = 15;
            this.kryptonLabel5.Values.Text = "Male Normal Range";
            // 
            // tbxRate
            // 
            this.tbxRate.Location = new System.Drawing.Point(222, 173);
            this.tbxRate.Name = "tbxRate";
            this.tbxRate.Size = new System.Drawing.Size(357, 20);
            this.tbxRate.TabIndex = 19;
            // 
            // lblrate
            // 
            this.lblrate.Location = new System.Drawing.Point(88, 175);
            this.lblrate.Name = "lblrate";
            this.lblrate.Size = new System.Drawing.Size(35, 20);
            this.lblrate.TabIndex = 18;
            this.lblrate.Values.Text = "Rate";
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(222, 206);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(349, 20);
            this.tbxDiscount.TabIndex = 21;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Location = new System.Drawing.Point(88, 208);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(59, 20);
            this.lblDiscount.TabIndex = 20;
            this.lblDiscount.Values.Text = "Discount";
            // 
            // lblpercent
            // 
            this.lblpercent.Location = new System.Drawing.Point(569, 205);
            this.lblpercent.Name = "lblpercent";
            this.lblpercent.Size = new System.Drawing.Size(21, 20);
            this.lblpercent.TabIndex = 22;
            this.lblpercent.Values.Text = "%";
            // 
            // tbxNormalRangeF
            // 
            this.tbxNormalRangeF.Location = new System.Drawing.Point(222, 142);
            this.tbxNormalRangeF.Name = "tbxNormalRangeF";
            this.tbxNormalRangeF.Size = new System.Drawing.Size(240, 19);
            this.tbxNormalRangeF.TabIndex = 24;
            this.tbxNormalRangeF.Text = "";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(18, 11);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnCancel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnDelete);
            this.kryptonGroupBox1.Panel.Controls.Add(this.BtnServiceSave);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbxNormalRangeF);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ddlServiceType);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblpercent);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbxDiscount);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbxService);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblDiscount);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ckHasAttribute);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbxRate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblrate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ddlUnit);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbxShortName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbxNormalRangeM);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(677, 273);
            this.kryptonGroupBox1.TabIndex = 25;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(559, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(446, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BtnServiceSave
            // 
            this.BtnServiceSave.Location = new System.Drawing.Point(335, 232);
            this.BtnServiceSave.Name = "BtnServiceSave";
            this.BtnServiceSave.Size = new System.Drawing.Size(90, 25);
            this.BtnServiceSave.TabIndex = 25;
            this.BtnServiceSave.Values.Text = "Save";
            this.BtnServiceSave.Click += new System.EventHandler(this.BtnServiceSave_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceId,
            this.ServiceName,
            this.ServiceShortName,
            this.MaleNormalRange,
            this.FemaleNormalRange,
            this.Rate,
            this.Discount,
            this.UnitName,
            this.TypeName});
            this.dgvMain.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvMain.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvMain.Location = new System.Drawing.Point(18, 290);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(676, 210);
            this.dgvMain.TabIndex = 33;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            // 
            // ServiceId
            // 
            this.ServiceId.DataPropertyName = "ServiceId";
            this.ServiceId.HeaderText = "ServiceId";
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.ReadOnly = true;
            this.ServiceId.Visible = false;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "Service Name";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // ServiceShortName
            // 
            this.ServiceShortName.DataPropertyName = "ServiceShortName";
            this.ServiceShortName.HeaderText = "Short Name";
            this.ServiceShortName.Name = "ServiceShortName";
            this.ServiceShortName.ReadOnly = true;
            // 
            // MaleNormalRange
            // 
            this.MaleNormalRange.DataPropertyName = "MaleNormalRange";
            this.MaleNormalRange.HeaderText = "Male Normal Range";
            this.MaleNormalRange.Name = "MaleNormalRange";
            this.MaleNormalRange.ReadOnly = true;
            // 
            // FemaleNormalRange
            // 
            this.FemaleNormalRange.DataPropertyName = "FemaleNormalRange";
            this.FemaleNormalRange.HeaderText = "Female Normal Range";
            this.FemaleNormalRange.Name = "FemaleNormalRange";
            this.FemaleNormalRange.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Unit";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "Test Type";
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            // 
            // ddlPage
            // 
            this.ddlPage.DropDownWidth = 82;
            this.ddlPage.Location = new System.Drawing.Point(264, 505);
            this.ddlPage.Name = "ddlPage";
            this.ddlPage.Size = new System.Drawing.Size(82, 21);
            this.ddlPage.TabIndex = 36;
            // 
            // lblPagingSummery
            // 
            this.lblPagingSummery.Location = new System.Drawing.Point(352, 505);
            this.lblPagingSummery.Name = "lblPagingSummery";
            this.lblPagingSummery.Size = new System.Drawing.Size(92, 20);
            this.lblPagingSummery.TabIndex = 35;
            this.lblPagingSummery.Values.Text = "Page Summary";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Location = new System.Drawing.Point(168, 505);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(86, 20);
            this.lblPageNumber.TabIndex = 34;
            this.lblPageNumber.Values.Text = "Page Number";
            // 
            // ServiceEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 654);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ServiceEntry";
            this.Text = "ServiceEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseContainer)).EndInit();
            this.pnlBaseContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseControlContainer)).EndInit();
            this.pnlBaseControlContainer.ResumeLayout(false);
            this.pnlBaseControlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUnit)).EndInit();
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

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlServiceType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxService;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox ckHasAttribute;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxShortName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlUnit;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxNormalRangeM;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxDiscount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDiscount;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxRate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblrate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblpercent;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox tbxNormalRangeF;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnServiceSave;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvMain;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlPage;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblPagingSummery;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblPageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaleNormalRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn FemaleNormalRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
    }
}