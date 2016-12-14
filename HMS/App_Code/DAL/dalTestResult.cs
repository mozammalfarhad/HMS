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
    public class dalTestResult
    {
        public int UpdateTestResultUpdate(string Result, string Status, int ShedId, int ServiceId)
        {

            ArrayList altParams = new ArrayList();

            altParams.Add(new SqlParameter("@Result", Result));
            altParams.Add(new SqlParameter("@Status", Status));
            altParams.Add(new SqlParameter("@ShedId", ShedId));
            altParams.Add(new SqlParameter("@ServiceId", ServiceId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("sp_TestResultUpdate", altParams);
        }
        public DataTable GetTestResultGetWithAttribute(int TestId, int ShedId, int ServiceId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@TestId", TestId));
            altParams.Add(new SqlParameter("@ShedId", ShedId));
            altParams.Add(new SqlParameter("@ServiceId", ServiceId));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("sp_TestResultGetWithAttribute", altParams);
            return dt;
        }
        public DataTable PatientServiceGetBySchedId(int ShedId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ShedId", ShedId));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("sp_PatientServiceGetBySchedId", altParams);
            return dt;
        }
        public DataTable PatientServiceVacuumGetBySchedId(int ShedId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ShedId", ShedId));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("sp_PatientServiceVacuumGetBySchedId", altParams);
            return dt;
        }
         public DataTable PatientServiceDetailsGetBySchedId(int ShedId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ShedId", ShedId));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("sp_PatientServiceDetailsGetBySchedId", altParams);
            return dt;
        }

        //public int Delete(int ScheduleId)
        //{
        //    ArrayList altParams = new ArrayList();

        //    altParams.Add(new SqlParameter("@ShedId", ScheduleId));
        //    altParams.Add(new SqlParameter("@TestId", TestId));
        //    return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("sp_deletePatientTest", altParams);
        //}
    }
}
