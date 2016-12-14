namespace HMS.Report.ReportForms
{
    partial class DailySummeryStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySummeryStatement));
            this.FromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.ToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayableAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueCollectedAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlUsers = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).BeginInit();
            this.pnlBaseSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Values.Heading = "Daily Summery Statement Of Income";
            this.hdrBaseCaption.Values.Image = null;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // btnClose
            // 
            this.btnClose.Values.Text = "Close";
            // 
            // btnEdit
            // 
            this.btnEdit.Values.Text = "Edit";
            this.btnEdit.Visible = false;
            // 
            // pnlBaseSearch
            // 
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel3);
            this.pnlBaseSearch.Controls.Add(this.ddlUsers);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel2);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel1);
            this.pnlBaseSearch.Controls.Add(this.FromDate);
            this.pnlBaseSearch.Controls.Add(this.ToDate);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnSearchTop, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnViewPdf, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.ToDate, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.FromDate, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel2, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.ddlUsers, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel3, 0);
            // 
            // dgvMain
            // 
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.SubTotal,
            this.TotalDiscount,
            this.VatAmt,
            this.PayableAmt,
            this.PaidAmt,
            this.DueAmt,
            this.DueCollectedAmt});
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
            this.btnRemove.Visible = false;
            // 
            // FromDate
            // 
            this.FromDate.Location = new System.Drawing.Point(294, 8);
            this.FromDate.Name = "FromDate";
            this.FromDate.ShowCheckBox = true;
            this.FromDate.Size = new System.Drawing.Size(177, 21);
            this.FromDate.TabIndex = 6;
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(531, 9);
            this.ToDate.Name = "ToDate";
            this.ToDate.ShowCheckBox = true;
            this.ToDate.Size = new System.Drawing.Size(189, 21);
            this.ToDate.TabIndex = 7;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(217, 9);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel1.TabIndex = 15;
            this.kryptonLabel1.Values.Text = "From Date :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(474, 9);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel2.TabIndex = 16;
            this.kryptonLabel2.Values.Text = "To Date :";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // TotalDiscount
            // 
            this.TotalDiscount.DataPropertyName = "TotalDiscount";
            this.TotalDiscount.HeaderText = "TotalDiscount";
            this.TotalDiscount.Name = "TotalDiscount";
            // 
            // VatAmt
            // 
            this.VatAmt.DataPropertyName = "VatAmt";
            this.VatAmt.HeaderText = "VatAmt";
            this.VatAmt.Name = "VatAmt";
            // 
            // PayableAmt
            // 
            this.PayableAmt.DataPropertyName = "PayableAmt";
            this.PayableAmt.HeaderText = "PayableAmt";
            this.PayableAmt.Name = "PayableAmt";
            // 
            // PaidAmt
            // 
            this.PaidAmt.DataPropertyName = "PaidAmt";
            this.PaidAmt.HeaderText = "PaidAmt";
            this.PaidAmt.Name = "PaidAmt";
            // 
            // DueAmt
            // 
            this.DueAmt.DataPropertyName = "DueAmt";
            this.DueAmt.HeaderText = "DueAmt";
            this.DueAmt.Name = "DueAmt";
            // 
            // DueCollectedAmt
            // 
            this.DueCollectedAmt.DataPropertyName = "DueCollectedAmt";
            this.DueCollectedAmt.HeaderText = "DueCollectedAmt";
            this.DueCollectedAmt.Name = "DueCollectedAmt";
            // 
            // ddlUsers
            // 
            this.ddlUsers.DropDownWidth = 155;
            this.ddlUsers.Location = new System.Drawing.Point(60, 8);
            this.ddlUsers.Name = "ddlUsers";
            this.ddlUsers.Size = new System.Drawing.Size(155, 21);
            this.ddlUsers.TabIndex = 17;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(16, 8);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel3.TabIndex = 18;
            this.kryptonLabel3.Values.Text = "Users :";
            // 
            // DailySummeryStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "DailySummeryStatement";
            this.Text = "DailySummeryStatement";
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).EndInit();
            this.pnlBaseSearch.ResumeLayout(false);
            this.pnlBaseSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker FromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker ToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayableAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueCollectedAmt;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlUsers;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}