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
    }
}
