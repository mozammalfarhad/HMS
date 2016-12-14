using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HMS.BLL;
using Ionic.Zip;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using VIT.DataLogicLayer;

namespace HMS.Forms.DatabaseOperations
{
    public partial class RestoreDataForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public RestoreDataForm()
        {
            InitializeComponent();
        }

        string UserName;
        bllCommon objCommon = new bllCommon();
        
        public RestoreDataForm(string _UserName)
        {
            InitializeComponent();

            UserName = _UserName;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbxFileBrowsePath.Text != "")
                {
                    FileInfo fi = new FileInfo(tbxFileBrowsePath.Text);
                    string DestinationURL = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + ConfigurationSettings.AppSettings.Get("DatabaseBackupPath");

                    string ZipToUnpack = tbxFileBrowsePath.Text;
                    string TargetDir = DestinationURL;
                    string BackUpFileName = "";
                    ZipFile zip1 = ZipFile.Read(ZipToUnpack);
                    foreach (ZipEntry ze in zip1)
                    {
                        BackUpFileName = ze.FileName;
                        ze.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently);
                    }
                    var backupFile = string.Format("{0}{1}",TargetDir,BackUpFileName);

                    Restore(backupFile);
                }
                else
                {
                    KryptonMessageBox.Show("Select backup file", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            catch (Exception ex)
            {
                //log.LogErrorWithException("Warn",ex);
                KryptonMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            fd.FileName = "";
            fd.Filter = "Backup files (*.zip)|*.zip|All files (*.*)|*.*";
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
                tbxFileBrowsePath.Text = fd.FileName;
            else
                tbxFileBrowsePath.Text = "";
        }

        #region "Database Restoration"

        private void Restore(string logicalFileName)
        {
            string serverName =  ConfigurationSettings.AppSettings.Get("ServerName");
            string databaseName = ConfigurationSettings.AppSettings.Get("DestinationDatabaseName");
            var sqlRestore = new Restore();

           


            sqlRestore.Devices.AddDevice(logicalFileName, DeviceType.File);
            sqlRestore.Database = databaseName;
            sqlRestore.Action = RestoreActionType.Database;
            sqlRestore.ReplaceDatabase = true;            
            var connection = new ServerConnection(serverName) {LoginSecure = true};
            var sqlServer = new Server(connection);
            sqlServer.ConnectionContext.DatabaseName = "master";
            sqlRestore.Complete += new ServerMessageEventHandler(sqlRestore_Complete);
            sqlRestore.PercentCompleteNotification = 10;
            sqlRestore.PercentComplete += new PercentCompleteEventHandler(sqlRestore_PercentComplete);           
            sqlServer.KillAllProcesses(databaseName);
            sqlRestore.SqlRestore(sqlServer);
            sqlServer.Databases[databaseName].SetOnline();            
            sqlServer.Refresh();
            DatabaseManager.GetInstance()._DbConnection.Close();
            DatabaseManager.GetInstance()._DbConnection.Open();
            KryptonMessageBox.Show("Database restored successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static void sqlRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
        }

        static void sqlRestore_Complete(object sender, ServerMessageEventArgs e)
        {
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}