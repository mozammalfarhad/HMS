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
    public class dalPatientServicDetails
    {
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("sp_PatientServicDetailsGetAll", altParams);
            return dt;
        }

        public DataTable GetPatientServicDetailsByID(int patientID, int SheduleId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@patientId", patientID));
            altParams.Add(new SqlParameter("@SheduleId", SheduleId));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("rpt_PatientServicDetails", altParams);
            return dt;
        }
       
    }
}
