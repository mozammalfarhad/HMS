using System.Data;
using HMS.DAL;

namespace HMS.BLL
{
    public class bllAudit
    {
        dalAudit objAudit = new dalAudit();
        public bllAudit()
        {
        }
        public DataTable GetList()
        {
            return objAudit.GetList();
        }

        public int Insert(string ModuleName, string Action, string Log, string User)
        {
            return objAudit.Insert(ModuleName, Action, Log, User);
        }

        public DataTable GetNotify(string UserName)
        {
            return objAudit.GetNotify(UserName);
        }

        public DataTable GetNotifyByID(int ID)
        {
            return objAudit.GetNotifyByID(ID);
        }

        public DataTable GetNotifySearch(string UserName)
        {
            return objAudit.GetNotifySearch(UserName);
        }

        public int InsertNotify(string Subject, string Message, string UserName, string Support)
        {
            return objAudit.InsertNotify(Subject, Message, UserName, Support);
        }

        public int UpdateNotify(int ID)
        {
            return objAudit.UpdateNotify(ID);

        }

        public DataTable FollowUpGet(string ModuleName, int RequestID)
        {
            return objAudit.FollowUpGet(ModuleName, RequestID);
        }

        public int InsertFollowUp(string ModuleName, int RequestID, string Status, string Comments, string UserName)
        {
            return objAudit.InsertFollowUp(ModuleName, RequestID, Status, Comments, UserName);
        }


        public DataTable GetCustomResults(string strSQL)
        {
            return objAudit.GetCustomResults(strSQL);
        }

    }
}
