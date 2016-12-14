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
using HMS.Forms.BaseForms;
using HMS.App_Code.BLL;
using HMS.Forms.SetupForms;

namespace HMS.Forms.ListForms
{
    public partial class ServiceTypeList : BaseDataGrid
    {
        string UserName;
        bllServiceType objServiceType = new bllServiceType();
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        private AutoCompleteStringCollection namesCollection;
        DataTable dtServiceType = new DataTable();
        DataTable dtData;
        DataTable pdfDt = new DataTable();
        string pdfFileName = string.Empty;
        public ServiceTypeList()
        {
            InitializeComponent();
            BindData();
        }
        protected void BindData()
        {
            try
            {
                var Criteria = GetCriteria();

                DataTable dt = objServiceType.GetList(CurrentPage * PageSize, PageSize, Criteria, false);
                dtData = new DataTable();
                dtData = dt;
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
                        dr["TypeId"],
                        dr["TypeName"]
                    });

                    dgvMain.Rows[RowNum].Tag = dr["TypeId"];
                }




                ChangeDataGridHeader();
                managePaging();
                tbxSearch.Focus();
            }
            catch (Exception ex)
            {
            }
        }
        private string GetCriteria()
        {
            string Criteria = "";
            if (tbxSearch.Text.Trim() != "")
            {
                Criteria = "(TypeName like '%" + tbxSearch.Text.Trim() + "%')";
            }
           
            return Criteria;
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
            dgvMain.Columns["TypeName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["TypeId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMain.Rows.Count == 0 || dgvMain.SelectedRows.Count == 0)
            {
                KryptonMessageBox.Show("Select A Service Type", "Service Type List.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //int ID = int.Parse(dgvMain.CurrentRow.Cells[0].Value.ToString());
            //ServiceTypeEntry meX = new ServiceTypeEntry(ID);
            //DialogResult dr = meX.ShowDialog();
            //ddlPage.Items.Clear();
            //if (dr == DialogResult.Yes)
            //{
            //    BindData();
            //}
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }


        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value); ;
            //ServiceTypeEntry meX = new ServiceTypeEntry(ID, ServiceTypeForm.View);
            //meX.ShowDialog();
        }


        private void btnSearchTop_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            bool isMatch = false;
            if (tbxSearch.Text.Length == 0)
            {
                listBox1.Visible = false;
                return;
            }

            foreach (String s in tbxSearch.AutoCompleteCustomSource)
            {
                if (s.Contains(tbxSearch.Text))
                {
                    listBox1.Items.Add(s);
                    listBox1.Visible = true;
                    isMatch = true;
                }
            }
            if (!isMatch)
                listBox1.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
