using System;
using System.Text;

namespace HMS.Manager.EncryptDecrypt
{
    /// <summary>
    /// Summary description for Common
    /// </summary>
    public static class EncryptDecrypt
    {
        public static int key = 129;

        //public static string EncryptDecryptString(string textToEncrypt)
        //{
        //    StringBuilder inSb = new StringBuilder(textToEncrypt);
        //    StringBuilder outSb = new StringBuilder(textToEncrypt.Length);
        //    char c;
        //    for (int i = 0; i < textToEncrypt.Length; i++)
        //    {
        //        c = inSb[i];
        //        c = (char)(c ^ key);
        //        outSb.Append(c);
        //    }
        //    return outSb.ToString();
        //}

        // This method is used to encrypt the string
        public static string EncryptString(string str)
        {
            Byte[] b;

            b = ASCIIEncoding.ASCII.GetBytes(str);
            return Convert.ToBase64String(b);
        }

        // This method is used to decrypt the string
        public static string DecryptString(string str)
        {
            Byte[] b;

            b = Convert.FromBase64String(str);
            return ASCIIEncoding.ASCII.GetString(b);
        }    

    }
}
