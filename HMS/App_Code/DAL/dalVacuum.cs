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
   public class dalVacuum
    {
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceVacuumGetAll", altParams);
            return dt;
        }
        public DataTable GetAll()
        {
            ArrayList altParams = new ArrayList();
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceVacuumGetList", altParams);
            return dt;
        }
       
        public DataTable GetByID(int VacuumID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@VacuumId", VacuumID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceVacuumGetById", altParams);
        }
        public DataTable GetByServiceID(int ServiceID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ServiceId", ServiceID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceVacuumGetByServiceId", altParams);
        }
        public int Insert(int ServiceId, string VacuumName, string Description, decimal VacuumPrice)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ServiceId", ServiceId));
            altParams.Add(new SqlParameter("@VacuumName", VacuumName));
            altParams.Add(new SqlParameter("@Description", Description));
            altParams.Add(new SqlParameter("@VacuumPrice", VacuumPrice));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ServiceVacuumInsert", altParams);
        }
        public int Update(int VacuumId, int ServiceId, string VacuumName, string Description, decimal VacuumPrice)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ServiceId", ServiceId));
            altParams.Add(new SqlParameter("@VacuumName", VacuumName));
            altParams.Add(new SqlParameter("@Description", Description));
            altParams.Add(new SqlParameter("@VacuumId", VacuumId));
            altParams.Add(new SqlParameter("@VacuumPrice", VacuumPrice));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("SP_ServiceVacuumUpdate", altParams);
        }
        public int Delete(int VacuumId)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@VacuumId", VacuumId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ServiceVacuumDelete", altParams);
        }
    }
}
