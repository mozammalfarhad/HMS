namespace HMS.Forms.ListForms
{
    partial class CollectionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionList));
            this.btnTest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTotalFee = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPatientName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.CollId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollactionPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnCollectionCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCollectionSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbxPaidAmount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).BeginInit();
            this.pnlBaseSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollactionPanel)).BeginInit();
            this.CollactionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Values.Heading = "Collection";
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
            this.pnlBaseSearch.Controls.Add(this.btnTest);
            this.pnlBaseSearch.Controls.Add(this.lblTotalFee);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel2);
            this.pnlBaseSearch.Controls.Add(this.lblPatientName);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel1);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnSearchTop, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnViewPdf, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.lblPatientName, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel2, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.lblTotalFee, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnTest, 0);
            // 
            // dgvMain
            // 
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CollId,
            this.ScheduleId,
            this.PaidAmount,
            this.CollectionType,
            this.FullName,
            this.Date});
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
            this.btnViewPdf.Visible = false;
            // 
            // btnSearchTop
            // 
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
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(554, 6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(124, 25);
            this.btnTest.TabIndex = 45;
            this.btnTest.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Values.Image")));
            this.btnTest.Values.Text = "New Collection";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.Location = new System.Drawing.Point(415, 11);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(29, 20);
            this.lblTotalFee.TabIndex = 44;
            this.lblTotalFee.Values.Text = "Fee";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(338, 11);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(71, 20);
            this.kryptonLabel2.TabIndex = 43;
            this.kryptonLabel2.Values.Text = "Total Fees :";
            // 
            // lblPatientName
            // 
            this.lblPatientName.Location = new System.Drawing.Point(133, 11);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(49, 20);
            this.lblPatientName.TabIndex = 42;
            this.lblPatientName.Values.Text = "Patient";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(41, 11);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel1.TabIndex = 41;
            this.kryptonLabel1.Values.Text = "Patient Name :";
            // 
            // CollId
            // 
            this.CollId.DataPropertyName = "CollId";
            this.CollId.HeaderText = "CollId";
            this.CollId.Name = "CollId";
            this.CollId.Visible = false;
            // 
            // ScheduleId
            // 
            this.ScheduleId.DataPropertyName = "ScheduleId";
            this.ScheduleId.HeaderText = "ScheduleId";
            this.ScheduleId.Name = "ScheduleId";
            this.ScheduleId.Visible = false;
            // 
            // PaidAmount
            // 
            this.PaidAmount.DataPropertyName = "PaidAmount";
            this.PaidAmount.HeaderText = "Paid Amount";
            this.PaidAmount.Name = "PaidAmount";
            // 
            // CollectionType
            // 
            this.CollectionType.DataPropertyName = "CollectionType";
            this.CollectionType.HeaderText = "Collection Type";
            this.CollectionType.Name = "CollectionType";
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Collected By";
            this.FullName.Name = "FullName";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // CollactionPanel
            // 
            this.CollactionPanel.Controls.Add(this.btnCollectionCancel);
            this.CollactionPanel.Controls.Add(this.btnCollectionSave);
            this.CollactionPanel.Controls.Add(this.tbxPaidAmount);
            this.CollactionPanel.Controls.Add(this.kryptonLabel3);
            this.CollactionPanel.Location = new System.Drawing.Point(164, 147);
            this.CollactionPanel.Name = "CollactionPanel";
            this.CollactionPanel.Size = new System.Drawing.Size(445, 230);
            this.CollactionPanel.TabIndex = 6;
            // 
            // btnCollectionCancel
            // 
            this.btnCollectionCancel.Location = new System.Drawing.Point(243, 112);
            this.btnCollectionCancel.Name = "btnCollectionCancel";
            this.btnCollectionCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCollectionCancel.TabIndex = 3;
            this.btnCollectionCancel.Values.Text = "Cancel";
            this.btnCollectionCancel.Click += new System.EventHandler(this.btnCollectionCancel_Click);
            // 
            // btnCollectionSave
            // 
            this.btnCollectionSave.Location = new System.Drawing.Point(123, 112);
            this.btnCollectionSave.Name = "btnCollectionSave";
            this.btnCollectionSave.Size = new System.Drawing.Size(90, 25);
            this.btnCollectionSave.TabIndex = 2;
            this.btnCollectionSave.Values.Text = "Save";
            this.btnCollectionSave.Click += new System.EventHandler(this.btnCollectionSave_Click);
            // 
            // tbxPaidAmount
            // 
            this.tbxPaidAmount.Location = new System.Drawing.Point(194, 68);
            this.tbxPaidAmount.Name = "tbxPaidAmount";
            this.tbxPaidAmount.Size = new System.Drawing.Size(165, 20);
            this.tbxPaidAmount.TabIndex = 1;
            this.tbxPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPaidAmount_KeyPress);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(77, 67);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(81, 20);
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "Paid Amount";
            // 
            // CollectionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.CollactionPanel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CollectionList";
            this.Text = "Collection List";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Controls.SetChildIndex(this.hdrBaseCaption, 0);
            this.Controls.SetChildIndex(this.pnlBaseButtonContainer, 0);
            this.Controls.SetChildIndex(this.pnlBaseSearch, 0);
            this.Controls.SetChildIndex(this.dgvMain, 0);
            this.Controls.SetChildIndex(this.CollactionPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).EndInit();
            this.pnlBaseSearch.ResumeLayout(false);
            this.pnlBaseSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollactionPanel)).EndInit();
            this.CollactionPanel.ResumeLayout(false);
            this.CollactionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTest;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTotalFee;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPatientName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollectionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel CollactionPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxPaidAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCollectionSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCollectionCancel;
    }
}