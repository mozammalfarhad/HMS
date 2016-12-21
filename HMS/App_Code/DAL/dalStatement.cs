using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIT.DataLogicLayer;

namespace HMS.App_Code.DAL
{
    public class dalStatement
    {
        public DataTable GetDailySummaryStatement(string UserName,DateTime FromDate, DateTime ToDate)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UserName", UserName));
            altParams.Add(new SqlParameter("@FromDate", FromDate));
            altParams.Add(new SqlParameter("@ToDate", ToDate));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("rpt_dailySummaryStatement", altParams);
            return dt;
        }
        public DataTable GetDailySummaryStatementSubReportData(string UserName, DateTime FromDate, DateTime ToDate)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UserName", UserName));
            altParams.Add(new SqlParameter("@FromDate", FromDate));
            altParams.Add(new SqlParameter("@ToDate", ToDate));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("RptSub_DailySummeryStetement", altParams);
            return dt;
        }
        public DataTable GetLedgerStatement(string UserName, DateTime FromDate, DateTime ToDate)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UserName", UserName));
            altParams.Add(new SqlParameter("@FromDate", FromDate));
            altParams.Add(new SqlParameter("@ToDate", ToDate));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Rpt_DailyCollectionStatement", altParams);
            return dt;
        }

        public DataTable GetLedgerStatementDetails(string UserName, DateTime FromDate, DateTime ToDate)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UserName", UserName));
            altParams.Add(new SqlParameter("@FromDate", FromDate));
            altParams.Add(new SqlParameter("@ToDate", ToDate));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Rpt_DialyLadgerStementDetails", altParams);
            return dt;
        }


    }
}
