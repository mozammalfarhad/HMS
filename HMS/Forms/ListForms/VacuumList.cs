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
using HMS.Forms.SetupForms;

namespace HMS.Forms.ListForms
{
    public partial class VacuumList : BaseDataGrid
    {
        string UserName;
        bllVacuum objVacuum = new bllVacuum();
        int CurrentPage = 0;
        int TotalRec = 0;
        int PageSize = 30;
        private AutoCompleteStringCollection namesCollection;
        DataTable dtData;
        DataTable pdfDt = new DataTable();
        string pdfFileName = string.Empty;
        public VacuumList()
        {
            InitializeComponent();
            BindData();
            LoadService();
        }
        protected void BindData()
        {
            try
            {
                var Criteria = GetCriteria();

                DataTable dt = objVacuum.GetList(CurrentPage * PageSize, PageSize, Criteria, false);
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
                        dr["VacuumId"],
                        dr["ServiceId"],   
                        dr["ServiceName"],
                        dr["VacuumName"],    
                        dr["VacuumDescription"],
                        dr["VacuumPrice"]
                    });

                    dgvMain.Rows[RowNum].Tag = dr["VacuumId"];
                }




                ChangeDataGridHeader();
                managePaging();
            }
            catch (Exception ex)
            {
            }
        }
        private void LoadService()
        {
            DataTable dt = new DataTable();
            

                dt = new bllService().GetAll();
            
            DataRow dr = dt.NewRow();
            dr["ServiceId"] = "0";
            dr["ServiceName"] = "Select";
            dt.Rows.InsertAt(dr, 0);
            dt.DefaultView.Sort = "ServiceId asc";
            ddlService.DataSource = dt;
            ddlService.DisplayMember = "ServiceName";
            ddlService.ValueMember = "ServiceId";
            ddlService.SelectedIndex = 0;

        }
        private string GetCriteria()
        {
            string Criteria = "";
            if (tbxSearch.Text.Trim() != "")
            {
                Criteria = "(VacuumName like '%" + tbxSearch.Text.Trim() + "%')";
            }
            if (ddlService.SelectedIndex != -1 && Convert.ToInt32(ddlService.SelectedValue) != 0)
            {
                Criteria = "";
                if (Criteria == "")
                    Criteria = "ServiceId=" + ddlService.SelectedValue;
                else
                    Criteria += " And ServiceId=" + ddlService.SelectedValue;

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
            dgvMain.Columns["VacuumId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
           dgvMain.Columns["ServiceId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
           dgvMain.Columns["ServiceName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["VacuumName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["VacuumDescription"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns["VacuumPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMain.Rows.Count == 0 || dgvMain.SelectedRows.Count == 0)
            {
                KryptonMessageBox.Show("Select A Vacuum", "Vacuum List.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //int ID = int.Parse(dgvMain.CurrentRow.Cells[0].Value.ToString());
            //VacuumEntry meX = new VacuumEntry(ID);
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
            //VacuumEntry meX = new VacuumEntry(ID, VacuumForm.View);
            //meX.ShowDialog();
        }


        private void btnSearchTop_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ddlService_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
