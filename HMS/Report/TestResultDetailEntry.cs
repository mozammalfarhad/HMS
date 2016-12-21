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

namespace HMS.Report
{
    public partial class TestResultDetailEntry : KryptonForm
    {
        public TestResultDetailEntry()
        {
            InitializeComponent(); 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private int _SheduleId;
        private int _ServiceId;
        private int _TestId;
        private int _PatientID;
        private string _option;
        public TestResultDetailEntry(int TestId, int ShedId, int ServiceId, int PatientID, string option)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            _SheduleId = ShedId;
            _ServiceId = ServiceId;
            _TestId = TestId;
            _option = option;
            if (option == "Entry")
            {

                LoadData(TestId, ShedId, ServiceId, PatientID);
            }
            else if(option=="Edit")
            {
                GetData(TestId, ShedId, ServiceId);
            }
            else
            {
               
                hdrBaseCaption.Text = "Test Sample Entry";
                DataTable dtResult = new bllTestResult().GetTestById(_TestId);
                if (dtResult.Rows.Count > 0)
                {
                    lblTestName.Text = dtResult.Rows[0]["ServiceName"].ToString();
                    tbxsample.Text = dtResult.Rows[0]["Samples"].ToString();
                    dgvAttribute.Visible = false;
                    lblNormalRangeM.Visible = false;
                    lblUnitM.Visible = false;
                    tbxTestResult.Visible = false;
                    lblNRCaption.Visible = false;
                    lblResultCaption.Visible = false;
                    lblResultUnit.Visible = false;
                }
               
            }
          
        }

        private void GetData(int TestId, int ShedId, int ServiceId)
        {
            string sex = "";
            string NormalRange = "";
            DataTable dtResult = new bllTestResult().GetTestResultGetWithAttribute(_TestId, _SheduleId, _ServiceId);
          

            if (dtResult.Rows.Count > 0)
            {
                DataTable dtService = new bllService().GetByID(_ServiceId);
                string HasAttribute = dtResult.Rows[0]["HasAttribute"].ToString();
                if (HasAttribute == "WithAttribute")
                {
                    dgvAttribute.Visible = true;
                    lblNormalRangeM.Visible = false;

                    lblUnitM.Visible = false;
                    tbxTestResult.Visible = false;
                    lblNRCaption.Visible = false;
                    lblResultCaption.Visible = false;
                    lblResultUnit.Visible = false;
                    lblTestName.Text = dtService.Rows[0]["ServiceName"].ToString();
                    dgvAttribute.Rows.Clear();
                    foreach (DataRow dr in dtResult.Rows)
                    {
                        if (sex == "Male")
                        {
                            NormalRange = dr["MaleNormalRange"].ToString() + " " + dr["UnitName"].ToString();
                        }
                        else
                        {
                            NormalRange = dr["FemaleNormalRange"].ToString() + " " + dr["UnitName"].ToString();
                        }
                        lblResultUnit.Text = dr["UnitName"].ToString();
                        int RowNum = dgvAttribute.Rows.Add(
                            new object[]
                            {
                                ShedId,
                                TestId,
                                ServiceId,
                                dr["AttributeId"],
                                dr["AttributeName"],
                                dr["Result"],
                                NormalRange
                            });

                        dgvAttribute.Rows[RowNum].Tag = ShedId;
                        dgvAttribute.AllowUserToAddRows = false;
                    }
                }
                else
                {
                    dgvAttribute.Visible = false;
                    lblTestName.Text = dtResult.Rows[0]["ServiceName"].ToString();
                    tbxTestResult.Text = dtResult.Rows[0]["Result"].ToString();
                    lblNormalRangeM.Visible = true;
                    lblUnitM.Visible = true;
                    tbxTestResult.Visible = true;
                    lblNRCaption.Visible = true;
                    lblResultCaption.Visible = true;
                    lblResultUnit.Visible = true;
                    if (sex == "Male")
                    {
                        lblNormalRangeM.Text = dtResult.Rows[0]["MaleNormalRange"].ToString();
                        lblUnitM.Text = dtResult.Rows[0]["UnitName"].ToString();
                    }
                    else
                    {
                        lblNormalRangeM.Text = dtResult.Rows[0]["FemaleNormalRange"].ToString();
                        lblUnitM.Text = dtResult.Rows[0]["UnitName"].ToString();
                    }
                }
            }
            DataTable dtResults = new bllTestResult().GetTestById(_TestId);
            if (dtResults.Rows.Count > 0)
            {
                lblTestName.Text = dtResults.Rows[0]["ServiceName"].ToString();
                tbxsample.Text = dtResults.Rows[0]["Samples"].ToString();
            }
        }

