using HMS.Model;
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
    class dalCompanyInfo
    {
        public DataTable GetByCompanyInfo()
        {
            return DatabaseManager.GetInstance().GetDataTable("exec Sp_CopanyInfoGet");
        }
        public int Insert(CompanyInformation compay)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ComapayName", compay.ComapayName));
            altParams.Add(new SqlParameter("@Logo", compay.Logo));
            altParams.Add(new SqlParameter("@Address", compay.Address));
            altParams.Add(new SqlParameter("@Tel", compay.Tel));
            altParams.Add(new SqlParameter("@Mobile", compay.Mobile));
             altParams.Add(new SqlParameter("@Fax", compay.Fax));
             altParams.Add(new SqlParameter("@Email", compay.Email));
             altParams.Add(new SqlParameter("@Web", compay.Web));
             return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_CopanyInfoInsert", altParams);
        }
        public int Update(CompanyInformation compay)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@CompanyId", compay.CompanyId));
            altParams.Add(new SqlParameter("@ComapayName", compay.ComapayName));
            altParams.Add(new SqlParameter("@Logo", compay.Logo));
            altParams.Add(new SqlParameter("@Address", compay.Address));
            altParams.Add(new SqlParameter("@Tel", compay.Tel));
            altParams.Add(new SqlParameter("@Mobile", compay.Mobile));
            altParams.Add(new SqlParameter("@Fax", compay.Fax));
            altParams.Add(new SqlParameter("@Email", compay.Email));
            altParams.Add(new SqlParameter("@Web", compay.Web));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_CopanyInfoUpdate", altParams);
        }
    }
}
