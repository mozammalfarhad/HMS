namespace HMS.Forms.DatabaseOperations
{
    partial class BackUpForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMain = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.BackupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackupBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrdTopCaption = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNewBackup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSaveAs = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.fd = new System.Windows.Forms.SaveFileDialog();
            this.pnlButtonBottom = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bdrButtonTop = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtonBottom)).BeginInit();
            this.pnlButtonBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BackupDate,
            this.BackupBy,
            this.FileName});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMain.Location = new System.Drawing.Point(0, 31);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(694, 381);
            this.dgvMain.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvMain.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvMain.TabIndex = 1;
            // 
            // BackupDate
            // 
            this.BackupDate.HeaderText = "Date";
            this.BackupDate.Name = "BackupDate";
            this.BackupDate.ReadOnly = true;
            // 
            // BackupBy
            // 
            this.BackupBy.HeaderText = "Backup By";
            this.BackupBy.Name = "BackupBy";
            this.BackupBy.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // hrdTopCaption
            // 
            this.hrdTopCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.hrdTopCaption.Location = new System.Drawing.Point(0, 0);
            this.hrdTopCaption.Name = "hrdTopCaption";
            this.hrdTopCaption.Size = new System.Drawing.Size(694, 31);
            this.hrdTopCaption.TabIndex = 0;
            this.hrdTopCaption.Values.Description = "";
            this.hrdTopCaption.Values.Heading = "Backup Database";
            this.hrdTopCaption.Values.Image = null;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(571, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(220, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 40);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Values.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNewBackup
            // 
            this.btnNewBackup.Location = new System.Drawing.Point(454, 12);
            this.btnNewBackup.Name = "btnNewBackup";
            this.btnNewBackup.Size = new System.Drawing.Size(111, 40);
            this.btnNewBackup.TabIndex = 0;
            this.btnNewBackup.Values.Text = "New Backup";
            this.btnNewBackup.Click += new System.EventHandler(this.btnNewBackup_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(337, 12);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(111, 40);
            this.btnSaveAs.TabIndex = 0;
            this.btnSaveAs.Values.Text = "Save As";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // pnlButtonBottom
            // 
            this.pnlButtonBottom.Controls.Add(this.bdrButtonTop);
            this.pnlButtonBottom.Controls.Add(this.btnSaveAs);
            this.pnlButtonBottom.Controls.Add(this.btnRemove);
            this.pnlButtonBottom.Controls.Add(this.btnClose);
            this.pnlButtonBottom.Controls.Add(this.btnNewBackup);
            this.pnlButtonBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonBottom.Location = new System.Drawing.Point(0, 412);
            this.pnlButtonBottom.Name = "pnlButtonBottom";
            this.pnlButtonBottom.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.pnlButtonBottom.Size = new System.Drawing.Size(694, 64);
            this.pnlButtonBottom.TabIndex = 1;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.bdrButtonTop.Location = new System.Drawing.Point(0, 0);
            this.bdrButtonTop.Name = "bdrButtonTop";
            this.bdrButtonTop.Size = new System.Drawing.Size(694, 1);
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 476);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.hrdTopCaption);
            this.Controls.Add(this.pnlButtonBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BackUpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup Database";
            this.Load += new System.EventHandler(this.BackUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtonBottom)).EndInit();
            this.pnlButtonBottom.ResumeLayout(false);
            this.pnlButtonBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvMain;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hrdTopCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNewBackup;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveAs;
        private System.Windows.Forms.SaveFileDialog fd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRemove;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlButtonBottom;
        public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge bdrButtonTop;
    }
}