        private void LoadData(int TestId, int ShedId, int ServiceId, int PatientID)
        {
            string sex = "";
            string NormalRange = "";
            _PatientID = PatientID;
            DataTable dtPatient = new bllPatient().GetByID(_PatientID);
            if (dtPatient.Rows.Count > 0)
            {
                sex = dtPatient.Rows[0]["Gender"].ToString();
            }
            DataTable dtService = new bllService().GetByID(ServiceId);
            if (dtService.Rows.Count > 0)
            {
                lblTestName.Text = dtService.Rows[0]["ServiceName"].ToString();
                lblNormalRangeM.Visible = true;
                lblUnitM.Visible = true;
                tbxTestResult.Visible = true;
                lblNRCaption.Visible = true;
                lblResultCaption.Visible = true;
                lblResultUnit.Visible = true;
                lblResultUnit.Text = dtService.Rows[0]["UnitName"].ToString();
                if (sex == "Male")
                {
                    lblNormalRangeM.Text = dtService.Rows[0]["MaleNormalRange"].ToString();
                    lblUnitM.Text = dtService.Rows[0]["UnitName"].ToString();
                }
                else
                {
                    lblNormalRangeM.Text = dtService.Rows[0]["FemaleNormalRange"].ToString();
                    lblUnitM.Text = dtService.Rows[0]["UnitName"].ToString();
                }
            }
            DataTable dtServiceAttribute = new bllServiceAttribute().GetByServiceID(ServiceId);
            if (dtServiceAttribute.Rows.Count > 0)
            {
                dgvAttribute.Visible = true;
                lblNormalRangeM.Visible = false;

                lblUnitM.Visible = false;
                tbxTestResult.Visible = false;
                lblNRCaption.Visible = false;
                lblResultCaption.Visible = false;
                lblResultUnit.Visible = false;
                dgvAttribute.Rows.Clear();
                foreach (DataRow dr in dtServiceAttribute.Rows)
                {
                    if (sex == "Male")
                    {
                        NormalRange = dr["MaleNormalRange"].ToString() + " " + dr["UnitName"].ToString();
                    }
                    else
                    {
                        NormalRange = dr["FemaleNormalRange"].ToString() + " " + dr["UnitName"].ToString();
                    }
                    lblResultUnit.Text = dr["UnitName"].ToString();
                    int RowNum = dgvAttribute.Rows.Add(
                        new object[]
                        {
                            ShedId,
                            TestId,
                            ServiceId,
                            dr["SerAtId"],
                            dr["AttributeName"],
                            "0.00",
                            NormalRange
                        });

                    dgvAttribute.Rows[RowNum].Tag = ShedId;
                    dgvAttribute.AllowUserToAddRows = false;
                }
            }
            else
            {
                dgvAttribute.Visible = false;
            }
            DataTable dtResult = new bllTestResult().GetTestById(_TestId);
            if (dtResult.Rows.Count > 0)
            {
                lblTestName.Text = dtResult.Rows[0]["ServiceName"].ToString();
                tbxsample.Text = dtResult.Rows[0]["Samples"].ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_option == "Entry" || _option == "Edit")
            {

                this.Hide();
                TestResultEntry frm = new TestResultEntry(_SheduleId);
                frm.ShowDialog();
            }
            else
            {

                Close();
            }
        }
        private DataSet makeTestAttributeResultsTable()
        {

            DataSet ds = new DataSet();
            ds.DataSetName = "dsTestResultAttribute";
            DataTable dt = new DataTable();
            dt.TableName = "tblTestResultAttribute";
            dt.Columns.Add(new DataColumn("TestId", typeof(int)));
            dt.Columns.Add(new DataColumn("AttributeId", typeof(int)));
            dt.Columns.Add(new DataColumn("Result", typeof(string)));
            for (int i = 0; i < dgvAttribute.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["TestId"] = dgvAttribute.Rows[i].Cells[1].Value.ToString();
                dr["AttributeId"] = dgvAttribute.Rows[i].Cells[3].Value.ToString();
                dr["Result"] = dgvAttribute.Rows[i].Cells[5].Value.ToString();
                dt.Rows.Add(dr);
            }

            ds.Tables.Add(dt);
            return ds;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvAttribute.Rows.Count <= 1 && tbxTestResult.Text == "" && tbxsample.Text != "")
                {
                    int success = new bllTestResult().InsertTestSample(tbxsample.Text.Trim(), _SheduleId, _ServiceId);
                    if (success > 0)
                    {
                        KryptonMessageBox.Show("Sample inserted successfully!", "Result Entry.", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                        Common.ClearForm(kryptonPanel1);
                    }
                    else
                    {
                        KryptonMessageBox.Show("Sample inserted failed!", "Result Entry.", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    }
                }
                else if (dgvAttribute.Rows.Count > 0 && tbxTestResult.Text == "")
                {
                    if (tbxsample.Text != "")
                    {
                        int Successresult = new bllTestResult().InsertTestSample(tbxsample.Text.Trim(), _SheduleId, _ServiceId);
                       
                    }
                      
                    DataSet ds = makeTestAttributeResultsTable();
                    int success = new bllTestResultAttribute().InsertUpdateTestResultAttribute(ds);
                    if (success > 0)
                    {
                        KryptonMessageBox.Show("Result inserted successfully!", "Result Entry.", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                        Common.ClearForm(kryptonPanel1);
                    }
                    else
                    {
                        KryptonMessageBox.Show("Result inserted failed!", "Result Entry.", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string result = "";
                    if (tbxTestResult.Text != "")
                    {
                        result = tbxTestResult.Text;
                    }
                    else
                    {
                        KryptonMessageBox.Show("Please input Result!", "Result Entry.", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                        tbxTestResult.Focus();
                        return;
                    }
                    if (tbxsample.Text != "")
                    {
                        int Successresult = new bllTestResult().InsertTestSample(tbxsample.Text.Trim(), _SheduleId, _ServiceId);

                    }
                    int success = new bllTestResult().InsertTestResult(result, "Entered", _SheduleId, _ServiceId);
                    if (success > 0)
                    {
                        KryptonMessageBox.Show("Result inserted successfully!", "Result Entry.", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                        Common.ClearForm(kryptonPanel1);
                    }
                    else
                    {
                        KryptonMessageBox.Show("Result inserted failed!", "Result Entry.", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    }
                }
                this.Hide();
                TestResultEntry frm=new TestResultEntry(_SheduleId);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
            }
        }

    }
}
