using System;
using System.Data;
using System.Collections;
using VIT.DataLogicLayer;
using System.Data.SqlClient;

namespace HMS.DAL
{
    public class dalAudit
    {
        public dalAudit()
        {
        }
        public DataTable GetList()
        {
            ArrayList altParams = new ArrayList();
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Audit_Get", altParams);
            return dt;
        }

        public int Insert(string ModuleName, string Action, string Log, string User)
        {
            
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ModuleName", ModuleName));
            altParams.Add(new SqlParameter("@Action", Action));
            altParams.Add(new SqlParameter("@Log", Log));
            altParams.Add(new SqlParameter("@User", User));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_Audit_Insert", altParams);
        }


        public DataTable GetNotify(string UserName)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UserName", UserName));
            return  DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Notify_Get", altParams);
        }

        public DataTable GetNotifyByID(int ID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ID", ID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Notify_GetByID", altParams);
        }

        public DataTable GetNotifySearch(string UserName)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UserName", UserName));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Notify_Search", altParams);
        }

        public int InsertNotify(string Subject, string Message, string UserName, string Support)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@Subject", Subject));
            altParams.Add(new SqlParameter("@Message", Message));
            altParams.Add(new SqlParameter("@UserName", UserName));
            altParams.Add(new SqlParameter("@Support", Support));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_Notify_Insert", altParams);
        }

        public int UpdateNotify(int ID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ID", ID));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_Notify_Update", altParams);
        }



        public DataTable FollowUpGet(string ModuleName, int RequestID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ModuleName", ModuleName));
            altParams.Add(new SqlParameter("@RequestID", RequestID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_FollowUp_Get", altParams);

        }

        public int InsertFollowUp(string ModuleName, int RequestID, string Status, string Comments, string UserName)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ModuleName", ModuleName));
            altParams.Add(new SqlParameter("@RequestID", RequestID));
            altParams.Add(new SqlParameter("@Status", Status));
            altParams.Add(new SqlParameter("@Comments", Comments));
            altParams.Add(new SqlParameter("@UserName", UserName));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_FollowUp_Insert", altParams);

        }


        public DataTable GetCustomResults(string strSQL)
        {
            try
            {
                return DatabaseManager.GetInstance().GetDataTable(strSQL);
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
