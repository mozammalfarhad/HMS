using System;
using System.Data;
using System.Collections;
using VIT.DataLogicLayer;
using System.Data.SqlClient;

namespace HMS.DAL
{
    public class dalUser
    {
        public dalUser()
        {
        }

        public DataTable GetSystemUsers()
        {
            ArrayList altParams = new ArrayList();
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Users_GetSystemUsers", altParams);
        }
        

        public DataTable GetByUserName(string UserName)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UserName", UserName));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("[USP_Users_GetByUserName]", altParams);
        }

        public DataTable GetByUsersByClubID(int ClubID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ClubID", ClubID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Users_GetSystemUsersByClubID", altParams);
        }

        public int InsertUpdate(int UserID,string UserName, string FullName, string MobileNo)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UserId", UserID));
            altParams.Add(new SqlParameter("@UserName", UserName));
            altParams.Add(new SqlParameter("@FullName", FullName));
            altParams.Add(new SqlParameter("@MobileNo", MobileNo));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("sp_userDetailsInsertUpdate", altParams);
        }

      

        public int Delete(string UserName)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UserName", UserName));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("sp_UsersDelete", altParams);
        }

    }
}
