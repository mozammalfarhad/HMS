using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.Forms.Security;
using HMS.Properties;
using HMS.Views;

namespace HMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {

            try
            {
                //string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string directory = Path.Combine(Application.StartupPath, "logo-url");

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    Settings.Default.HospitalLogoPath = directory;
                    Settings.Default.Save();
                }
                ChangeCulture("dd/MMM/yyyy");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new  Login());
                //Licensing.Tool.ApplyLicensing(new Login(), "BGFH");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Exception:\n{0}\n\nStack:\n{1}", ex.Message, ex.StackTrace),
                    "Application Load", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public static void ChangeCulture(string dateformat)
        {
            var ci = new CultureInfo("");
            DateTimeFormatInfo dateTimeFormatInfo = ci.DateTimeFormat;
            dateTimeFormatInfo.ShortDatePattern = dateformat;
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }
    }
}
