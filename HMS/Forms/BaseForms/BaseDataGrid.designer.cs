namespace HMS.Forms.BaseForms
{
    partial class BaseDataGrid
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDataGrid));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hdrBaseCaption = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.pnlBaseButtonContainer = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ddlPage = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblPagingSummery = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPageNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.bdrButtonTop = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlBaseSearch = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnViewPdf = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSearchTop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvMain = new HMS.Forms.BaseForms.OpenDataGridView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).BeginInit();
            this.pnlBaseSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdrBaseCaption.Location = new System.Drawing.Point(0, 0);
            this.hdrBaseCaption.Name = "hdrBaseCaption";
            this.hdrBaseCaption.Size = new System.Drawing.Size(794, 31);
            this.hdrBaseCaption.TabIndex = 1;
            this.hdrBaseCaption.Values.Heading = "Caption";
            this.hdrBaseCaption.Values.Image = null;
            // 
            // pnlBaseButtonContainer
            // 
            this.pnlBaseButtonContainer.Controls.Add(this.btnRemove);
            this.pnlBaseButtonContainer.Controls.Add(this.ddlPage);
            this.pnlBaseButtonContainer.Controls.Add(this.lblPagingSummery);
            this.pnlBaseButtonContainer.Controls.Add(this.lblPageNumber);
            this.pnlBaseButtonContainer.Controls.Add(this.bdrButtonTop);
            this.pnlBaseButtonContainer.Controls.Add(this.btnClose);
            this.pnlBaseButtonContainer.Controls.Add(this.btnEdit);
            this.pnlBaseButtonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBaseButtonContainer.Location = new System.Drawing.Point(0, 508);
            this.pnlBaseButtonContainer.Name = "pnlBaseButtonContainer";
            this.pnlBaseButtonContainer.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.pnlBaseButtonContainer.Size = new System.Drawing.Size(794, 64);
            this.pnlBaseButtonContainer.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemove.Location = new System.Drawing.Point(554, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 40);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Values.Text = "Remove";
            // 
            // ddlPage
            // 
            this.ddlPage.DropDownWidth = 82;
            this.ddlPage.Location = new System.Drawing.Point(108, 22);
            this.ddlPage.Name = "ddlPage";
            this.ddlPage.Size = new System.Drawing.Size(82, 21);
            this.ddlPage.TabIndex = 25;
            // 
            // lblPagingSummery
            // 
            this.lblPagingSummery.Location = new System.Drawing.Point(196, 22);
            this.lblPagingSummery.Name = "lblPagingSummery";
            this.lblPagingSummery.Size = new System.Drawing.Size(92, 20);
            this.lblPagingSummery.TabIndex = 24;
            this.lblPagingSummery.Values.Text = "Page Summary";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Location = new System.Drawing.Point(12, 22);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(86, 20);
            this.lblPageNumber.TabIndex = 23;
            this.lblPageNumber.Values.Text = "Page Number";
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.bdrButtonTop.Location = new System.Drawing.Point(0, 0);
            this.bdrButtonTop.Name = "bdrButtonTop";
            this.bdrButtonTop.Size = new System.Drawing.Size(794, 1);
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Location = new System.Drawing.Point(671, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 40);
            this.btnClose.TabIndex = 22;
            this.btnClose.Values.Text = "Close";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.Location = new System.Drawing.Point(437, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 40);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Values.Text = "Edit";
            // 
            // pnlBaseSearch
            // 
            this.pnlBaseSearch.Controls.Add(this.btnViewPdf);
            this.pnlBaseSearch.Controls.Add(this.btnSearchTop);
            this.pnlBaseSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBaseSearch.Location = new System.Drawing.Point(0, 31);
            this.pnlBaseSearch.Name = "pnlBaseSearch";
            this.pnlBaseSearch.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.pnlBaseSearch.Size = new System.Drawing.Size(794, 40);
            this.pnlBaseSearch.TabIndex = 4;
            // 
            // btnViewPdf
            // 
            this.btnViewPdf.Location = new System.Drawing.Point(760, 6);
            this.btnViewPdf.Name = "btnViewPdf";
            this.btnViewPdf.Size = new System.Drawing.Size(28, 28);
            this.btnViewPdf.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPdf.StateCommon.Back.Image")));
            this.btnViewPdf.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnViewPdf.TabIndex = 14;
            this.btnViewPdf.Values.Text = "";
            // 
            // btnSearchTop
            // 
            this.btnSearchTop.Location = new System.Drawing.Point(726, 6);
            this.btnSearchTop.Name = "btnSearchTop";
            this.btnSearchTop.Size = new System.Drawing.Size(28, 28);
            this.btnSearchTop.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTop.StateCommon.Back.Image")));
            this.btnSearchTop.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSearchTop.TabIndex = 13;
            this.btnSearchTop.Values.Text = "";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            this.dgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMain.Location = new System.Drawing.Point(0, 71);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(794, 437);
            this.dgvMain.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvMain.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvMain.TabIndex = 5;
            // 
            // BaseDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.pnlBaseSearch);
            this.Controls.Add(this.pnlBaseButtonContainer);
            this.Controls.Add(this.hdrBaseCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BaseDataGrid";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base Data Grid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).EndInit();
            this.pnlBaseSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonHeader hdrBaseCaption;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel pnlBaseButtonContainer;
        public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge bdrButtonTop;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel pnlBaseSearch;
        public OpenDataGridView dgvMain;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlPage;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblPagingSummery;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblPageNumber;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnViewPdf;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnSearchTop;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnRemove;
    }
}