using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.Forms.BaseForms;
using HMS.App_Code.BLL;
using ComponentFactory.Krypton.Toolkit;
using System.IO;
using HMS.BLL;

namespace HMS.Forms.SetupForms
{
    public partial class ConsultantEntry : BaseGeneralSetup
    {
        private string sourceImagePath;
        private bool pictureLoded = false;
        private DataTable depList;
        string ImagePath;
        private DataView dvCode;
        private readonly int _ID;
        public ConsultantEntry()
        {
            InitializeComponent();
            tbxDoctorCode.ReadOnly = true;
            LoadDepAndGender();
            LoadConsultantType();
            tbxDoctorCode.Text =new bllCommon().RandomDigits(10).ToString();
            dvCode = new bllConsultant().GetAllCode().DefaultView;
            dvCode.RowFilter = "ConsultantCode='" + tbxDoctorCode.Text.Trim()+"'";
            if (dvCode.Count > 0)
            {
                tbxDoctorCode.Text = new bllCommon().RandomDigits(10).ToString();
            }
        }
     
        private void LoadDepAndGender()
        {
            depList = new bllDepartment().GetAllList();
            DataRow dr = depList.NewRow(); 
            dr["DepName"] = "Select";            
            dr["DepId"] = "0";
            depList.Rows.InsertAt(dr, 0);
            depList.DefaultView.Sort = "DepId asc";
            ddlDepartment.ValueMember = "DepId";
            ddlDepartment.DisplayMember = "DepName";
            ddlDepartment.DataSource = depList;
            ddlDepartment.SelectedIndex = 0;
        }
        private void LoadConsultantType()
        {
           DataTable depList = new bllConsultantType().GetAllConsultantTypeList();
            DataRow dr = depList.NewRow();
            dr["ConsultantTypeName"] = "Select";
            dr["ConsultantTypeId"] = "0";
            depList.Rows.InsertAt(dr, 0);
            depList.DefaultView.Sort = "ConsultantTypeId asc";
            ddlType.ValueMember = "ConsultantTypeId";
            ddlType.DisplayMember = "ConsultantTypeName";
            ddlType.DataSource = depList;
            ddlType.SelectedIndex = 0;
        }

        public ConsultantEntry(int ID, ConsultantForm consultantForm = ConsultantForm.Edit)
        {
            InitializeComponent();
            tbxDoctorCode.ReadOnly = true;
            LoadDepAndGender();
            LoadConsultantType();
            _ID = ID;
            if (ID == 0)
            {
                hdrBaseCaption.Text = "Add " + ddlType.Text;

            }
            else if (consultantForm != ConsultantForm.View && ID > 0)
            {
                LoadConsultant();
                hdrBaseCaption.Text = "Edit " + ddlType.Text + " Details";
                btnSave.Text = "Update";
            }
            if (consultantForm == ConsultantForm.View)
            {
                LoadConsultant();
                btnSave.Visible = false;
                hdrBaseCaption.Text = ddlType.Text +" Details";

            }
        }

        private void LoadConsultant()
        {
            DataTable dt = new bllConsultant().GetByID(_ID);

            if (dt.Rows.Count > 0)
            {
                tbxDoctorCode.Text = dt.Rows[0]["ConsultantCode"].ToString();
                tbxDoctorName.Text = dt.Rows[0]["ConsultantName"].ToString();
                tbxEmail.Text = dt.Rows[0]["ConsultantEmail"].ToString();
                tbxAddress.Text = dt.Rows[0]["ConsultantAddress"].ToString();
                tbxMobileNo.Text = dt.Rows[0]["ConsultantMobileNo"].ToString();
                ddlDepartment.SelectedValue = dt.Rows[0]["ConsultantDepartmentId"].ToString();
                ddlGender.SelectedItem = dt.Rows[0]["ConsultantGender"].ToString();
                tbxQualification.Text = dt.Rows[0]["ConsultantQualification"].ToString();
                ddlType.SelectedValue = dt.Rows[0]["ConsultantTypeId"].ToString();
                ImagePath = dt.Rows[0]["ConsultantImage"].ToString();
                if (ImagePath != "")
                    LoadIamge(ImagePath);
            }
        }

        private void LoadIamge(string path)
        {
            string Directory = Application.StartupPath + @"\Images\" + path;
            Image image;

            using (Stream stream = File.OpenRead(Directory))
            {
                image = System.Drawing.Image.FromStream(stream);
            }
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
                pictureBox1.InitialImage = null;
            }

