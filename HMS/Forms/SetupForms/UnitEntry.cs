using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HMS.App_Code.BLL;
using HMS.Forms.BaseForms;

namespace HMS.Forms.SetupForms
{
    public partial class UnitEntry : BaseGeneralSetup
    {
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        DataTable dtData = new DataTable();
        DataTable pdfDt = new DataTable();
        string pdfFileName = string.Empty;
        private int _ID;
        public UnitEntry()
        {
            InitializeComponent();
            //WriteOffsetTextToRichTextBox(); 
            btnDelete.Enabled = false;
            BindData();
        }
        private void WriteOffsetTextToRichTextBox()
        {
            // Clear all text from the RichTextBox.
            tbxUnit.Clear();
            // Set the font for the text.
            tbxUnit.SelectionFont = new Font("Lucinda Console", 8);
            // Set the foreground color of the text.
            //    tbxNormalRangeF.SelectionColor = Color.Purple;
            // Set the baseline text.
            tbxUnit.SelectedText = "10";
            // Set the CharOffset to display superscript text.
            tbxUnit.SelectionCharOffset = 10;
            // Set the superscripted text.	
            tbxUnit.SelectedText = "2";
            // Reset the CharOffset to display text at the baseline.
            tbxUnit.SelectionCharOffset = 0;
            //richTextBox1.AppendText("\n\n");
            //// Change the forecolor of the next text selection.
            //richTextBox1.SelectionColor = Color.Blue;
            //// Set the baseline text.
            //richTextBox1.SelectedText = "77";
            //// Set the CharOffset to display subscript text.
            //richTextBox1.SelectionCharOffset = -10;
            //// Set the subscripted text.  
            //richTextBox1.SelectedText = "3";
            //// Reset the CharOffset to display text at the baseline.
            //richTextBox1.SelectionCharOffset = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ID > 0)
            {
                UpdateData();
            }
            else
            {
                SaveData();
                BindData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void SaveData()
        {
            int success = new bllUnit().Insert(tbxUnit.Text.Trim());
            if (success > 0)
            {
                KryptonMessageBox.Show("Unit inserted successfully!", "Unit Entry", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Common.ClearForm(pnlBaseControlContainer);
            }
            else
            {
                KryptonMessageBox.Show("Unit inserted failed!", "Unit Entry.", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        void UpdateData()
        {
            int success = new bllUnit().Update(_ID,tbxUnit.Text.Trim());
            if (success > 0)
            {
                KryptonMessageBox.Show("Unit updated successfully!", "Unit Entry", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Common.ClearForm(pnlBaseControlContainer); 
                BindData();
                _ID = -1;
                BtnServiceSave.Text = "Save";
                btnDelete.Enabled = false;
                btnCancel.Visible = false;
            }
            else
            {
                KryptonMessageBox.Show("Unit updated failed!", "Unit Entry.", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }



        protected void BindData()
        {
            try
            {
                DataTable dt;
                dt = new bllUnit().GetAll(CurrentPage * PageSize, PageSize, "", false);
                if (dt.Rows.Count > 0)
                    TotalRec = Convert.ToInt32(dt.Rows[0]["TotalRecords"].ToString());
                else
                {
                    TotalRec = 0;
                    lblPagingSummery.Text = "";
                }
                dgvMain.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    int RowNum = dgvMain.Rows.Add(
                        new object[] {
                        dr["UnitId"],
                        dr["UnitName"]
                    });
                    dgvMain.Rows[RowNum].Tag = dr["UnitId"];
                }
                ChangeDataGridHeader();
                managePaging();
                Common.LoadSerial(dgvMain);
            }
            catch (Exception ex)
            {
            }
        }


        protected void managePaging()
        {
            ddlPage.Items.Clear();
            if (TotalRec > 0)
            {
                int numberOfPages;
                int numberOfRecords = TotalRec;
                int currentPage = CurrentPage;
                StringBuilder strSummary = new StringBuilder();
                if (numberOfRecords > PageSize)
                {
                    numberOfPages = (int)Math.Ceiling((double)numberOfRecords / (double)PageSize);
                }
                else
                {
                    numberOfPages = 1;
                }
                strSummary.Append("Displaying ");
                int floor = (currentPage * PageSize) + 1;
                strSummary.Append(floor.ToString());
                strSummary.Append("-");
                int ceil = ((currentPage * PageSize) + PageSize);
                if (ceil > numberOfRecords)
                {
                    strSummary.Append(numberOfRecords.ToString());
                }
                else
                {
                    strSummary.Append(ceil.ToString());
                }
                strSummary.Append(" of About ");
                strSummary.Append(numberOfRecords.ToString());
                strSummary.Append(" Records");
                lblPagingSummery.Text = strSummary.ToString();
                for (int i = 1; i <= numberOfPages; i++)
                    ddlPage.Items.Add(i.ToString());
                if (ddlPage.Items.Count >= currentPage)
                    ddlPage.SelectedIndex = currentPage;
            }
        }

        private void ChangeDataGridHeader()
        {
            dgvMain.Columns["UnitName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["UnitName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void BtnServiceSave_Click(object sender, EventArgs e)
        {
            if (_ID > 0)
            {
                UpdateData();
            }
            else
            {
                SaveData();
                BindData();
            }
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _ID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value);
            LoadData();
        }


        private void LoadData()
        {
            DataTable dt = new bllUnit().GetByID(_ID);

            if (dt.Rows.Count > 0)
            {
                tbxUnit.Text = dt.Rows[0]["UnitName"].ToString();
                btnDelete.Enabled = true;
                BtnServiceSave.Text = "Update";
                btnCancel.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int success = new bllUnit().Delete(_ID);
                if(success>0)
                {
                    KryptonMessageBox.Show("Unit deleted successfully!", "Deleted Unit", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    Common.ClearForm(pnlBaseControlContainer);
                    BindData();
                    _ID = -1;
                    BtnServiceSave.Text = "Save";
                    btnDelete.Enabled = false;
                    btnCancel.Visible = false;
                }
                else
                {
                    KryptonMessageBox.Show("The Unit deleted Fail!", "Deleted Unit.", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
            }
            catch(Exception ex){
                KryptonMessageBox.Show("" + ex.Message, "Deleted Unit.", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _ID = -1;
            btnCancel.Visible = false;
            btnDelete.Enabled = false;
            BtnServiceSave.Text = "Save";
            Common.ClearFormWithoutGrid(pnlBaseControlContainer);
        }

    }
}
