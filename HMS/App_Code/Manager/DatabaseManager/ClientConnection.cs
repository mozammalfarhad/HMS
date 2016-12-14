using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HMS.App_Code.Manager.DatabaseManager
{
    public class ClientConnection
    {
        private SqlConnection connection;

        private string connectionString =ConfigurationManager.ConnectionStrings[1].ConnectionString;

        public bool OpenConnection()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }             
        }

        public void CloseConnection()
        {
            connection.Close();
            connection.Dispose();
        }

     
    }
}
