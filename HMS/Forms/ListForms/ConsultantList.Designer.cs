namespace HMS.Forms.ListForms
{
    partial class ConsultantList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultantList));
            this.listBox1 = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ddlDepartment = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tbxSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ConsultantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultantCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultantEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultantAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultantMobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultantQualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultantGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultantTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).BeginInit();
            this.pnlBaseButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).BeginInit();
            this.pnlBaseSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrBaseCaption
            // 
            this.hdrBaseCaption.Values.Heading = "Consultant & Others List";
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlBaseSearch
            // 
            this.pnlBaseSearch.Controls.Add(this.listBox1);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel2);
            this.pnlBaseSearch.Controls.Add(this.kryptonLabel1);
            this.pnlBaseSearch.Controls.Add(this.ddlDepartment);
            this.pnlBaseSearch.Controls.Add(this.tbxSearch);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnSearchTop, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.btnViewPdf, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.tbxSearch, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.ddlDepartment, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.kryptonLabel2, 0);
            this.pnlBaseSearch.Controls.SetChildIndex(this.listBox1, 0);
            // 
            // dgvMain
            // 
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsultantId,
            this.ConsultantCode,
            this.ConsultantName,
            this.ConsultantEmail,
            this.ConsultantAddress,
            this.ConsultantMobileNo,
            this.DepName,
            this.ConsultantQualification,
            this.ConsultantGender,
            this.ConsultantTypeName});
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
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(180, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(148, 96);
            this.listBox1.TabIndex = 25;
            this.listBox1.Visible = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(394, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(76, 20);
            this.kryptonLabel2.TabIndex = 24;
            this.kryptonLabel2.Values.Text = "Department";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(86, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(101, 20);
            this.kryptonLabel1.TabIndex = 23;
            this.kryptonLabel1.Values.Text = "Consultant Code";
            // 
            // ddlDepartment
            // 
            this.ddlDepartment.DropDownWidth = 121;
            this.ddlDepartment.Location = new System.Drawing.Point(474, 12);
            this.ddlDepartment.Name = "ddlDepartment";
            this.ddlDepartment.Size = new System.Drawing.Size(165, 21);
            this.ddlDepartment.TabIndex = 22;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(178, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(153, 20);
            this.tbxSearch.TabIndex = 21;
            // 
            // ConsultantId
            // 
            this.ConsultantId.DataPropertyName = "ConsultantId";
            this.ConsultantId.HeaderText = "ConsultantId";
            this.ConsultantId.Name = "ConsultantId";
            this.ConsultantId.Visible = false;
            // 
            // ConsultantCode
            // 
            this.ConsultantCode.DataPropertyName = "ConsultantCode";
            this.ConsultantCode.HeaderText = "ConsultantCode";
            this.ConsultantCode.Name = "ConsultantCode";
            // 
            // ConsultantName
            // 
            this.ConsultantName.DataPropertyName = "ConsultantName";
            this.ConsultantName.HeaderText = "Name";
            this.ConsultantName.Name = "ConsultantName";
            // 
            // ConsultantEmail
            // 
            this.ConsultantEmail.DataPropertyName = "ConsultantEmail";
            this.ConsultantEmail.HeaderText = "Email";
            this.ConsultantEmail.Name = "ConsultantEmail";
            // 
            // ConsultantAddress
            // 
            this.ConsultantAddress.DataPropertyName = "ConsultantAddress";
            this.ConsultantAddress.HeaderText = "Address";
            this.ConsultantAddress.Name = "ConsultantAddress";
            // 
            // ConsultantMobileNo
            // 
            this.ConsultantMobileNo.DataPropertyName = "ConsultantMobileNo";
            this.ConsultantMobileNo.HeaderText = "MobileNo";
            this.ConsultantMobileNo.Name = "ConsultantMobileNo";
            // 
            // DepName
            // 
            this.DepName.DataPropertyName = "DepName";
            this.DepName.HeaderText = "Department";
            this.DepName.Name = "DepName";
            // 
            // ConsultantQualification
            // 
            this.ConsultantQualification.DataPropertyName = "ConsultantQualification";
            this.ConsultantQualification.HeaderText = "Qualification";
            this.ConsultantQualification.Name = "ConsultantQualification";
            // 
            // ConsultantGender
            // 
            this.ConsultantGender.DataPropertyName = "ConsultantGender";
            this.ConsultantGender.HeaderText = "Gender";
            this.ConsultantGender.Name = "ConsultantGender";
            // 
            // ConsultantTypeName
            // 
            this.ConsultantTypeName.DataPropertyName = "ConsultantTypeName";
            this.ConsultantTypeName.HeaderText = "Type";
            this.ConsultantTypeName.Name = "ConsultantTypeName";
            // 
            // ConsultantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ConsultantList";
            this.Text = "ConsultantList";
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseButtonContainer)).EndInit();
            this.pnlBaseButtonContainer.ResumeLayout(false);
            this.pnlBaseButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBaseSearch)).EndInit();
            this.pnlBaseSearch.ResumeLayout(false);
            this.pnlBaseSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonListBox listBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlDepartment;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultantCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultantEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultantAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultantMobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultantQualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultantGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultantTypeName;
    }
}