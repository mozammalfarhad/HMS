namespace HMS.Report
{
    partial class RefererDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefererDetails));
            this.DateFrom = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.DateTo = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.comReferrer = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.PatientCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).BeginInit();
            this.pnlBaseSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comReferrer)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Values.Heading = "referrer";
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
            // 
            // pnlBaseSearch
            // 
            this.pnlBaseSearch.Controls.Add(this.comReferrer);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel3);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel2);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel1);
            this.pnlBaseSearch.Controls.Add(this.DateTo);
            this.pnlBaseSearch.Controls.Add(this.DateFrom);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnSearchTop, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnViewPdf, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.DateFrom, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.DateTo, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel2, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel3, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.comReferrer, 0);
            // 
            // dgvMain
            // 
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientCode,
            this.Name,
            this.Gender,
            this.Age,
            this.ConsultantName,
            this.ReferFee});
            this.dgvMain.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvMain.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
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
            this.btnViewPdf.Location = new System.Drawing.Point(686, 6);
            this.btnViewPdf.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPdf.StateCommon.Back.Image")));
            this.btnViewPdf.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnViewPdf.Values.Text = "";
            this.btnViewPdf.Click += new System.EventHandler(this.btnViewPdf_Click);
            // 
            // btnSearchTop
            // 
            this.btnSearchTop.Location = new System.Drawing.Point(648, 6);
            this.btnSearchTop.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTop.StateCommon.Back.Image")));
            this.btnSearchTop.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSearchTop.Values.Text = "";
            this.btnSearchTop.Click += new System.EventHandler(this.btnSearchTop_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Values.Text = "Remove";
            this.btnRemove.Visible = false;
            // 
            // DateFrom
            // 
            this.DateFrom.Checked = false;
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFrom.Location = new System.Drawing.Point(124, 11);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.ShowCheckBox = true;
            this.DateFrom.Size = new System.Drawing.Size(119, 21);
            this.DateFrom.TabIndex = 15;
            // 
            // DateTo
            // 
            this.DateTo.Checked = false;
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTo.Location = new System.Drawing.Point(335, 11);
            this.DateTo.Name = "DateTo";
            this.DateTo.ShowCheckBox = true;
            this.DateTo.Size = new System.Drawing.Size(118, 21);
            this.DateTo.TabIndex = 16;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(59, 11);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "From Date";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(281, 10);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel2.TabIndex = 18;
            this.kryptonLabel2.Values.Text = "To Date";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(463, 10);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel3.TabIndex = 19;
            this.kryptonLabel3.Values.Text = "Referrer";
            // 
            // comReferrer
            // 
            this.comReferrer.DropDownWidth = 121;
            this.comReferrer.Location = new System.Drawing.Point(519, 11);
            this.comReferrer.Name = "comReferrer";
            this.comReferrer.Size = new System.Drawing.Size(121, 21);
            this.comReferrer.TabIndex = 20;
            // 
            // PatientCode
            // 
            this.PatientCode.DataPropertyName = "PatientCode";
            this.PatientCode.HeaderText = "Patient Code";
            this.PatientCode.Name = "PatientCode";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Patient Name";
            this.Name.Name = "Name";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // ConsultantName
            // 
            this.ConsultantName.DataPropertyName = "ConsultantName";
            this.ConsultantName.HeaderText = "Consultant Name";
            this.ConsultantName.Name = "ConsultantName";
            // 
            // ReferFee
            // 
            this.ReferFee.DataPropertyName = "ReferFee";
            this.ReferFee.HeaderText = "Refer Fee";
            this.ReferFee.Name = "ReferFee";
            // 
            // RefererDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Location = new System.Drawing.Point(0, 0);
     
            this.Text = "referrer Details";
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).EndInit();
            this.pnlBaseSearch.ResumeLayout(false);
            this.pnlBaseSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comReferrer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateTo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comReferrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferFee;
    }
}