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
    class dalReferrerFeeDetails
    {
        //public DataTable GetByCompanyInfo()
        //{
        //    return DatabaseManager.GetInstance().GetDataTable("exec Sp_CopanyInfoGet");
        //}
        public DataTable GetAllWithPagination(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Rpt_RefererFeeDetailsWithPage", altParams);
            return dt;
        }
        public DataTable GetAllWithoutPagination(string Criteria)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Rpt_RefererFeeDetails", altParams);
        }
    }
}
