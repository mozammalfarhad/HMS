using System;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace HMS.Manager.MailSendManager
{
    /// <summary>
    /// Summary description for MailSend
    /// </summary>
    public class SendEmail
    {
        public SendEmail()
        {

        }

        public bool SendSimpleMail(string EmailFrom, string EmailTo, string emailSubject, string emailBody)
        {


            MailMessage objMessage;
            SmtpClient objClient;
            string toEmail;
            try
            {
                if (ConfigurationSettings.AppSettings["OffLineTesting"].ToString() == "True")
                    return true;
                else
                {
                    MailAddress From;

                    if (EmailFrom == "")
                        From = new MailAddress(ConfigurationSettings.AppSettings.Get("MailSender"), ConfigurationSettings.AppSettings.Get("MailSenderName"));
                    else
                        From = new MailAddress(ConfigurationSettings.AppSettings.Get("MailSender"), EmailFrom);


                    MailAddressCollection ccAddress = new MailAddressCollection();
                    if (EmailTo.Contains(";"))
                    {

                        string[] tos = EmailTo.Split(';');
                        if (tos.Length > 1)
                        {
                            for (int i = 1; i < tos.Length; i++)
                            {
                                ccAddress.Add(new MailAddress(tos[i].ToString()));
                            }
                        }
                        toEmail = tos[0];
                    }
                    else
                    {
                        toEmail = EmailTo;
                    }
                    MailAddress To = new MailAddress(toEmail);
                    objMessage = new MailMessage(From, To);

                    if (ccAddress.Count > 0)
                    {
                        foreach (MailAddress cc in ccAddress)
                        {
                            objMessage.CC.Add(cc);
                        }
                    }

                    objMessage.IsBodyHtml = true;
                    objMessage.Subject = emailSubject;

                    emailBody = emailBody.Replace("$Rank$", "");


                    objMessage.Body = emailBody;
                    objMessage.Priority = MailPriority.Normal;
                    System.Net.NetworkCredential nc = new NetworkCredential(ConfigurationSettings.AppSettings.Get("MailSender"), ConfigurationSettings.AppSettings.Get("MailSenderPWD"));
                    objClient = new SmtpClient();

                    objClient.EnableSsl = false;
                    objClient.UseDefaultCredentials = false;
                    objClient.Credentials = nc;
                    objClient.Send(objMessage);
                    return true;
                }
            }
            catch (Exception ex)
            {
               // VIT.ExceptionManager.ExceptionController.HandleException(ex.Message);
                return false;
            }
        }


    }
}
