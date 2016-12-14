using ComponentFactory.Krypton.Toolkit;
using HMS.App_Code.BLL;
using HMS.Forms.BaseForms;
using HMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms.ListForms
{
    public partial class CollectionList : BaseDataGrid
    {
        DataTable dt;
        private int _id;
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        int _ScheduleID = 0;
        int ColID = -1;
        decimal t=0;
        decimal PrePaidAmount=0;
        public CollectionList()
        {
            InitializeComponent();
        }

        public CollectionList(int ScheduleID)
        {
            InitializeComponent();
            _ScheduleID = ScheduleID;
            LoadData();
            CollactionPanel.Hide();
            PanelLocationCenter();
        }

        private void PanelLocationCenter()
        {

            CollactionPanel.Location = new Point(
            this.ClientSize.Width / 2 - CollactionPanel.Size.Width / 2,
            this.ClientSize.Height / 2 - CollactionPanel.Size.Height / 2);
            CollactionPanel.Anchor = AnchorStyles.None;
        }


        private void LoadData()
        {

            DataTable dt = new bllTestWithSchedule().GetPatientServiceBySchedId(_ScheduleID);
            lblPatientName.Text = dt.Rows[0]["Name"].ToString();
            lblTotalFee.Text = dt.Rows[0]["PayableAmt"].ToString();
            dgvMain.Rows.Clear();
            DataTable collectionList = new bllCollection().GetCollectionByScheduleID(_ScheduleID);
            foreach (DataRow dr in collectionList.Rows)
            {
                int RowNum = dgvMain.Rows.Add(
                    new object[]
                        {
                            dr["CollId"],
                            dr["ScheduleId"],
                            dr["PaidAmount"],
                            dr["CollectionType"],
                            dr["FullName"],
                            dr["Date"]

                        });
                dgvMain.Rows[RowNum].Tag = dr["CollId"].ToString();
            }
            t = dgvMain.Rows.Cast<DataGridViewRow>()
                                  .AsEnumerable()
                                  .Sum(x => decimal.Parse(x.Cells[2].Value.ToString()));
            if (Convert.ToDecimal(lblTotalFee.Text) <= t)
            {
                btnTest.Enabled = false;
            }
            else
            {
                btnTest.Enabled = true;
            }
            managePaging();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            CollactionPanel.Show();
            btnClose.Enabled = false;
        }

        private void btnCollectionCancel_Click(object sender, EventArgs e)
        {
            CollactionPanel.Hide();
            btnClose.Enabled = true;
        }

        private void btnCollectionSave_Click(object sender, EventArgs e)
        {
            if (ColID>0)
            {
                CollectionUpdate();
            }
            else
            {

                CollectionEntry();
            }
        }

        private void CollectionEntry()
        {
            if (tbxPaidAmount.Text == "" || tbxPaidAmount.Text == "0")
            {
                KryptonMessageBox.Show("Paid Amount can not be empty", "Collection Entry", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            else if ((Convert.ToDecimal(tbxPaidAmount.Text) + t) > Convert.ToDecimal(lblTotalFee.Text))
            {
                KryptonMessageBox.Show("Paid Amount can not be larger than total amount", "Collection Entry", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                tbxPaidAmount.Focus();
                return;
            }
            int success = new bllCollection().Insert(new Collection(0, _ScheduleID, Convert.ToDecimal(tbxPaidAmount.Text), false, 0, HMS.Properties.Settings.Default.UserName, DateTime.Now));
            if (success > 0)
            {
                KryptonMessageBox.Show("Collection Succesfully enterd", "Collection Entry", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                tbxPaidAmount.Text = "";
                CollactionPanel.Hide();
                btnClose.Enabled = true;
                LoadData();
            }
            else
            {
                KryptonMessageBox.Show("Collection Entry Fail !", "Collection Entry", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void CollectionUpdate()
        {
            if (tbxPaidAmount.Text == "" || tbxPaidAmount.Text == "0")
            {
                KryptonMessageBox.Show("Paid Amount can not be empty", "Collection Entry", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            else if ((Convert.ToDecimal(tbxPaidAmount.Text) + (t-PrePaidAmount)) > Convert.ToDecimal(lblTotalFee.Text))
            {
                KryptonMessageBox.Show("Paid Amount can not be larger than total amount", "Collection Entry", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                tbxPaidAmount.Focus();
                return;
            }
            int success = new bllCollection().Update(new Collection(ColID, _ScheduleID, Convert.ToDecimal(tbxPaidAmount.Text), false, 0, HMS.Properties.Settings.Default.UserName, DateTime.Now));
            if (success > 0)
            {
                KryptonMessageBox.Show("Collection Succesfully Updated", "Collection Update", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                tbxPaidAmount.Text = "";
                CollactionPanel.Hide();
                btnClose.Enabled = true;
                btnCollectionSave.Text = "Save";
                ColID = -1;
                LoadData();
            }
            else
            {
                KryptonMessageBox.Show("Collection Entry Fail !", "Collection Entry", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void tbxPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && tbxPaidAmount.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CollactionPanel.Show();
            btnClose.Enabled = false;
            btnCollectionSave.Text = "Update";
            PrePaidAmount=Convert.ToDecimal( dgvMain.SelectedRows[0].Cells[2].Value);
            tbxPaidAmount.Text = PrePaidAmount.ToString();
            ColID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value);
        }
    }
}