            pictureBox1.Image = new Bitmap(image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        void SaveData()
        {

            try
            {
                if (tbxDoctorName.Text == "")
                {
                    KryptonMessageBox.Show("Consultant Name must be needed!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ddlGender.Text == "")
                {
                    KryptonMessageBox.Show("Consultant must needed", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ddlType.Text == "")
                {
                    KryptonMessageBox.Show("Consultant Type must needed", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    string filePath = "";
                    if (pictureLoded)
                    {
                        string Directory = Application.StartupPath + @"\Images\";

                        if (File.Exists(sourceImagePath))
                        {
                            System.GC.Collect();
                            System.GC.WaitForPendingFinalizers();
                            //if (File.Exists(Directory + hc.picture))
                            //{
                            //    File.Delete(Directory + hc.picture);
                            //}
                            RemovePicture();
                            filePath = ddlType.Text +"-" + Guid.NewGuid() + Path.GetExtension(sourceImagePath);

                            System.IO.File.Copy(sourceImagePath, Directory + filePath, true);

                            //hc.picture = filePath;
                        }
                    }
                    int success = new bllConsultant().Insert(tbxDoctorName.Text, tbxEmail.Text, tbxAddress.Text, tbxMobileNo.Text, Convert.ToInt32(ddlDepartment.SelectedValue), filePath, tbxQualification.Text, ddlGender.Text,Convert.ToInt32(ddlType.SelectedValue));
                    if (success > 0)
                    {
                        KryptonMessageBox.Show("Consultant saved successfully!", "Add Consultant.", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Common.ClearForm(pnlBaseControlContainer);
                    }
                    else
                    {
                        KryptonMessageBox.Show("Consultant saved failed!", "Add Consultant.", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                }
              
            }
            catch (Exception ex)
            {


            }
        }


        void UpdateData()
        {
            try
            {
               if (tbxDoctorName.Text == "")
                {
                    KryptonMessageBox.Show("Consultant Name must be needed!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
               else if (ddlGender.Text == "")
               {
                   KryptonMessageBox.Show("Consultant must needed", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
               }
               else if (ddlType.Text == "")
               {
                   KryptonMessageBox.Show("Consultant Type must needed", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
               }
               else
               {
                   string filePath = ImagePath;
                   if (pictureLoded)
                   {
                       string Directory = Application.StartupPath + @"\Images\";

                       if (File.Exists(sourceImagePath))
                       {
                           System.GC.Collect();
                           System.GC.WaitForPendingFinalizers();
                           //if (File.Exists(Directory + filePath))
                           //{
                           //    File.Delete(Directory + filePath);
                           //}
                           RemovePicture();
                           filePath = ddlType.Text +"-" + Guid.NewGuid() + Path.GetExtension(sourceImagePath);

                           System.IO.File.Copy(sourceImagePath, Directory + filePath, true);

                           //hc.picture = filePath;
                       }
                   }
                   int success = new bllConsultant().Update(_ID, tbxDoctorCode.Text, tbxDoctorName.Text, tbxEmail.Text, tbxAddress.Text, tbxMobileNo.Text, Convert.ToInt32(ddlDepartment.SelectedValue), filePath, tbxQualification.Text, ddlGender.Text,Convert.ToInt32(ddlType.SelectedValue));
                   if (success > 0)
                   {
                       KryptonMessageBox.Show("Consult updated successfully!", "Update Consult.", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                       Common.ClearForm(pnlBaseControlContainer);
                   }
                   else
                   {
                       KryptonMessageBox.Show("Consult updated failed!", "Update Consult.", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                   }
               }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
            }
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Jpg(*Jpg)|*.jpg| Png(*Png)|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    sourceImagePath = dlg.FileName;

                    Image image;

                    using (Stream stream = File.OpenRead(sourceImagePath))
                    {
                        image = System.Drawing.Image.FromStream(stream);
                    }

                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                        pictureBox1.InitialImage = null;
                    }

                    pictureBox1.Image = new Bitmap(image);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                pictureLoded = true;
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            RemovePicture();
        }

        private void RemovePicture()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
                pictureBox1.InitialImage = null;
            }
        }

        private void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlType.SelectedIndex > 0)
            {
                lblCode.Text = ddlType.Text + ' ' + "Code";
                lblName.Text = ddlType.Text + ' ' + "Name";
            }

        }
    }
}
