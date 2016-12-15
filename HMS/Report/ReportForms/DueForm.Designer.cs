namespace HMS.Report.ReportForms
{
    partial class DueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DueForm));
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ddlUsers = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.FromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.ToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
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
            this.hdrBaseCaption.Values.Heading = "Due Details";
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
            this.dgvMain.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvMain.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvMain.Visible = false;
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
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 71);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(794, 437);
            this.crystalReportViewer.TabIndex = 6;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(52, 9);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel3.TabIndex = 24;
            this.kryptonLabel3.Values.Text = "Users :";
            // 
            // ddlUsers
            // 
            this.ddlUsers.DropDownWidth = 155;
            this.ddlUsers.Location = new System.Drawing.Point(99, 9);
            this.ddlUsers.Name = "ddlUsers";
            this.ddlUsers.Size = new System.Drawing.Size(135, 21);
            this.ddlUsers.TabIndex = 23;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(486, 10);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel2.TabIndex = 22;
            this.kryptonLabel2.Values.Text = "To Date :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(275, 10);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel1.TabIndex = 21;
            this.kryptonLabel1.Values.Text = "From Date :";
            // 
            // FromDate
            // 
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDate.Location = new System.Drawing.Point(352, 9);
            this.FromDate.Name = "FromDate";
            this.FromDate.ShowCheckBox = true;
            this.FromDate.Size = new System.Drawing.Size(115, 21);
            this.FromDate.TabIndex = 19;
            // 
            // ToDate
            // 
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDate.Location = new System.Drawing.Point(543, 10);
            this.ToDate.Name = "ToDate";
            this.ToDate.ShowCheckBox = true;
            this.ToDate.Size = new System.Drawing.Size(113, 21);
            this.ToDate.TabIndex = 20;
            // 
            // DueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.crystalReportViewer);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "DueForm";
            this.Text = "Due Report";
            this.Controls.SetChildIndex(this.hdrBaseCaption, 0);
            this.Controls.SetChildIndex(this.pnlBaseButtonContainer, 0);
            this.Controls.SetChildIndex(this.pnlBaseSearch, 0);
            this.Controls.SetChildIndex(this.dgvMain, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer, 0);
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

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlUsers;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker FromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker ToDate;
    }
}