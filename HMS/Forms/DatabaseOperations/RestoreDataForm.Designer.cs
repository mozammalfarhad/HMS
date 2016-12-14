namespace HMS.Forms.DatabaseOperations
{
    partial class RestoreDataForm
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
            this.pnlContainer = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblSelectFile = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbxFileBrowsePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblReminder = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hdrTopCaption = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRestore = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.fd = new System.Windows.Forms.OpenFileDialog();
            this.pnlButton = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bdrButtonTop = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).BeginInit();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.btnBrowse);
            this.pnlContainer.Controls.Add(this.lblSelectFile);
            this.pnlContainer.Controls.Add(this.tbxFileBrowsePath);
            this.pnlContainer.Controls.Add(this.lblReminder);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 31);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(439, 131);
            this.pnlContainer.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(347, 39);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(81, 28);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Values.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.Location = new System.Drawing.Point(10, 43);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(65, 20);
            this.lblSelectFile.TabIndex = 0;
            this.lblSelectFile.Values.Text = "Select File";
            // 
            // tbxFileBrowsePath
            // 
            this.tbxFileBrowsePath.Location = new System.Drawing.Point(81, 43);
            this.tbxFileBrowsePath.Name = "tbxFileBrowsePath";
            this.tbxFileBrowsePath.Size = new System.Drawing.Size(260, 20);
            this.tbxFileBrowsePath.TabIndex = 1;
            // 
            // lblReminder
            // 
            this.lblReminder.Location = new System.Drawing.Point(81, 69);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(180, 20);
            this.lblReminder.TabIndex = 0;
            this.lblReminder.Values.Text = "*File must be in zip(.zip) format";
            // 
            // hdrTopCaption
            // 
            this.hdrTopCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdrTopCaption.Location = new System.Drawing.Point(0, 0);
            this.hdrTopCaption.Name = "hdrTopCaption";
            this.hdrTopCaption.Size = new System.Drawing.Size(439, 31);
            this.hdrTopCaption.TabIndex = 1;
            this.hdrTopCaption.Values.Description = "";
            this.hdrTopCaption.Values.Heading = "Restore Database";
            this.hdrTopCaption.Values.Image = null;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(316, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(199, 12);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(111, 40);
            this.btnRestore.TabIndex = 0;
            this.btnRestore.Values.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // fd
            // 
            this.fd.FileName = "openFileDialog1";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.bdrButtonTop);
            this.pnlButton.Controls.Add(this.btnRestore);
            this.pnlButton.Controls.Add(this.btnClose);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 162);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.pnlButton.Size = new System.Drawing.Size(439, 64);
            this.pnlButton.TabIndex = 2;
            // 
            // bdrButtonTop
            // 
            this.bdrButtonTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.bdrButtonTop.Location = new System.Drawing.Point(0, 0);
            this.bdrButtonTop.Name = "bdrButtonTop";
            this.bdrButtonTop.Size = new System.Drawing.Size(439, 1);
            this.bdrButtonTop.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // RestoreDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 226);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.hdrTopCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RestoreDataForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore Database";
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdrTopCaption;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSelectFile;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxFileBrowsePath;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReminder;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBrowse;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRestore;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private System.Windows.Forms.OpenFileDialog fd;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlButton;
        public ComponentFactory.Krypton.Toolkit.KryptonBorderEdge bdrButtonTop;
    }
}

