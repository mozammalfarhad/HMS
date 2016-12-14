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
    public class dalTestWithSchedule
    {
       public int InsertTest_Schedule_vacuum(string VacuumsData, int PatientId, DateTime ReceiveDate, TimeSpan ReceiveTime,
            DateTime DeliveryDate, TimeSpan DeliveryTime, decimal TotalAmt, decimal DiscountR, decimal DiscountH, decimal PaidAmt, string TestData, string userName, decimal VatAmt, decimal VacuumAmt, int ReferById)
        {

            ArrayList altParams = new ArrayList();

            altParams.Add(new SqlParameter("@Vacuumsxml", VacuumsData));
            altParams.Add(new SqlParameter("@PatientId", PatientId));
            altParams.Add(new SqlParameter("@ReceiveDate", ReceiveDate));
            altParams.Add(new SqlParameter("@ReceiveTime", ReceiveTime));
            altParams.Add(new SqlParameter("@DeliveryDate", DeliveryDate));
            altParams.Add(new SqlParameter("@DeliveryTime", DeliveryTime));
            altParams.Add(new SqlParameter("@TotalAmount", TotalAmt));
            altParams.Add(new SqlParameter("@DiscountR", DiscountR));
            altParams.Add(new SqlParameter("@DiscountH", DiscountH));
            altParams.Add(new SqlParameter("@PaidAmount", PaidAmt));
            altParams.Add(new SqlParameter("@Testxml", TestData));
            altParams.Add(new SqlParameter("@UserName", userName));
            altParams.Add(new SqlParameter("@VatAmt", VatAmt));
            altParams.Add(new SqlParameter("@VacuumAmt", VacuumAmt));
            altParams.Add(new SqlParameter("@ReferById", ReferById));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("sp_TestWithScheduleInsert", altParams);
        }
        public DataTable GetPatientServiceBySchedId(int ShedId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ShedId", ShedId));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("sp_PatientServiceDetailsGetBySchedId", altParams);
            return dt;
        }

        public int Delete(int ScheduleId,int TestId)
          {
              ArrayList altParams = new ArrayList();

              altParams.Add(new SqlParameter("@ShedId", ScheduleId));
              altParams.Add(new SqlParameter("@TestId", TestId));
              return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("sp_deletePatientTest", altParams);
        }

        
        
    }
}



