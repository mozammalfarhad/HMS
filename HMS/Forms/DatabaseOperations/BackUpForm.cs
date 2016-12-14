using System;
using System.Data;
using System.Windows.Forms;
using HMS.BLL;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
using System.Configuration;
using Ionic.Zip;
using System.IO;

namespace HMS.Forms.DatabaseOperations
{
    public partial class BackUpForm : KryptonForm
    {
        public BackUpForm()
        {
            InitializeComponent();
        }

        string UserName;
        bllCommon objCommon = new bllCommon();
        //private Logging log = new Logging();

        public BackUpForm(string _UserName)
        {
            InitializeComponent();

            UserName = _UserName;
        }


        protected void BindData()
        {
            try
            {
                DataTable dt = objCommon.GetBackupHistory();

                dgvMain.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    int RowNum = dgvMain.Rows.Add(
                        new object[] {
                        dr["BackupDate"],
                        dr["BackupBy"],
                        dr["FileName"]
                    });
                    dgvMain.Rows[RowNum].Tag = dr["FileName"];
                }
            }
            catch (Exception ex)
            {
                //log.LogErrorWithException("Error",ex);
            }
        }



        private string BackupDB()
        {
            string archiveName = String.Format("archive-{0}", DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"));

            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string FileName = archiveName + ".bak";
                string filepath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) +
                                  ConfigurationSettings.AppSettings.Get("DatabaseBackup");
                if (!Directory.Exists(filepath))
                    Directory.CreateDirectory(filepath);
                con = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
                cmd = new SqlCommand(@"backup database " + ConfigurationSettings.AppSettings.Get("DestinationDatabaseName") + " to disk='" + filepath + FileName + "'", con);
             
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                archiveName = archiveName + ".zip";
                using (ZipFile zip = new ZipFile())
                {
                    zip.AddFile(String.Format("{0}{1}", filepath, FileName), "");
                    zip.Save(String.Format("{0}{1}", filepath, archiveName));
                }

                File.Delete(String.Format("{0}{1}", filepath, FileName));

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //log.LogErrorWithException("Error",ex);
            }
            return archiveName;

        }


        private void btnNewBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = BackupDB();
                objCommon.InsertBackupHistory(UserName, FileName);
                KryptonMessageBox.Show("Database Backup Completed successfully.", "Database Backup.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindData();
            }
            catch (Exception ex)
            {
                //log.LogErrorWithException("Error",ex);
                KryptonMessageBox.Show(ex.Message, "Database Backup.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (dgvMain.Rows.Count == 0 || dgvMain.SelectedRows.Count == 0)
            {
                KryptonMessageBox.Show("Select Backup.", "Database Backup.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) +
                  ConfigurationSettings.AppSettings.Get("DatabaseBackup");

            string strFileName = String.Format("{0}{1}", filepath, dgvMain.SelectedRows[0].Tag);

            if (File.Exists(strFileName))
            {
                fd.Filter = "Backup files (*.zip)|*.zip|All files (*.*)|*.*";
                fd.FileName = dgvMain.SelectedRows[0].Tag.ToString();
                DialogResult dr = fd.ShowDialog();
                if (dr == DialogResult.OK)
                    File.Copy(strFileName, fd.FileName, true);

            }
            else
                KryptonMessageBox.Show("File Does not Exist.", "Database Backup.", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BackUpForm_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvMain.Rows.Count == 0 || dgvMain.SelectedRows.Count == 0)
            {
                KryptonMessageBox.Show("Please select one or more row.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (KryptonMessageBox.Show("Sure to remove?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

                return;
            }
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) +
                                  ConfigurationSettings.AppSettings.Get("DatabaseBackup");
            foreach (DataGridViewRow row in dgvMain.SelectedRows)
            {

                string filename = row.Cells["FileName"].Value.ToString();
                objCommon.DeleteBackupHistory(filename);
                var file = filepath + filename + ".zip";
                if (File.Exists(file))
                    File.Delete(file);
            }
            BindData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}