namespace HMS.Forms.SetupForms
{
    partial class ServiceAttributeEntry
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
            this.lblService = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ddlService = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tbxAttribute = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbxMaleNormalRange = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbxFemaleNormalRange = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbxComments = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.ddlTestType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.ddlUnit = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnServiceSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvMain = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.SerAtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttributeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaleNormalRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FemaleNormalRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlPage = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblPagingSummery = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPageNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseContainer)).BeginInit();
            this.pnlBaseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseControlContainer)).BeginInit();
            this.pnlBaseControlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTestType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Size = new System.Drawing.Size(791, 26);
            this.hdrBaseCaption.Values.Heading = "Add Service Attribute";
            this.hdrBaseCaption.Values.Image = null;
            // 
            // pnlBaseContainer
            // 
            this.pnlBaseContainer.Size = new System.Drawing.Size(791, 566);
            // 
            // pnlBaseButtonContainer
            // 
            this.pnlBaseButtonContainer.Location = new System.Drawing.Point(0, 592);
            this.pnlBaseButtonContainer.Size = new System.Drawing.Size(791, 64);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(653, 12);
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(533, 12);
            this.btnSave.Values.Text = "Save";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlBaseControlContainer
            // 
            this.pnlBaseControlContainer.Controls.Add(this.dgvMain);
            this.pnlBaseControlContainer.Controls.Add(this.ddlPage);
            this.pnlBaseControlContainer.Controls.Add(this.lblPagingSummery);
            this.pnlBaseControlContainer.Controls.Add(this.lblPageNumber);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonGroupBox1);
            this.pnlBaseControlContainer.Location = new System.Drawing.Point(38, 18);
            this.pnlBaseControlContainer.Size = new System.Drawing.Size(696, 539);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonGroupBox1, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.lblPageNumber, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.lblPagingSummery, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.ddlPage, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.dgvMain, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.brdContainerTop, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerBottom, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerLeft, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerRight, 0);
            // 
            // bdrContainerRight
            // 
            this.bdrContainerRight.Location = new System.Drawing.Point(695, 1);
            this.bdrContainerRight.Size = new System.Drawing.Size(1, 537);
            this.bdrContainerRight.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerLeft
            // 
            this.bdrContainerLeft.Size = new System.Drawing.Size(1, 537);
            this.bdrContainerLeft.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerBottom
            // 
            this.bdrContainerBottom.Location = new System.Drawing.Point(0, 538);
            this.bdrContainerBottom.Size = new System.Drawing.Size(696, 1);
            this.bdrContainerBottom.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // brdContainerTop
            // 
            this.brdContainerTop.Size = new System.Drawing.Size(696, 1);
            this.brdContainerTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.Size = new System.Drawing.Size(791, 1);
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // lblService
            // 
            this.lblService.Location = new System.Drawing.Point(63, 39);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(69, 20);
            this.lblService.TabIndex = 4;
            this.lblService.Values.Text = "Test Name";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(63, 69);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(85, 20);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "Test Attribute";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(63, 127);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(131, 20);
            this.kryptonLabel4.TabIndex = 7;
            this.kryptonLabel4.Values.Text = "Female Normal Range";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(63, 96);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(119, 20);
            this.kryptonLabel5.TabIndex = 8;
            this.kryptonLabel5.Values.Text = "Male Normal Range";
            // 
            // ddlService
            // 
            this.ddlService.DropDownWidth = 361;
            this.ddlService.Location = new System.Drawing.Point(214, 39);
            this.ddlService.Name = "ddlService";
            this.ddlService.Size = new System.Drawing.Size(361, 21);
            this.ddlService.TabIndex = 10;
            this.ddlService.SelectedIndexChanged += new System.EventHandler(this.ddlService_SelectedIndexChanged);
            // 
            // tbxAttribute
            // 
            this.tbxAttribute.Location = new System.Drawing.Point(214, 68);
            this.tbxAttribute.Name = "tbxAttribute";
            this.tbxAttribute.Size = new System.Drawing.Size(361, 20);
            this.tbxAttribute.TabIndex = 12;
            // 
            // tbxMaleNormalRange
            // 
            this.tbxMaleNormalRange.Location = new System.Drawing.Point(214, 96);
            this.tbxMaleNormalRange.Name = "tbxMaleNormalRange";
            this.tbxMaleNormalRange.Size = new System.Drawing.Size(254, 20);
            this.tbxMaleNormalRange.TabIndex = 13;
            // 
            // tbxFemaleNormalRange
            // 
            this.tbxFemaleNormalRange.Location = new System.Drawing.Point(214, 124);
            this.tbxFemaleNormalRange.Name = "tbxFemaleNormalRange";
            this.tbxFemaleNormalRange.Size = new System.Drawing.Size(254, 20);
            this.tbxFemaleNormalRange.TabIndex = 15;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(63, 158);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(70, 20);
            this.kryptonLabel1.TabIndex = 16;
            this.kryptonLabel1.Values.Text = "Comments";
            // 
            // tbxComments
            // 
            this.tbxComments.Location = new System.Drawing.Point(214, 158);
            this.tbxComments.Name = "tbxComments";
            this.tbxComments.Size = new System.Drawing.Size(361, 43);
            this.tbxComments.TabIndex = 17;
            this.tbxComments.Text = "";
            // 
            // ddlTestType
            // 
            this.ddlTestType.DropDownWidth = 361;
            this.ddlTestType.Location = new System.Drawing.Point(214, 10);
            this.ddlTestType.Name = "ddlTestType";
            this.ddlTestType.Size = new System.Drawing.Size(361, 21);
            this.ddlTestType.TabIndex = 23;
            this.ddlTestType.SelectedIndexChanged += new System.EventHandler(this.ddlTestType_SelectedIndexChanged);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(63, 10);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel7.TabIndex = 22;
            this.kryptonLabel7.Values.Text = "Test Type";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(23, 6);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.ddlUnit);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnCancel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnDelete);
            this.kryptonGroupBox1.Panel.Controls.Add(this.BtnServiceSave);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ddlTestType);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblService);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel7);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ddlService);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbxAttribute);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbxComments);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbxMaleNormalRange);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbxFemaleNormalRange);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(648, 258);
            this.kryptonGroupBox1.TabIndex = 24;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // ddlUnit
            // 
            this.ddlUnit.DropDownWidth = 85;
            this.ddlUnit.Location = new System.Drawing.Point(485, 110);
            this.ddlUnit.Name = "ddlUnit";
            this.ddlUnit.Size = new System.Drawing.Size(85, 21);
            this.ddlUnit.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(491, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(378, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BtnServiceSave
            // 
            this.BtnServiceSave.Location = new System.Drawing.Point(267, 216);
            this.BtnServiceSave.Name = "BtnServiceSave";
            this.BtnServiceSave.Size = new System.Drawing.Size(90, 25);
            this.BtnServiceSave.TabIndex = 24;
            this.BtnServiceSave.Values.Text = "Save";
            this.BtnServiceSave.Click += new System.EventHandler(this.BtnServiceSave_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerAtId,
            this.AttributeName,
            this.ServiceShortName,
            this.MaleNormalRange,
            this.FemaleNormalRange,
            this.UnitName,
            this.Comment});
            this.dgvMain.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvMain.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvMain.Location = new System.Drawing.Point(24, 276);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(647, 214);
            this.dgvMain.TabIndex = 36;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            // 
            // SerAtId
            // 
            this.SerAtId.DataPropertyName = "SerAtId";
            this.SerAtId.HeaderText = "SerAtId";
            this.SerAtId.Name = "SerAtId";
            this.SerAtId.ReadOnly = true;
            this.SerAtId.Visible = false;
            // 
            // AttributeName
            // 
            this.AttributeName.DataPropertyName = "AttributeName";
            this.AttributeName.HeaderText = "Attribute Name";
            this.AttributeName.Name = "AttributeName";
            this.AttributeName.ReadOnly = true;
            // 
            // ServiceShortName
            // 
            this.ServiceShortName.DataPropertyName = "ServiceShortName";
            this.ServiceShortName.HeaderText = "Service Short Name";
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
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Unit Name";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // ddlPage
            // 
            this.ddlPage.DropDownWidth = 82;
            this.ddlPage.Location = new System.Drawing.Point(334, 503);
            this.ddlPage.Name = "ddlPage";
            this.ddlPage.Size = new System.Drawing.Size(82, 21);
            this.ddlPage.TabIndex = 35;
            // 
            // lblPagingSummery
            // 
            this.lblPagingSummery.Location = new System.Drawing.Point(422, 503);
            this.lblPagingSummery.Name = "lblPagingSummery";
            this.lblPagingSummery.Size = new System.Drawing.Size(92, 20);
            this.lblPagingSummery.TabIndex = 34;
            this.lblPagingSummery.Values.Text = "Page Summary";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Location = new System.Drawing.Point(238, 503);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(86, 20);
            this.lblPageNumber.TabIndex = 33;
            this.lblPageNumber.Values.Text = "Page Number";
            // 
            // ServiceAttributeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 656);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ServiceAttributeEntry";
            this.Text = "ServiceAttributeEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseContainer)).EndInit();
            this.pnlBaseContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseControlContainer)).EndInit();
            this.pnlBaseControlContainer.ResumeLayout(false);
            this.pnlBaseControlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTestType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblService;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxAttribute;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlService;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxMaleNormalRange;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxFemaleNormalRange;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox tbxComments;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlTestType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnServiceSave;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvMain;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlPage;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblPagingSummery;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblPageNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerAtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttributeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaleNormalRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn FemaleNormalRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}