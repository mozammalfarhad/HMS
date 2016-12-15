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
    public partial class ServiceEntry : BaseGeneralSetup
    {
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        DataTable dtData = new DataTable();
        DataTable pdfDt = new DataTable();
        DataTable dtg;
        string pdfFileName = string.Empty;
        private int _ID;
        public ServiceEntry()
        {
            InitializeComponent();
            LoadServiceType();
            LoadUnit();
            btnDelete.Enabled = false;
            BindData();
            //WriteOffsetTextToRichTextBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void WriteOffsetTextToRichTextBox()
        {
            // Clear all text from the RichTextBox.
            tbxNormalRangeF.Clear();
            // Set the font for the text.
            tbxNormalRangeF.SelectionFont = new Font("Lucinda Console", 8);
            // Set the foreground color of the text.
        //    tbxNormalRangeF.SelectionColor = Color.Purple;
            // Set the baseline text.
            tbxNormalRangeF.SelectedText = "10";
            // Set the CharOffset to display superscript text.
            tbxNormalRangeF.SelectionCharOffset = 10;
            // Set the superscripted text.	
            tbxNormalRangeF.SelectedText = "2";
            // Reset the CharOffset to display text at the baseline.
            tbxNormalRangeF.SelectionCharOffset = 0;
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
            
        }

        private void LoadServiceType()
        {
            DataTable dt =new bllServiceType().GetAll();
            DataRow dr = dt.NewRow(); //Create New Row
            dr["TypeName"] = "Select";              // Set Column Value
            dr["TypeId"] = "0";
            dt.Rows.InsertAt(dr, 0);
            dt.DefaultView.Sort = "TypeId asc";
            ddlServiceType.DataSource = dt;
            ddlServiceType.ValueMember ="TypeId";
            ddlServiceType.DisplayMember = "TypeName";
            ddlServiceType.SelectedIndex = 0;

        }
        private void LoadUnit()
        {
            DataTable dt = new bllUnit().GetList();
            DataRow dr = dt.NewRow(); //Create New Row
            dr["UnitName"] = "Select";              // Set Column Value
            dr["UnitId"] = "0";
            dt.Rows.InsertAt(dr, 0);
            dt.DefaultView.Sort = "UnitId asc";
            ddlUnit.DataSource = dt;
            ddlUnit.ValueMember = "UnitId";
            ddlUnit.DisplayMember = "UnitName";
            ddlUnit.SelectedIndex = 0;

        }

        private void ckHasAttribute_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHasAttribute.Checked)
            {
                tbxNormalRangeF.Enabled = false;
                tbxNormalRangeM.Enabled = false;
                ddlUnit.Enabled = false;
            }
            else
            {
                tbxNormalRangeF.Enabled = true;
                tbxNormalRangeM.Enabled = true;
                ddlUnit.Enabled = true;
            }
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


        protected void BindData()
        {
            try
            {
                dtg = new bllService().GetList(CurrentPage * PageSize, PageSize, "", false);
                if (dtg.Rows.Count > 0)
                    TotalRec = Convert.ToInt32(dtg.Rows[0]["TotalRecords"].ToString());
                else
                {
                    TotalRec = 0;
                    lblPagingSummery.Text = "";
                }
                dgvMain.Rows.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    int RowNum = dgvMain.Rows.Add(
                        new object[] {
                        dr["ServiceId"],
                        dr["ServiceName"],     
                        dr["ServiceShortName"],
                        dr["MaleNormalRange"],
                        dr["FemaleNormalRange"],     
                        dr["Rate"],
                        dr["Discount"],
                        dr["UnitName"],     
                        dr["TypeName"]
                    });
                    dgvMain.Rows[RowNum].Tag = dr["ServiceId"];
                }
                ChangeDataGridHeader();
                managePaging();
            }
            catch (Exception ex)
            {
            }
        }
        void SaveData()
        {

            try
            {
                bool isChecked = false;
                int unitid = 0;
                decimal rate = 0M;
                decimal discount = 0M;
                if (ddlUnit.SelectedIndex > 0)
                {
                    unitid = Convert.ToInt32(ddlUnit.SelectedValue);
                }
                if (tbxRate.Text != "")
                {
                    rate = Convert.ToDecimal(tbxRate.Text);
                }
                if (tbxDiscount.Text != "")
                {
                    discount = Convert.ToDecimal(tbxDiscount.Text);
                }
                if(ckHasAttribute.Checked)
                {
                    isChecked = true;
                }
                int success = new bllService().Insert(Convert.ToInt32(ddlServiceType.SelectedValue), tbxService.Text.Trim(), tbxShortName.Text.Trim(), tbxNormalRangeM.Text.Trim(), tbxNormalRangeF.Text.Trim(), unitid, rate, discount, isChecked);
                if (success > 0)
                {
                    KryptonMessageBox.Show("Service inserted successfully.", "Insert", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Common.ClearForm(pnlBaseControlContainer);

                }
                else
                {
                    KryptonMessageBox.Show("Service inserted failed.", "Insert Failed", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
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
            dgvMain.Columns["ServiceName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
             dgvMain.Columns["ServiceName"].DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["ServiceShortName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
             dgvMain.Columns["ServiceShortName"].DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["MaleNormalRange"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
             dgvMain.Columns["MaleNormalRange"].DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["FemaleNormalRange"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
             dgvMain.Columns["FemaleNormalRange"].DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
             dgvMain.Columns["Rate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
             dgvMain.Columns["Rate"].DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["Discount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
             dgvMain.Columns["Discount"].DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
              dgvMain.Columns["UnitName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
             dgvMain.Columns["UnitName"].DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
             dgvMain.Columns["TypeName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
             dgvMain.Columns["TypeName"].DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;

        }
        void UpdateData()
        {
            try
            {
                bool isChecked = false;
                int unitid = 0;
                decimal rate = 0M;
                decimal discount = 0M;
                if (ddlUnit.SelectedIndex > 0)
                {
                    unitid = Convert.ToInt32(ddlUnit.SelectedValue);
                }
                if (tbxRate.Text != "")
                {
                    rate = Convert.ToDecimal(tbxRate.Text);
                }
                if (tbxDiscount.Text != "")
                {
                    discount = Convert.ToDecimal(tbxDiscount.Text);
                } 
                if (ckHasAttribute.Checked)
                {
                    isChecked = true;
                }
                int success = new bllService().Update(_ID, Convert.ToInt32(ddlServiceType.SelectedValue), tbxService.Text.Trim(), tbxShortName.Text.Trim(), tbxNormalRangeM.Text.Trim(), tbxNormalRangeF.Text.Trim(), unitid, rate, discount, isChecked);
                if (success > 0)
                {
                    KryptonMessageBox.Show("Service inserted successfully.", "Insert", MessageBoxButtons.OK,
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
                    KryptonMessageBox.Show("Service inserted failed.", "Insert Failed", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {


            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int success = new bllService().Delete(_ID);
                if (success > 0)
                {
                    KryptonMessageBox.Show("Service deleted successfully!", "Deleted Service", MessageBoxButtons.OK,
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
                    KryptonMessageBox.Show("The Service deleted Fail!", "Deleted Service.", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                KryptonMessageBox.Show("The Service deleted Fail!", "Deleted Service.", MessageBoxButtons.OK,
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

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _ID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value);
            DataTable dt = new bllService().GetByID(_ID);

            if (dt.Rows.Count > 0)
            {
                ddlServiceType.SelectedValue = dt.Rows[0]["TypeId"].ToString();
                tbxService.Text = dt.Rows[0]["ServiceName"].ToString();
                tbxShortName.Text = dt.Rows[0]["ServiceShortName"].ToString();
                tbxNormalRangeM.Text = dt.Rows[0]["MaleNormalRange"].ToString();
                tbxNormalRangeF.Text = dt.Rows[0]["FemaleNormalRange"].ToString();
                tbxDiscount.Text = dt.Rows[0]["Discount"].ToString();
                tbxRate.Text = dt.Rows[0]["Rate"].ToString();
                string unit=dt.Rows[0]["UnitId"].ToString();
                if (unit != null)
                    ddlUnit.SelectedValue = unit;
                ckHasAttribute.Checked = Convert.ToBoolean(dt.Rows[0]["HasAttribute"]);
                btnDelete.Enabled = true;
                BtnServiceSave.Text = "Update";
                btnCancel.Visible = true;
            }
        }

        private void ddlServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtg != null && _ID <= 0)
            {
                DataView dv;
                if (ddlServiceType.SelectedIndex != 0)
                {
                    dv = new DataView(dtg, "TypeId = " + ddlServiceType.SelectedValue, "", DataViewRowState.CurrentRows);

                }
                else
                {
                    dv = new DataView(dtg, "", "", DataViewRowState.CurrentRows);
                }
                dgvMain.Rows.Clear();
                foreach (DataRow dr in dv.ToTable().Rows)
                {
                    int RowNum = dgvMain.Rows.Add(
                        new object[] {
                        dr["ServiceId"],
                        dr["ServiceName"],     
                        dr["ServiceShortName"],
                        dr["MaleNormalRange"],
                        dr["FemaleNormalRange"],     
                        dr["Rate"],
                        dr["Discount"],
                        dr["UnitName"],     
                        dr["TypeName"]
                    });
                    dgvMain.Rows[RowNum].Tag = dr["ServiceId"];
                }
                ChangeDataGridHeader();
                managePaging();

            }
            
            
        }
    }
}
