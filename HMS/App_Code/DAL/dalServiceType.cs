using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIT.DataLogicLayer;

namespace HMS.App_Code.BLL
{
    class dalServiceType
    {
         public DataTable GetList(int StartRowIndex,int MaxRows, string Criteria,bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceTypeGetAll", altParams);
            return dt;
        }
         public DataTable GetAll()
         {
             ArrayList altParams = new ArrayList();

             DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceTypeGetList", altParams);
             return dt;
         }
         public DataTable GetByServiceTypeByID(int TypeId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@TypeId", TypeId));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceTypeGetByID", altParams);
        }
         public int Insert(string TypeName)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@TypeName", TypeName));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ServiceTypeInsert", altParams);
        }
         public int Update(int TypeId, string TypeName)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@TypeName", TypeName));
            altParams.Add(new SqlParameter("@TypeId ", TypeId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("SP_ServiceTypeUpdate", altParams);
        }
        public int Delete(int TypeId)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@TypeId", TypeId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ServiceTypeDelete", altParams);
        }
    }
}
