namespace HMS.Report
{
    partial class TestResultEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestResultEntry));
            this.TbxServiceName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ComServiceType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnTest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTotalFee = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPatientName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SheduleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleEntry = new System.Windows.Forms.DataGridViewImageColumn();
            this.Entry = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).BeginInit();
            this.pnlBaseSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComServiceType)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Values.Heading = "Individual Patient Test List";
            this.hdrBaseCaption.Values.Image = null;
            this.hdrBaseCaption.Visible = false;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // btnClose
            // 
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Values.Text = "Edit";
            this.btnEdit.Visible = false;
            // 
            // pnlBaseSearch
            // 
            this.pnlBaseSearch.Controls.Add(this.ComServiceType);
            this.pnlBaseSearch.Controls.Add(this.TbxServiceName);
            this.pnlBaseSearch.Controls.Add(this.btnTest);
            this.pnlBaseSearch.Controls.Add(this.lblTotalFee);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel2);
            this.pnlBaseSearch.Controls.Add(this.lblPatientName);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel1);
            this.pnlBaseSearch.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary;
            this.pnlBaseSearch.Size = new System.Drawing.Size(794, 63);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnSearchTop, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.lblPatientName, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel2, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.lblTotalFee, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnTest, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnViewPdf, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.TbxServiceName, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.ComServiceType, 0);
            // 
            // dgvMain
            // 
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SheduleId,
            this.TestId,
            this.PatientId,
            this.ServiceId,
            this.ServiceName,
            this.Rate,
            this.Status,
            this.SampleEntry,
            this.Entry,
            this.Delete});
            this.dgvMain.Location = new System.Drawing.Point(0, 94);
            this.dgvMain.Size = new System.Drawing.Size(794, 414);
            this.dgvMain.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvMain.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            this.dgvMain.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_ColumnHeaderMouseClick);
            // 
            // lblPagingSummery
            // 
            this.lblPagingSummery.Values.Text = "Page Summary";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Values.Text = "Page Number";
            // 
            // btnViewPdf
            // 
            this.btnViewPdf.Location = new System.Drawing.Point(730, 26);
            this.btnViewPdf.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPdf.StateCommon.Back.Image")));
            this.btnViewPdf.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnViewPdf.Values.Text = "";
            this.btnViewPdf.Click += new System.EventHandler(this.btnViewPdf_Click);
            // 
            // btnSearchTop
            // 
            this.btnSearchTop.Location = new System.Drawing.Point(696, 26);
            this.btnSearchTop.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTop.StateCommon.Back.Image")));
            this.btnSearchTop.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSearchTop.Values.Text = "";
            this.btnSearchTop.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Values.Text = "Remove";
            this.btnRemove.Visible = false;
            // 
            // TbxServiceName
            // 
            this.TbxServiceName.Location = new System.Drawing.Point(56, 33);
            this.TbxServiceName.Name = "TbxServiceName";
            this.TbxServiceName.Size = new System.Drawing.Size(159, 20);
            this.TbxServiceName.TabIndex = 15;
            this.TbxServiceName.Text = "Service Name";
            this.TbxServiceName.Enter += new System.EventHandler(this.TbxServiceName_Enter);
            this.TbxServiceName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbxServiceName_KeyUp);
            this.TbxServiceName.Leave += new System.EventHandler(this.TbxServiceName_Leave);
            // 
            // ComServiceType
            // 
            this.ComServiceType.DropDownWidth = 186;
            this.ComServiceType.Location = new System.Drawing.Point(352, 32);
            this.ComServiceType.Name = "ComServiceType";
            this.ComServiceType.Size = new System.Drawing.Size(186, 21);
            this.ComServiceType.TabIndex = 16;
            this.ComServiceType.SelectedIndexChanged += new System.EventHandler(this.ComServiceType_SelectedIndexChanged);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(590, 27);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(90, 25);
            this.btnTest.TabIndex = 40;
            this.btnTest.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Values.Image")));
            this.btnTest.Values.Text = "Add Test";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.Location = new System.Drawing.Point(435, 6);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(29, 20);
            this.lblTotalFee.TabIndex = 39;
            this.lblTotalFee.Values.Text = "Fee";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(358, 6);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(71, 20);
            this.kryptonLabel2.TabIndex = 38;
            this.kryptonLabel2.Values.Text = "Total Fees :";
            // 
            // lblPatientName
            // 
            this.lblPatientName.Location = new System.Drawing.Point(153, 6);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(49, 20);
            this.lblPatientName.TabIndex = 37;
            this.lblPatientName.Values.Text = "Patient";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(61, 6);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel1.TabIndex = 36;
            this.kryptonLabel1.Values.Text = "Patient Name :";
            // 
            // SheduleId
            // 
            this.SheduleId.DataPropertyName = "SheduleId";
            this.SheduleId.HeaderText = "SheduleId";
            this.SheduleId.Name = "SheduleId";
            this.SheduleId.Visible = false;
            // 
            // TestId
            // 
            this.TestId.DataPropertyName = "TestId";
            this.TestId.HeaderText = "TestId";
            this.TestId.Name = "TestId";
            this.TestId.Visible = false;
            // 
            // PatientId
            // 
            this.PatientId.DataPropertyName = "PatientId";
            this.PatientId.HeaderText = "PatientId";
            this.PatientId.Name = "PatientId";
            this.PatientId.Visible = false;
            // 
            // ServiceId
            // 
            this.ServiceId.DataPropertyName = "ServiceId";
            this.ServiceId.HeaderText = "ServiceId";
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.Visible = false;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.FillWeight = 141.584F;
            this.ServiceName.HeaderText = "Service Name";
            this.ServiceName.Name = "ServiceName";
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.FillWeight = 141.584F;
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 141.584F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // SampleEntry
            // 
            this.SampleEntry.HeaderText = "Sample Entry";
            this.SampleEntry.Name = "SampleEntry";
            this.SampleEntry.ToolTipText = "Sample Entry";
            // 
            // Entry
            // 
            this.Entry.HeaderText = "Result Entry";
            this.Entry.Name = "Entry";
            this.Entry.ToolTipText = "Entry";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ToolTipText = "Delete";
            // 
            // TestResultEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TestResultEntry";
            this.Text = "Test Result Entry";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).EndInit();
            this.pnlBaseSearch.ResumeLayout(false);
            this.pnlBaseSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComServiceType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPatientName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTotalFee;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTest;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TbxServiceName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheduleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn SampleEntry;
        private System.Windows.Forms.DataGridViewImageColumn Entry;
        private System.Windows.Forms.DataGridViewImageColumn Delete;



    }
}
