using System.IO;
using System.Net;

namespace HMS
{
    /// <summary>
    /// Summary description for FTPManager
    /// </summary>
//FTP Manager Class
    public class FTPManager
    {
        //Local variables
        private string FTPUrl;
        private string SourceFile;
        private string DestinationFile;
        private string UserName;
        private string Password;
        //Class Constructor
        public FTPManager(string FTPUrl, string SourceFile,
                          string DestinationFile, string UserName, string Password)
        {
            //Set constructor parameters value to local variable
            this.FTPUrl = FTPUrl;
            this.SourceFile = SourceFile;
            this.DestinationFile = DestinationFile;
            this.UserName = UserName;
            this.Password = Password;
        }
        //FTP file upload method
        public void FileUpload()
        {
            //Check FTP configurations
            if ((FTPUrl == null)
                || (SourceFile == null) || (DestinationFile == null))
                return;
            //Exit from method if no SourceFile assigned
            if (!File.Exists(SourceFile))
                return;

            try
            {
                //For reading local file
                WebClient Client = new WebClient();
                //Create FTP request                
                FtpWebRequest request =
                    (FtpWebRequest)FtpWebRequest.Create(FTPUrl + DestinationFile);
                //Passing user credential like user name and password
                request.Credentials = new NetworkCredential(UserName,
                                                            Password);
                //Declaring the method like Upload/Download etc
                request.Method = WebRequestMethods.Ftp.UploadFile;
                //Pass binary data
                request.UseBinary = true;
                //Reading local file stream and sending the same to 
                //web site
                using (Stream reader = Client.OpenRead(SourceFile))
                using (Stream writer = request.GetRequestStream())
                {
                    //Allocate memery
                    byte[] buffer = new byte[8182];
                    int bytesReaded = reader.Read(buffer, 0,
                                                  buffer.Length);
                    while (bytesReaded > 0)
                    {
                        //Write data to ftp site
                        writer.Write(buffer, 0, bytesReaded);
                        //Read next bytes.
                        bytesReaded = reader.Read(buffer, 0,
                                                  buffer.Length);
                    }
                }
            }
            catch
            {
            }
            return;
        }
    }
}

