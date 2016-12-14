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
   public class dalConsultantType
    {
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ConsultantTypeGetList", altParams);
            return dt;
        }


        public DataTable GetAllConsultantTypeList()
        {
            ArrayList altParams = new ArrayList();
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ConsultantTypeGetAll", altParams);
            return dt;
        }
        public DataTable GetByConsultantTypeId(int ConsultantTypeId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ConsultantTypeId", ConsultantTypeId));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ConsultantTypeGetById", altParams);
        }


        public int Insert(string ConsultantTypeName)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ConsultantTypeName", ConsultantTypeName));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ConsultantTypeInsert", altParams);
        }
        public int Update(int ConsultantTypeId, string ConsultantTypeName)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ConsultantTypeName", ConsultantTypeName));
            altParams.Add(new SqlParameter("@ConsultantTypeId", ConsultantTypeId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ConsultantTypeUpdate", altParams);
        }
        public int Delete(int ConsultantTypeId)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ConsultantTypeId", ConsultantTypeId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ConsultantTypeDelete", altParams);
        }
    }
}
