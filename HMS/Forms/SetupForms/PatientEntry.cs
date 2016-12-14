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
using System.IO;
using HMS.App_Code.BLL;
using ComponentFactory.Krypton.Toolkit;
using System.Text.RegularExpressions;
using HMS.App_Code.BLL;
using HMS.BLL;
using Microsoft.SqlServer.Management.Smo;

namespace HMS.Forms.SetupForms
{
    public partial class PatientEntry : BaseGeneralSetup
    {
        private string sourceImagePath;
        private bool pictureLoded=false;
        private DataTable ConsultantList;
        string ImagePath;
        public PatientEntry()
        {
            InitializeComponent();
            LoadConsultants();
            tbxPatientCode.Text = new bllCommon().RandomDigits(10).ToString();
        }
        private readonly int _ID;
   private  string _entryOption;
        public PatientEntry(string entryOption)
        {
            InitializeComponent();
            _entryOption = entryOption;
            LoadConsultants();
            tbxPatientCode.Text = new bllCommon().RandomDigits(10).ToString();
            
        }
        public PatientEntry(int ID, PatientForm patientForm = PatientForm.Edit)
        {
            InitializeComponent();
            LoadConsultants();
            _ID = ID;
            if (ID == 0)
            {
                hdrBaseCaption.Text = "Add Patient";

            }
            else if (patientForm != PatientForm.View && ID > 0)
            {
                LoadPatient();
                hdrBaseCaption.Text = "Edit Patient Details";
                btnSave.Text = "Update";
            }
            if (patientForm == PatientForm.View)
            {
                LoadPatient();
                btnSave.Visible = false;
                hdrBaseCaption.Text = "Patient Details";

            }
        }
        private void LoadConsultants()
        {
            ConsultantList = new bllConsultant().GetAllConsultantList();
            if (ConsultantList.Rows.Count > 0)
            {
                DataRow dr = ConsultantList.NewRow(); //Create New Row
                dr["ConsultantName"] = "Select";              // Set Column Value
                dr["ConsultantId"] = "0";
                ConsultantList.Rows.InsertAt(dr, 0);
                ConsultantList.DefaultView.Sort = "ConsultantId asc";
                ddlReferByDoctor.DataSource = ConsultantList;
                ddlReferByDoctor.DisplayMember = "ConsultantName";
                ddlReferByDoctor.ValueMember = "ConsultantId";
                ddlReferByDoctor.SelectedIndex = 0;
            }
            List<string> List = new List<string>();
            List.Add("Male");
            List.Add("Female");
            ddlGender.Items.AddRange(List.ToArray());
        }



        private void LoadPatient()
        {
            DataTable dt = new dalPatient().GetByPatientID(_ID);

            if (dt.Rows.Count > 0)
            {
                tbxPatientCode.Text = dt.Rows[0]["PatientCode"].ToString();
                tbxPatientName.Text = dt.Rows[0]["Name"].ToString();
                tbxEmail.Text = dt.Rows[0]["Email"].ToString();
                tbxAddress.Text = dt.Rows[0]["Address"].ToString();
                tbxMobileNo.Text = dt.Rows[0]["MobileNo"].ToString();
                ddlGender.SelectedItem = dt.Rows[0]["Gender"].ToString();
                tbxAge.Text = dt.Rows[0]["Age"].ToString();
                ddlBloodGroup.SelectedText = dt.Rows[0]["BloodGroup"].ToString();
                ddlReferByDoctor.SelectedValue = dt.Rows[0]["RrefrById"].ToString();
                ImagePath = dt.Rows[0]["Image"].ToString();
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

        private void btnBrowse_Click(object sender, EventArgs e)
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


        void UpdateData()
        {
            try
            {
                if (tbxPatientName.Text == "")
                {
                    KryptonMessageBox.Show("Patient name must needed", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;
                }
                else if (tbxMobileNo.Text == "")
                {
                    KryptonMessageBox.Show("Patient Mobile no must needed", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;
                }
                else if (ddlGender.Text == "")
                {
                    KryptonMessageBox.Show("Gender  must needed", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;

                }
                else if (ddlReferByDoctor.SelectedIndex == 0)
                {
                    KryptonMessageBox.Show("Refer by  must needed", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;
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
                            if (File.Exists(Directory + filePath))
                            {
                                File.Delete(Directory + filePath);
                            }
                            RemovePicture();
                            filePath = "Pat-" + Guid.NewGuid() + Path.GetExtension(sourceImagePath);

                            System.IO.File.Copy(sourceImagePath, Directory + filePath, true);

                            //hc.picture = filePath;
                        }
                    }
                    int success = new bllPatient().Update(_ID, tbxPatientCode.Text, tbxPatientName.Text, tbxEmail.Text, tbxAddress.Text, tbxMobileNo.Text, Convert.ToInt32(tbxAge.Text), ddlBloodGroup.Text, filePath, ddlGender.Text, Convert.ToInt32(ddlReferByDoctor.SelectedValue));
                    if (success > 0)
                    {
                        KryptonMessageBox.Show("Patient updated successfully!", "Patient Doctor.", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Common.ClearForm(pnlBaseControlContainer);
                    }
                    else
                    {
                        KryptonMessageBox.Show("Patient updated failed!", "Patient Doctor.", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void SaveData()
        {
            //Regex emailRegex = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
            //  if (emailRegex.IsMatch(tbxEmail.Text))
            //  {
            //      KryptonMessageBox.Show("The Email you enter is not valid", "Error", MessageBoxButtons.OK,
            //           MessageBoxIcon.Error);
            //      return;
            //  }
              if(tbxPatientName.Text=="")
                {
                    KryptonMessageBox.Show("Patient name must needed", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;
                }
                else if (tbxMobileNo.Text=="")
                {
                    KryptonMessageBox.Show("Patient Mobile no must needed", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;
                }
                else if(ddlGender.Text=="")
                {
                    KryptonMessageBox.Show("Gender  must needed", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;

                }
                else if(ddlReferByDoctor.SelectedIndex == 0)
                {
                    KryptonMessageBox.Show("Refer by  must needed", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;
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
                            filePath = "Pat-" + Guid.NewGuid() + Path.GetExtension(sourceImagePath);

                            System.IO.File.Copy(sourceImagePath, Directory + filePath, true);

                            //hc.picture = filePath;
                        }
                    }
                    int success = new bllPatient().Insert(tbxPatientCode.Text,tbxPatientName.Text, tbxEmail.Text, tbxAddress.Text, tbxMobileNo.Text, Convert.ToInt32(tbxAge.Text), ddlBloodGroup.Text, filePath, ddlGender.Text, Convert.ToInt32(ddlReferByDoctor.SelectedValue));
                    if (success != -1)
                    {
                        KryptonMessageBox.Show("Patient saved successfully!", "Add Patient", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Common.ClearForm(pnlBaseControlContainer);
                    }
                    else
                    {
                        KryptonMessageBox.Show("The patient already saved!", "Add Department.", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                }
           
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
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
                pictureBox1.InitialImage = null;
                pictureLoded = false;
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           if (_entryOption == "NewPatient")
            {
                _entryOption = "";
                TestEntry frm = new TestEntry("addedNewPatient");
                frm.ShowDialog();
            }
            else
            {
                PatientEntry frm = new PatientEntry();
                frm.Close();
              // Close();
            }
        }

        private void tbxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


