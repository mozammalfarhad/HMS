namespace HMS.Report
{
    partial class PatientTestDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientTestDetails));
            this.ddlPatient = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbxPatientCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbxMobile = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbxSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.FromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewLinkColumn();
            this.BloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SheduleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).BeginInit();
            this.pnlBaseSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Values.Heading = "Patient Service Details";
            this.hdrBaseCaption.Values.Image = null;
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlBaseSearch
            // 
            this.pnlBaseSearch.Controls.Add(this.ToDate);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel6);
            this.pnlBaseSearch.Controls.Add(this.FromDate);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel5);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel3);
            this.pnlBaseSearch.Controls.Add(this.tbxSearch);
            this.pnlBaseSearch.Controls.Add(this.tbxMobile);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel2);
            this.pnlBaseSearch.Controls.Add(this.tbxPatientCode);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel1);
            this.pnlBaseSearch.Controls.Add(this.ddlPatient);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel4);
            this.pnlBaseSearch.Size = new System.Drawing.Size(794, 80);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnSearchTop, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnViewPdf, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel4, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.ddlPatient, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.tbxPatientCode, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel2, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.tbxMobile, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.tbxSearch, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel3, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel5, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.FromDate, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel6, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.ToDate, 0);
            // 
            // dgvMain
            // 
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.PatientCode,
            this.Name,
            this.MobileNo,
            this.Gender,
            this.BloodGroup,
            this.ReferBy,
            this.SheduleId,
            this.ReceiveDate,
            this.ReceiveTime,
            this.DeliveryDate,
            this.DeliveryTime,
            this.TotalAmount,
            this.totalDiscount,
            this.PaidAmount,
            this.Status});
            this.dgvMain.Location = new System.Drawing.Point(0, 111);
            this.dgvMain.Size = new System.Drawing.Size(794, 397);
            this.dgvMain.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvMain.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
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
            this.btnViewPdf.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPdf.StateCommon.Back.Image")));
            this.btnViewPdf.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnViewPdf.Values.Text = "";
            this.btnViewPdf.Click += new System.EventHandler(this.btnViewPdf_Click);
            // 
            // btnSearchTop
            // 
            this.btnSearchTop.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTop.StateCommon.Back.Image")));
            this.btnSearchTop.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSearchTop.Values.Text = "";
            this.btnSearchTop.Click += new System.EventHandler(this.btnSearchTop_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Values.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ddlPatient
            // 
            this.ddlPatient.DropDownWidth = 310;
            this.ddlPatient.Location = new System.Drawing.Point(349, 7);
            this.ddlPatient.Name = "ddlPatient";
            this.ddlPatient.Size = new System.Drawing.Size(180, 21);
            this.ddlPatient.TabIndex = 57;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(16, 10);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(81, 20);
            this.kryptonLabel4.TabIndex = 56;
            this.kryptonLabel4.Values.Text = "Patient Code";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(265, 8);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(85, 20);
            this.kryptonLabel1.TabIndex = 58;
            this.kryptonLabel1.Values.Text = "Patient Name";
            // 
            // tbxPatientCode
            // 
            this.tbxPatientCode.Location = new System.Drawing.Point(105, 10);
            this.tbxPatientCode.Name = "tbxPatientCode";
            this.tbxPatientCode.Size = new System.Drawing.Size(160, 20);
            this.tbxPatientCode.TabIndex = 61;
            this.tbxPatientCode.TextChanged += new System.EventHandler(this.tbxPatientCode_TextChanged);
            // 
            // tbxMobile
            // 
            this.tbxMobile.Location = new System.Drawing.Point(602, 8);
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.Size = new System.Drawing.Size(118, 20);
            this.tbxMobile.TabIndex = 63;
            this.tbxMobile.TextChanged += new System.EventHandler(this.tbxMobile_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(535, 9);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel2.TabIndex = 62;
            this.kryptonLabel2.Values.Text = "Mobile No";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(105, 40);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(160, 20);
            this.tbxSearch.TabIndex = 64;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(50, 40);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel3.TabIndex = 65;
            this.kryptonLabel3.Values.Text = "Search";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(265, 40);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel5.TabIndex = 66;
            this.kryptonLabel5.Values.Text = "From Date";
            // 
            // FromDate
            // 
            this.FromDate.AllowDrop = true;
            this.FromDate.Checked = false;
            this.FromDate.Location = new System.Drawing.Point(351, 39);
            this.FromDate.Name = "FromDate";
            this.FromDate.ShowCheckBox = true;
            this.FromDate.Size = new System.Drawing.Size(179, 21);
            this.FromDate.TabIndex = 102;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(535, 40);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel6.TabIndex = 103;
            this.kryptonLabel6.Values.Text = "To Date";
            // 
            // ToDate
            // 
            this.ToDate.Checked = false;
            this.ToDate.Location = new System.Drawing.Point(603, 39);
            this.ToDate.Name = "ToDate";
            this.ToDate.ShowCheckBox = true;
            this.ToDate.Size = new System.Drawing.Size(179, 21);
            this.ToDate.TabIndex = 104;
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "PatientID";
            this.PatientID.Name = "PatientID";
            this.PatientID.Visible = false;
            // 
            // PatientCode
            // 
            this.PatientCode.DataPropertyName = "PatientCode";
            this.PatientCode.HeaderText = "PatientCode";
            this.PatientCode.Name = "PatientCode";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // MobileNo
            // 
            this.MobileNo.DataPropertyName = "MobileNo";
            this.MobileNo.HeaderText = "MobileNo";
            this.MobileNo.Name = "MobileNo";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender/Age";
            this.Gender.Name = "Gender";
            this.Gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BloodGroup
            // 
            this.BloodGroup.DataPropertyName = "BloodGroup";
            this.BloodGroup.HeaderText = "B.Group";
            this.BloodGroup.Name = "BloodGroup";
            // 
            // ReferBy
            // 
            this.ReferBy.DataPropertyName = "ReferBy";
            this.ReferBy.HeaderText = "ReferBy";
            this.ReferBy.Name = "ReferBy";
            // 
            // SheduleId
            // 
            this.SheduleId.DataPropertyName = "SheduleId";
            this.SheduleId.HeaderText = "SheduleId";
            this.SheduleId.Name = "SheduleId";
            this.SheduleId.Visible = false;
            // 
            // ReceiveDate
            // 
            this.ReceiveDate.DataPropertyName = "Rcv.Date";
            this.ReceiveDate.HeaderText = "Rcv.Date";
            this.ReceiveDate.Name = "ReceiveDate";
            // 
            // ReceiveTime
            // 
            this.ReceiveTime.DataPropertyName = "Rcv.Time";
            this.ReceiveTime.HeaderText = "Rcv.Time";
            this.ReceiveTime.Name = "ReceiveTime";
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.DataPropertyName = "Dlv.Date";
            this.DeliveryDate.HeaderText = "Dlv.Date";
            this.DeliveryDate.Name = "DeliveryDate";
            // 
            // DeliveryTime
            // 
            this.DeliveryTime.DataPropertyName = "Dlv.Time";
            this.DeliveryTime.HeaderText = "Dlv.Time";
            this.DeliveryTime.Name = "DeliveryTime";
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "T.Amt";
            this.TotalAmount.HeaderText = "Payable";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // totalDiscount
            // 
            this.totalDiscount.DataPropertyName = "T.Dis.";
            this.totalDiscount.HeaderText = "T.Disc";
            this.totalDiscount.Name = "totalDiscount";
            this.totalDiscount.Visible = false;
            // 
            // PaidAmount
            // 
            this.PaidAmount.DataPropertyName = "PaidAmt";
            this.PaidAmount.HeaderText = "PaidAmt";
            this.PaidAmount.Name = "PaidAmount";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // PatientTestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Location = new System.Drawing.Point(0, 0);
            this.Text = "Patient Service List";
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).EndInit();
            this.pnlBaseSearch.ResumeLayout(false);
            this.pnlBaseSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlPatient;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxPatientCode;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxMobile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker ToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker FromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewLinkColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheduleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}