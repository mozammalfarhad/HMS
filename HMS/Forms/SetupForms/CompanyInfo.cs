using ComponentFactory.Krypton.Toolkit;
using HMS.App_Code.BLL;
using HMS.Forms.BaseForms;
using HMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms.SetupForms
{
    public partial class CompanyInfo : BaseGeneralSetup
    {
        private string sourceImagePath;
        private bool pictureLoded = false;
        private DataTable ConsultantList;
        string ImagePath;
        private int _ID;
        public CompanyInfo()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new bllCompanyInfo().GetCompanyInfo();
            if (dt.Rows.Count > 0)
            {
                tbxCompanyName.Text = dt.Rows[0]["ComapayName"].ToString();
                tbxAddress.Text = dt.Rows[0]["Address"].ToString();
                tbxFax.Text = dt.Rows[0]["Fax"].ToString();
                tbxMobile.Text = dt.Rows[0]["Mobile"].ToString();
                tbxTel.Text = dt.Rows[0]["Tel"].ToString();
                tbxWeb.Text = dt.Rows[0]["Web"].ToString();
                tbxEmail.Text = dt.Rows[0]["Email"].ToString();
                _ID = Convert.ToInt32(dt.Rows[0]["CompanyId"].ToString());
                ImagePath = dt.Rows[0]["Logo"].ToString();
                if (ImagePath != "")
                    LoadIamge(ImagePath);
                btnSave.Text = "Edit";
                tbxCompanyName.ReadOnly = true;
                tbxAddress.ReadOnly = true;
                tbxEmail.ReadOnly = true;
                tbxFax.ReadOnly = true;
                tbxMobile.ReadOnly = true;
                tbxTel.ReadOnly = true;
                tbxWeb.ReadOnly = true;
                btnBrowse.Enabled = false;
                kryptonButton1.Enabled = false;
            }
            else
            {
                _ID = -1;
               
               
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
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ID > 0 && btnSave.Text=="Update")
            {
                UpdateData();
            }
            else if(_ID > 0 && btnSave.Text=="Edit")
            {
                btnSave.Text = "Update";
                tbxCompanyName.ReadOnly = false;
                tbxAddress.ReadOnly = false;
                tbxEmail.ReadOnly = false;
                tbxFax.ReadOnly = false;
                tbxMobile.ReadOnly = false;
                tbxTel.ReadOnly = false;
                tbxWeb.ReadOnly = false;
                btnBrowse.Enabled = true;
                kryptonButton1.Enabled = true;
            }
            else
            {
                SaveData();
            }
        }

        private void UpdateData()
        {
            try
            {
                if (tbxCompanyName.Text == "")
                {
                    KryptonMessageBox.Show("Plaese enter company name", "Error", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return;
                }
                else if (tbxMobile.Text == "")
                {
                    KryptonMessageBox.Show("Plaese enter mobile no", "Error", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    CompanyInformation com = new CompanyInformation();
                    com.CompanyId = _ID;
                    com.ComapayName = tbxCompanyName.Text;
                    com.Address = tbxAddress.Text;
                    com.Mobile = tbxMobile.Text;
                    com.Tel = tbxTel.Text;
                    com.Fax = tbxFax.Text;
                    com.Email = tbxEmail.Text;
                    com.Web = tbxWeb.Text;
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
                            filePath =  "ComLogo-" + Guid.NewGuid() + Path.GetExtension(sourceImagePath);

                            System.IO.File.Copy(sourceImagePath, Directory + filePath, true);

                            //hc.picture = filePath;
                        }
                    }

                    com.Logo = filePath;
                    int success = new bllCompanyInfo().Update(com);
                    if (success > 0)
                    {
                        KryptonMessageBox.Show("Company Update successfull", "Success", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                        Common.ClearForm(pnlBaseControlContainer);
                        btnSave.Text = "Save";
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        KryptonMessageBox.Show("Company Update Fail", "Error", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                KryptonMessageBox.Show(""+ex.Message, "Error", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
            }
        }

        private void SaveData()
        {
            try
            {
                if(tbxCompanyName.Text=="")
                {
                    KryptonMessageBox.Show("Plaese enter company name", "Error", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return;
                }
                else if(tbxMobile.Text=="")
                {
                    KryptonMessageBox.Show("Plaese enter mobile no", "Error", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    CompanyInformation com = new CompanyInformation();
                    com.ComapayName = tbxCompanyName.Text;
                    com.Address = tbxAddress.Text;
                    com.Mobile = tbxMobile.Text;
                    com.Tel = tbxTel.Text;
                    com.Fax = tbxFax.Text;
                    com.Email = tbxEmail.Text;
                    com.Web = tbxWeb.Text;
                    string filePath = "";
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
                            filePath = "Company-" + Guid.NewGuid() + Path.GetExtension(sourceImagePath);

                            System.IO.File.Copy(sourceImagePath, Directory + filePath, true);

                        }
                    }

                    com.Logo = filePath;
                    int success = new bllCompanyInfo().Insert(com);
                    if(success>0)
                    {
                        KryptonMessageBox.Show("Company Entry successfull", "Success", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                        Common.ClearForm(pnlBaseControlContainer);
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        KryptonMessageBox.Show("Company Entry Fail", "Error", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
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
    }
}
