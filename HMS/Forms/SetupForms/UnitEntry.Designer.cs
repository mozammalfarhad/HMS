namespace HMS.Forms.SetupForms
{
    partial class UnitEntry
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbxUnit = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnServiceSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvMain = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.UnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.hdrBaseCaption.Values.Heading = "Add Unit";
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlBaseControlContainer
            // 
            this.pnlBaseControlContainer.Controls.Add(this.ddlPage);
            this.pnlBaseControlContainer.Controls.Add(this.lblPagingSummery);
            this.pnlBaseControlContainer.Controls.Add(this.lblPageNumber);
            this.pnlBaseControlContainer.Controls.Add(this.dgvMain);
            this.pnlBaseControlContainer.Controls.Add(this.kryptonGroupBox1);
            this.pnlBaseControlContainer.Location = new System.Drawing.Point(97, 36);
            this.pnlBaseControlContainer.Size = new System.Drawing.Size(607, 410);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.brdContainerTop, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerBottom, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerLeft, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.bdrContainerRight, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.kryptonGroupBox1, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.dgvMain, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.lblPageNumber, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.lblPagingSummery, 0);
            this.pnlBaseControlContainer.Controls.SetChildIndex(this.ddlPage, 0);
            // 
            // bdrContainerRight
            // 
            this.bdrContainerRight.Location = new System.Drawing.Point(606, 1);
            this.bdrContainerRight.Size = new System.Drawing.Size(1, 408);
            this.bdrContainerRight.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerLeft
            // 
            this.bdrContainerLeft.Size = new System.Drawing.Size(1, 408);
            this.bdrContainerLeft.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrContainerBottom
            // 
            this.bdrContainerBottom.Location = new System.Drawing.Point(0, 409);
            this.bdrContainerBottom.Size = new System.Drawing.Size(607, 1);
            this.bdrContainerBottom.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // brdContainerTop
            // 
            this.brdContainerTop.Size = new System.Drawing.Size(607, 1);
            this.brdContainerTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(104, 17);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "Unit Name";
            // 
            // tbxUnit
            // 
            this.tbxUnit.Location = new System.Drawing.Point(209, 17);
            this.tbxUnit.Name = "tbxUnit";
            this.tbxUnit.Size = new System.Drawing.Size(208, 22);
            this.tbxUnit.TabIndex = 6;
            this.tbxUnit.Text = "";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(179, 17);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(13, 20);
            this.kryptonLabel2.TabIndex = 7;
            this.kryptonLabel2.Values.Text = ":";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(20, 20);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnCancel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnDelete);
            this.kryptonGroupBox1.Panel.Controls.Add(this.BtnServiceSave);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbxUnit);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(563, 96);
            this.kryptonGroupBox1.TabIndex = 8;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(434, 56);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(321, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BtnServiceSave
            // 
            this.BtnServiceSave.Location = new System.Drawing.Point(210, 56);
            this.BtnServiceSave.Name = "BtnServiceSave";
            this.BtnServiceSave.Size = new System.Drawing.Size(90, 25);
            this.BtnServiceSave.TabIndex = 28;
            this.BtnServiceSave.Values.Text = "Save";
            this.BtnServiceSave.Click += new System.EventHandler(this.BtnServiceSave_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnitId,
            this.UnitName});
            this.dgvMain.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvMain.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvMain.Location = new System.Drawing.Point(24, 126);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(559, 243);
            this.dgvMain.TabIndex = 9;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            // 
            // UnitId
            // 
            this.UnitId.DataPropertyName = "UnitId";
            this.UnitId.HeaderText = "UnitId";
            this.UnitId.Name = "UnitId";
            this.UnitId.ReadOnly = true;
            this.UnitId.Visible = false;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Unit Name";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            // 
            // ddlPage
            // 
            this.ddlPage.DropDownWidth = 82;
            this.ddlPage.Location = new System.Drawing.Point(272, 381);
            this.ddlPage.Name = "ddlPage";
            this.ddlPage.Size = new System.Drawing.Size(82, 21);
            this.ddlPage.TabIndex = 31;
            // 
            // lblPagingSummery
            // 
            this.lblPagingSummery.Location = new System.Drawing.Point(360, 381);
            this.lblPagingSummery.Name = "lblPagingSummery";
            this.lblPagingSummery.Size = new System.Drawing.Size(92, 20);
            this.lblPagingSummery.TabIndex = 30;
            this.lblPagingSummery.Values.Text = "Page Summary";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Location = new System.Drawing.Point(176, 381);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(86, 20);
            this.lblPageNumber.TabIndex = 29;
            this.lblPageNumber.Values.Text = "Page Number";
            // 
            // UnitEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UnitEntry";
            this.Text = "UnitEntry";
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

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox tbxUnit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnServiceSave;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvMain;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlPage;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblPagingSummery;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblPageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
    }
}