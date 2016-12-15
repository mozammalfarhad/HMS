using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HMS.Forms.BaseForms;
using HMS.App_Code.BLL;
using System.Web.UI.WebControls;
using HMS.Model;

namespace HMS.Forms.SetupForms
{
    public partial class TestEntry : BaseGeneralSetup
    {
        private DataTable dt;
        private DataTable dtVacuum=new DataTable();
       
        private DataView dv;
        private DataView dvVacum;
        private string patientCode = "";
        List<string> list = new List<string>();
        List<string> listVacuum = new List<string>();
        private decimal rate;
        private decimal rateSum;
        private decimal discount;
        private decimal discountSum;
        decimal avgDiscount = 0M;
        int countDiscount = 0;
        public TestEntry()
        {
            InitializeComponent();
            dtVacuum.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("VacuumId"),
                new DataColumn("VacuumName"),
                new DataColumn("VacuumPrice"),
                new DataColumn("ServiceName"),
                new DataColumn("ServiceShortName"),
                new DataColumn("VacuumDescription"), 
                new DataColumn("ServiceId")
            });
            tbxDiscounH.Text = "0.00";
            LoadTestType();
            LoadPatient();
            LoadLaboratorist();
            LoadConsultants();
            this.RcvTime.CustomFormat = "hh:mm";
            this.RcvTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RcvTime.ShowUpDown = true;
            this.DeliveryTime.CustomFormat = "hh:mm";
            this.DeliveryTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryTime.ShowUpDown = true;
        }

        private string _addedNewPatient;
        public TestEntry(string addedNewPatient)
        {
            InitializeComponent();
            dtVacuum.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("VacuumId"),
                new DataColumn("VacuumName"),
                new DataColumn("VacuumPrice"),
                new DataColumn("ServiceName"),
                new DataColumn("ServiceShortName"),
                new DataColumn("VacuumDescription"), 
                new DataColumn("ServiceId")
            });
            tbxDiscounH.Text = "0.00";
            LoadTestType();
            LoadPatient();
            _addedNewPatient = addedNewPatient;
            if (addedNewPatient != "")
            {
                ddlPatient.SelectedIndex = ddlPatient.Items.Count - 1;
            }
            LoadLaboratorist();
            LoadConsultants();
            this.RcvTime.CustomFormat = "hh:mm";
            this.RcvTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RcvTime.ShowUpDown = true;
            this.DeliveryTime.CustomFormat = "hh:mm";
            this.DeliveryTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryTime.ShowUpDown = true;
        }
         #region ///Add new Test with existing for a patient
        private int _ScheduleID;
        public TestEntry(int ScheduleID,int PatientId, string option)
        {
            InitializeComponent();
            _ScheduleID = ScheduleID;

            tbxDiscounH.Text = "0.00";
            LoadTestType();
            LoadPatient();
            LoadLaboratorist();
            this.RcvTime.CustomFormat = "hh:mm";
            this.RcvTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RcvTime.ShowUpDown = true;
            this.DeliveryTime.CustomFormat = "hh:mm";
            this.DeliveryTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryTime.ShowUpDown = true;
            if (option == "AddTest")
            {
                ddlPatient.SelectedValue = PatientId;
                GetData(_ScheduleID);
            }

        }
        private void GetData( int ShedId)
        {
            DataTable dtServiceDetails = new bllTestResult().PatientServiceDetailsGetBySchedId(ShedId);
            DataTable dtService = new bllTestResult().PatientServiceGetBySchedId(ShedId);
            
            if (dtServiceDetails.Rows.Count > 0)
            {
                ddlPatient.SelectedValue = dtServiceDetails.Rows[0]["PatientId"].ToString();
              ddlLaboratorists.SelectedValue = dtServiceDetails.Rows[0]["LabtoristId"].ToString();
              RcvDate.Text = dtServiceDetails.Rows[0]["ReceiveDate"].ToString();
              RcvTime.Text = dtServiceDetails.Rows[0]["ReceiveTime"].ToString();
              DeliveryDate.Text = dtServiceDetails.Rows[0]["DeliveryDate"].ToString();
              DeliveryTime.Text = dtServiceDetails.Rows[0]["DeliveryTime"].ToString();
              tbxAmt.Text = dtServiceDetails.Rows[0]["TotalAmount"].ToString();
              tbxDiscounH.Text = dtServiceDetails.Rows[0]["DiscountH"].ToString();
              tbxDiscounR.Text = dtServiceDetails.Rows[0]["DiscountR"].ToString();
              tbxPaidAmt.Text = dtServiceDetails.Rows[0]["PaidAmount"].ToString();

                if (dtService.Rows.Count > 0)
                {
                    lstBox1.Items.Clear();
                    foreach (DataRow dr in dtService.Rows)
                    {
                        lstBox1.Items.Add(new System.Web.UI.WebControls.ListItem(dr[1].ToString(), dr[0].ToString()));
                        list.Add(dr[1].ToString());
                    }
                    lstBox1.DisplayMember = "ServiceName";
                    lstBox1.ValueMember = "ServiceId";
                    tbxSearch.Text = "";
                    foreach (object item in lstbox2.Items)
                    {
                        lstBox1.Items.Remove(item);
                    }
                }
              //  LoadVacuumEdit();
            }
        }
        private void LoadVacuumEdit()
        {
            DataView dtServiceVacuum = new bllTestResult().PatientServiceVacuumGetBySchedId(_ScheduleID).DefaultView;

            DataTable tmpDt = new DataTable();
            foreach (System.Web.UI.WebControls.ListItem litem in lstBox1.SelectedItems)
            {
                if (dtServiceVacuum.Count > 0)
                {
                    dtServiceVacuum.RowFilter = "ServiceId=" + litem.Value;
                    dtVacuum = dtServiceVacuum.ToTable().Copy();
                }

            }
            lstVacuum1.Items.Clear();
            foreach (DataRow dr in dtVacuum.Rows)
            {
                lstVacuum2.Items.Add(new System.Web.UI.WebControls.ListItem(dr[1].ToString(), dr[0].ToString()));
                listVacuum.Add(dr[1].ToString());

            }
            lstVacuum2.DisplayMember = "VacuumName";
            lstVacuum2.ValueMember = "VacuumId";
            tbxSearch.Text = "";
            foreach (object item in lstVacuum1.Items)
            {
                lstVacuum2.Items.Remove(item);
            }

        }
        #endregion
        private void btnforward_Click(object sender, EventArgs e)
        {
            if(lstBox1.SelectedItems.Count>0)
            {
                foreach (System.Web.UI.WebControls.ListItem litem in lstBox1.SelectedItems)
                {
                    lstbox2.Items.Add(new System.Web.UI.WebControls.ListItem(litem.Text, litem.Value));
                    if (dt.Rows.Count > 0)
                    {
                        dv = dt.DefaultView;
                        dv.RowFilter = "ServiceId=" + litem.Value;
                        rate = Convert.ToDecimal(dv.ToTable().Rows[0]["Rate"].ToString());
                        discount = (Convert.ToDecimal(dv.ToTable().Rows[0]["Discount"].ToString()) / 100) * rate;


                    }

                    rateSum += rate;
                    countDiscount++;
                    discountSum += discount;
                }
                LoadVacuum();
                foreach (object item in lstbox2.Items)
                {
                    lstBox1.Items.Remove(item);
                }
                tbxSearch.Text = "";
                tbxAmt.Text = rateSum.ToString();
                //avgDiscount = discountSum / countDiscount;
                //avgDiscount = Math.Round((decimal)avgDiscount, 2);
                tbxDiscounH.Text = Math.Round((decimal)discountSum, 2).ToString();
                GetFinalAmt();
            }
           
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            if (lstbox2.SelectedItems.Count>0)
            {
                foreach (System.Web.UI.WebControls.ListItem litem in lstbox2.SelectedItems)
                {
                    lstBox1.Items.Add(new System.Web.UI.WebControls.ListItem(litem.Text, litem.Value));
                    if (dt.Rows.Count > 0)
                    {
                        dv = dt.DefaultView;
                        dv.RowFilter = "ServiceId=" + litem.Value;
                        rate = Convert.ToDecimal(dv.ToTable().Rows[0]["Rate"].ToString());
                        discount = (Convert.ToDecimal(dv.ToTable().Rows[0]["Discount"].ToString()) / 100) * rate;
                    }

                    rateSum -= rate;
                    countDiscount++;
                    discountSum -= discount;
                }
                UnloadVacuum();
                foreach (object item in lstBox1.Items)
                {
                    lstbox2.Items.Remove(item);
                }
                tbxSearch.Text = "";
                tbxAmt.Text = rateSum.ToString();
                //avgDiscount = discountSum / countDiscount;
                //avgDiscount = Math.Round((decimal)avgDiscount, 2);
                tbxDiscounH.Text = Math.Round((decimal)discountSum, 2).ToString();
                GetFinalAmt();
            }
            
        }

        private void LoadTest()
        {
            if (ddlTestType.SelectedIndex > 0)
            {
                dt = new bllService().GetByTypeID(Convert.ToInt32(ddlTestType.SelectedValue));
            }
            else
            {

                dt = new bllService().GetAll();
             
            }
            lstBox1.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                lstBox1.Items.Add(new System.Web.UI.WebControls.ListItem(dr["ServiceName"].ToString() + " (" + dr["Rate"].ToString() + ")", dr["ServiceId"].ToString()));
            }
            tbxSearch.Text = "";
            foreach (object item in lstbox2.Items)
            {
                lstBox1.Items.Remove(item);
            }

        }
        private void LoadVacuum()
        {
            DataTable tmpDt = new DataTable();
            foreach (System.Web.UI.WebControls.ListItem litem in lstBox1.SelectedItems)
            {
                tmpDt = new bllVacuum().GetByServiceID(Convert.ToInt32(litem.Value));
                //dtVacuum = tmpDt.Copy();
                foreach (DataRow dr in tmpDt.Rows)
                {
                    lstVacuum2.Items.Add(new System.Web.UI.WebControls.ListItem(dr[1].ToString(), dr[0].ToString()));
                    dtVacuum.Rows.Add(dr.ItemArray);

                }
            }
             //lstVacuum1.Items.Clear();
             
            tbxSearch.Text = "";
            foreach (object item in lstVacuum1.Items)
            {
                lstVacuum2.Items.Remove(item);
            }

        }


        private void LoadAllVacuum()
        {
            DataTable tmpDt = new DataTable();
            foreach (System.Web.UI.WebControls.ListItem litem in lstBox1.Items)
            {
                tmpDt = new bllVacuum().GetByServiceID(Convert.ToInt32(litem.Value));
                //dtVacuum = tmpDt.Copy();
                foreach (DataRow dr in tmpDt.Rows)
                {
                    lstVacuum2.Items.Add(new System.Web.UI.WebControls.ListItem(dr[1].ToString(), dr[0].ToString()));
                    dtVacuum.Rows.Add(dr.ItemArray);

                }
            }
            lstVacuum1.Items.Clear();
           
            tbxSearch.Text = "";
            foreach (object item in lstVacuum1.Items)
            {
                lstVacuum2.Items.Remove(item);
            }

        }

        private void UnloadVacuum()
        {
            IEnumerable<ListItem> li = (from item in lstVacuum2.SelectedItems.Cast<ListItem>()
                                        select item).ToList();
            IEnumerable<ListItem> li2 = (from item in lstVacuum1.SelectedItems.Cast<ListItem>()
                                        select item).ToList();
            foreach (object item in li)
            {
                    listVacuum.Remove(item.ToString());                
                    lstVacuum2.Items.Remove(item);

            }
            foreach (object item2 in li2)
            {
                listVacuum.Remove(item2.ToString());
                lstVacuum1.Items.Remove(item2);

            }
            tbxSearch.Text = "";

        }

        private void LoadTestType()
        {
            DataTable dtTypeList = new bllServiceType().GetAll();
            if (dtTypeList.Rows.Count > 0)
            {
                DataRow dr = dtTypeList.NewRow();
                dr["TypeId"] = "0";
                dr["TypeName"] = "Select";
                dtTypeList.Rows.InsertAt(dr, 0);
                ddlTestType.DataSource = dtTypeList;
                ddlTestType.DisplayMember = "TypeName";
                ddlTestType.ValueMember = "TypeId";
                tbxSearch.Text = "";
                ddlTestType.SelectedIndex = 0;
            }


        }
        private void LoadLaboratorist()
        {
            DataTable dtlaboratorist = new bllConsultant().GetLaboratoristList();
            if (dtlaboratorist.Rows.Count > 0)
            {
                DataRow dr = dtlaboratorist.NewRow();
                dr["ConsultantId"] = "0";
                dr["ConsultantName"] = "Select";
                dtlaboratorist.Rows.InsertAt(dr, 0);
                ddlLaboratorists.DataSource = dtlaboratorist;
                ddlLaboratorists.DisplayMember = "ConsultantName";
                ddlLaboratorists.ValueMember = "ConsultantId";
                tbxSearch.Text = "";
                ddlLaboratorists.SelectedIndex = 0;
            }


        }
        private void LoadPatient()
         {
            ddlPatient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ddlPatient.AutoCompleteSource = AutoCompleteSource.ListItems;
            DataTable dtPatient = new bllPatient().GetAll();
            DataRow dr = dtPatient.NewRow();
            dr["PatientID"] = "0";
            dr["PatientName"] = "Select";
            dtPatient.Rows.InsertAt(dr, 0);
            ddlPatient.DataSource = dtPatient;
            ddlPatient.DisplayMember = "PatientName";
            ddlPatient.ValueMember = "PatientID";
            tbxSearch.Text = "";
            ddlPatient.SelectedIndex = 0;
            //PatientCode

        }

        private void LoadConsultants()
        {
            DataTable ConsultantList = new bllConsultant().GetAllConsultantList();
            if (ConsultantList.Rows.Count > 0)
            {
                DataRow dr = ConsultantList.NewRow(); //Create New Row
                dr["ConsultantName"] = "Select";              // Set Column Value
                dr["ConsultantId"] = "0";
                ConsultantList.Rows.InsertAt(dr, 0);
                ConsultantList.DefaultView.Sort = "ConsultantId asc";
                comReferBy.DataSource = ConsultantList;
                comReferBy.DisplayMember = "ConsultantName";
                comReferBy.ValueMember = "ConsultantId";
                comReferBy.SelectedIndex = 0;
            }
        }
        private void btnForwardAll_Click(object sender, EventArgs e)
        {

            foreach (System.Web.UI.WebControls.ListItem litem in lstBox1.Items)
            {
                lstbox2.Items.Add(new System.Web.UI.WebControls.ListItem(litem.Text, litem.Value));
                if (dt.Rows.Count > 0)
                {
                    dv = dt.DefaultView;
                    dv.RowFilter = "ServiceId=" + litem.Value;
                    rate = Convert.ToDecimal(dv.ToTable().Rows[0]["Rate"].ToString());
                    discount = (Convert.ToDecimal(dv.ToTable().Rows[0]["Discount"].ToString()) / 100) * rate;
                }

                rateSum += rate;
                countDiscount++;
                discountSum += discount;

            }
            LoadAllVacuum();
            lstBox1.Items.Clear();
            tbxSearch.Text = "";
            tbxAmt.Text = rateSum.ToString();
            //avgDiscount = discountSum / countDiscount;
            //avgDiscount = Math.Round((decimal)avgDiscount, 2);
            tbxDiscounH.Text = Math.Round((decimal)discountSum, 2).ToString();
            GetFinalAmt();
        }

        private void btnBackAll_Click(object sender, EventArgs e)
        {
            foreach (System.Web.UI.WebControls.ListItem litem in lstbox2.Items)
            {
                lstBox1.Items.Add(new System.Web.UI.WebControls.ListItem(litem.Text, litem.Value));
                if (dt.Rows.Count > 0)
                {
                    dv = dt.DefaultView;
                    dv.RowFilter = "ServiceId=" + litem.Value;
                    rate = Convert.ToDecimal(dv.ToTable().Rows[0]["Rate"].ToString());
                    discount = (Convert.ToDecimal(dv.ToTable().Rows[0]["Discount"].ToString()) / 100) * rate;
                }

                rateSum -= rate;
                countDiscount++;
                discountSum -= discount;
            }
            lstbox2.Items.Clear();
            lstVacuum1.Items.Clear();
            lstVacuum2.Items.Clear();
            tbxSearch.Text = "";
            tbxAmt.Text = rateSum.ToString();
            //avgDiscount = discountSum / countDiscount;
            //avgDiscount = Math.Round((decimal)avgDiscount, 2);
            tbxDiscounH.Text = Math.Round((decimal)discountSum, 2).ToString();
            GetFinalAmt();
        }


        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < lstBox1.Items.Count; i++)
            {
                if (lstBox1.Items[i].ToString().IndexOf(tbxSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 && tbxSearch.Text != "")
                {
                    lstBox1.SetSelected(i, true);
                }
                else
                {
                    lstBox1.SetSelected(i, false);
                }
            }
        }
        private void FindAllOfMyString(string searchString)
        {
            for (int i = 0; i < lstBox1.Items.Count; i++)
            {
                if (lstBox1.Items[i].ToString().IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0 && searchString !="")
                {
                    lstBox1.SetSelected(i, true);
                }
                else
                {
                    lstBox1.SetSelected(i, false);
                }
            }
        }

      
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxDiscounR_TextChanged(object sender, EventArgs e)
        {
            GetFinalAmt();
        }

        private void GetFinalAmt()
        {
            decimal VacuumAmt = 0M;
            decimal VacuumAmtSum = 0M;
            decimal totalAmt = Convert.ToDecimal(tbxAmt.Text.Trim() == "" ? "0.00" : tbxAmt.Text.Trim());
            decimal discountAll = 0M;
            decimal calculateDiscount = 0M;
            discountAll =  Convert.ToDecimal(tbxDiscounR.Text == "" ? "0.00" : tbxDiscounR.Text.Trim());
            calculateDiscount = (totalAmt * (discountAll / 100))+Convert.ToDecimal(tbxDiscounH.Text == "" ? "0.00" : tbxDiscounH.Text.Trim()) ;
            calculateDiscount = Math.Round((decimal)calculateDiscount, 2);
            tbxDiscountNet.Text = calculateDiscount.ToString();
            decimal netAmt = Convert.ToDecimal(tbxAmt.Text == "" ? "0.00" : tbxAmt.Text.Trim()) - Convert.ToDecimal(tbxDiscountNet.Text == "" ? "0.00" : tbxDiscountNet.Text.Trim());
            netAmt = Math.Round((decimal)netAmt, 2);

            foreach (System.Web.UI.WebControls.ListItem litem in lstVacuum2.Items)
            {
                if (dtVacuum.Rows.Count > 0)
                {
                    dvVacum = dtVacuum.DefaultView;
                    dvVacum.RowFilter = "VacuumId=" + litem.Value;
                    if (dvVacum.Count > 0)
                        VacuumAmt = Convert.ToDecimal(dvVacum.ToTable().Rows[0]["VacuumPrice"].ToString());
                }
                VacuumAmtSum += VacuumAmt;
            }
            VacuumAmtSum = Math.Round((decimal)VacuumAmtSum, 2);
            lblTestNet.Text = netAmt.ToString();
            lblVacuumNet.Text = VacuumAmtSum.ToString();
            //GetVatAmt();
            decimal grandSum = netAmt + VacuumAmtSum + GetVatAmt();
            grandSum = Math.Round((decimal)grandSum, 2);
            tbxNetAmt.Text = grandSum.ToString();
        }

        private void tbxPaidAmt_TextChanged(object sender, EventArgs e)
        {
            decimal dueAmt = Convert.ToDecimal(tbxNetAmt.Text.Trim() == "" ? "0.00" : tbxNetAmt.Text.Trim()) - Convert.ToDecimal(tbxPaidAmt.Text.Trim() == "" ? "0.00" : tbxPaidAmt.Text.Trim());
                dueAmt = Math.Round((decimal)dueAmt, 2);
                tbxDueAmt.Text = dueAmt.ToString();
        }

        private void btnVacuumFrd_Click(object sender, EventArgs e)
        {
            foreach (System.Web.UI.WebControls.ListItem litem in lstVacuum1.SelectedItems)
            {
                lstVacuum2.Items.Add(new System.Web.UI.WebControls.ListItem(litem.Text, litem.Value));

            }
            foreach (object item in lstVacuum2.Items)
            {
                lstVacuum1.Items.Remove(item);
            }
            tbxSearch.Text = "";
            GetFinalAmt();
        }

        private void btnVacuumBck_Click(object sender, EventArgs e)
        {
            foreach (System.Web.UI.WebControls.ListItem litem in lstVacuum2.SelectedItems)
            {
                lstVacuum1.Items.Add(new System.Web.UI.WebControls.ListItem(litem.Text, litem.Value));
            }
            foreach (object item in lstVacuum1.Items)
            {
                lstVacuum2.Items.Remove(item);
            }
            tbxSearch.Text = "";
            GetFinalAmt();
        }

        private void btnVacumFrdAll_Click(object sender, EventArgs e)
        {
            foreach (System.Web.UI.WebControls.ListItem litem in lstVacuum1.Items)
            {
                lstVacuum2.Items.Add(new System.Web.UI.WebControls.ListItem(litem.Text, litem.Value));

            }

            lstVacuum1.Items.Clear();
            GetFinalAmt();
           
        }

        private void btnVacuumBckAll_Click(object sender, EventArgs e)
        {
            foreach (System.Web.UI.WebControls.ListItem litem in lstVacuum2.Items)
            {
                lstVacuum1.Items.Add(new System.Web.UI.WebControls.ListItem(litem.Text, litem.Value));
            }
            lstVacuum2.Items.Clear();
            tbxSearch.Text = "";
            GetFinalAmt();
        }

        private void lstbox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstVacuum2.SelectedIndex = -1;
            lstVacuum1.SelectedIndex = -1;
            IEnumerable<int> selectedval = (from item in lstbox2.SelectedItems.Cast<ListItem>()
                                            select int.Parse(item.Value));
            foreach(var item in selectedval)
            {
                 DataTable tbl = new bllVacuum().GetByServiceID(item);
                foreach (DataRow dr in tbl.Rows)
                {
                    for (int j = 0; j < lstVacuum2.Items.Count; j++)
                    {
                        ListItem keyValuePair = (ListItem)lstVacuum2.Items[j];
                        string p = keyValuePair.Value;
                        if (p == dr["VacuumId"].ToString().Trim())
                        {
                            lstVacuum2.SetSelected(j, true);
                        }

                    }
                    for(int i = 0; i < lstVacuum1.Items.Count; i++)
                    {
                        ListItem keyValuePair1 = (ListItem)lstVacuum1.Items[i];
                        string t = keyValuePair1.Value;
                        if (t == dr["VacuumId"].ToString().Trim())
                        {
                            lstVacuum1.SetSelected(i, true);
                        }
                    }
                }   
            }
          
        }



        private DataSet makeVacuumTable()
        {
            DataSet ds = new DataSet();
            ds.DataSetName = "dsVacuums";
            DataTable dt = new DataTable();
            dt.TableName = "tblVacuums";           
            dt.Columns.Add(new DataColumn("VacuumId", typeof(int)));
            IEnumerable<int> selectedval = (from item in lstVacuum2.Items.Cast<ListItem>()
                                            select int.Parse(item.Value));
         
            foreach (var item in selectedval)
            {
                DataRow dr = dt.NewRow();
                dr["VacuumId"] = item;
                dt.Rows.Add(dr);
            }
            ds.Tables.Add(dt);  
            return ds;
        }
        private DataSet makeTestsTable()
        {
            int laboratoristId = 0;
            if (ddlLaboratorists.SelectedIndex > 0)
            {
                laboratoristId =Convert.ToInt32(ddlLaboratorists.SelectedValue);
            }
            DataSet ds = new DataSet();
            ds.DataSetName = "dsTest";
            DataTable dt = new DataTable();
            dt.TableName = "tblTest";    
            dt.Columns.Add(new DataColumn("ServiceId", typeof(int)));
            dt.Columns.Add(new DataColumn("Status", typeof(string)));
            dt.Columns.Add(new DataColumn("LabtoristId", typeof(int)));
            IEnumerable<int> selectedval = (from item in lstbox2.Items.Cast<ListItem>()
                                            select int.Parse(item.Value));
           
            foreach (var item in selectedval)
            {
                DataRow dr = dt.NewRow();
                dr["ServiceId"] = item;
                dr["Status"] = "Pending";
                dr["LabtoristId"] = laboratoristId;
                dt.Rows.Add(dr);
            }

            ds.Tables.Add(dt);
            return ds;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int patientId = 0;
          
            decimal discountR = 0;
            try
            {
                if (ddlPatient.SelectedIndex > 0)
                {
                    patientId = Convert.ToInt32(ddlPatient.SelectedValue);
                }
                else
                {
                    KryptonMessageBox.Show("Patient must be selected!", "Test Entry.", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    ddlPatient.Focus();
                    return;
                }
                if(comReferBy.SelectedIndex == 0)
                {
                    KryptonMessageBox.Show("Refer by must be selected!", "Test Entry.", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    comReferBy.Focus();
                    return;
                }
                if(lstbox2.Items.Count<=0)
                {
                    KryptonMessageBox.Show("Test must be taken!", "Test Entry.", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    lstBox1.Focus();
                    return;
                }
                if(tbxPaidAmt.Text.Trim()=="")
                {
                    KryptonMessageBox.Show("Enter paid amount!", "Paid amount.", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    tbxPaidAmt.Focus();
                    return;
                }
                DataSet vacumData = makeVacuumTable();
                DataSet testsData = makeTestsTable();

                TimeSpan Rcvtime = TimeSpan.Parse(RcvTime.Text);
                TimeSpan Deliverytime = TimeSpan.Parse(DeliveryTime.Text);
                if (tbxDiscounR.Text.Trim() != "")
                    discountR = Math.Round((decimal)(Convert.ToDecimal(tbxAmt.Text) * (Convert.ToDecimal(tbxDiscounR.Text.Trim()) / 100)), 2);

             



                  string username=  HMS.Properties.Settings.Default.UserName;
                  decimal vacuumAmt = Convert.ToDecimal(lblVacuumNet.Text);
                  decimal vatAmt =  Convert.ToDecimal(tbxVatAmt.Text);
                int success = new bllTestWithSchedule().InsertTest_Schedule_vacuum(vacumData, patientId,
                    Convert.ToDateTime(RcvDate.Text),
                   Rcvtime,
                    Convert.ToDateTime(DeliveryDate.Text),
                    Deliverytime, Convert.ToDecimal(tbxAmt.Text.Trim()), discountR, Convert.ToDecimal(tbxDiscounH.Text.Trim()), Convert.ToDecimal(tbxPaidAmt.Text.Trim()), testsData, username, vatAmt, vacuumAmt,Convert.ToInt32(comReferBy.SelectedValue));

                //if (success > 0)
                //{
                    KryptonMessageBox.Show("Test inserted successfully!", "Test Entry.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    //Common.ClearForm(pnlBaseControlContainer);
                    ClearForm();
               
                   
                //}
                //else
                //{
                //    KryptonMessageBox.Show("Test inserted failed!", "Test Entry.", MessageBoxButtons.OK,
                //       MessageBoxIcon.Error);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ClearForm()
        {
            ddlLaboratorists.SelectedIndex = 0;
            ddlPatient.SelectedIndex = 0;
            comReferBy.SelectedIndex = 0;
            lstbox2.Items.Clear();
            lstVacuum2.Items.Clear();
            lstVacuum1.Items.Clear();
            LoadTest();
            tbxAmt.Text = "";
            tbxDiscounH.Text = "0.00";
            tbxDiscounR.Text = "";
            tbxDiscountNet.Text = "";
            tbxDueAmt.Text = "";
            tbxNetAmt.Text = "";
            tbxPaidAmt.Text = "";
            tbxSearch.Text = "";
            tbxVatAmt.Text = "";
            lblTestNet.Text = "0";
            lblVacuumNet.Text = "0";
        }

        private decimal GetVatAmt()
        {
            decimal vatPercent = 0;
            DataTable dtVat = new bllVat().GetVatPercent();
            if (dtVat.Rows.Count > 0)
            {
                vatPercent = Convert.ToDecimal(dtVat.Rows[0]["VatPercent"].ToString());
            }
            decimal amt = Convert.ToDecimal(tbxAmt.Text);
            decimal vacuumAmt = Convert.ToDecimal(lblVacuumNet.Text);
            decimal DicountAmt = Convert.ToDecimal(tbxDiscountNet.Text);
            decimal AmtRaw = (amt + vacuumAmt) - DicountAmt;
           decimal vatAmt = (AmtRaw*(vatPercent/100));
           vatAmt = Math.Round((decimal)vatAmt, 2);
            tbxVatAmt.Text = vatAmt.ToString();
            return vatAmt;
        }

        private void ddlTestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTest();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (_addedNewPatient != "")
            {
                if (ddlPatient.Items.Count > 0)
                    ddlPatient.SelectedIndex = ddlPatient.Items.Count - 1;
                else
                {
                    LoadPatient();
                    ddlPatient.SelectedIndex = ddlPatient.Items.Count - 1;
                }
            }
            PatientEntry frm = new PatientEntry("NewPatient");
            frm.ShowDialog();
        }

        private void ddlPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlPatient.SelectedIndex>0)
            {
                DataTable dtpa = new bllPatient().GetByID(Convert.ToInt32(ddlPatient.SelectedValue));
                comReferBy.SelectedValue = dtpa.Rows[0]["RrefrById"].ToString();

            }
        }

        private void tbxPaidAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && tbxPaidAmt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }


    }
}

