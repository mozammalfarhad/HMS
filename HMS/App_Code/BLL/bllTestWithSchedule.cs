using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.App_Code.DAL;

namespace HMS.App_Code.BLL
{
    public class bllTestWithSchedule
    {
        public int InsertTest_Schedule_vacuum(DataSet VacuumsData, int PatientId, DateTime ReceiveDate, TimeSpan ReceiveTime,
           DateTime DeliveryDate, TimeSpan DeliveryTime, decimal TotalAmt, decimal DiscountR, decimal DiscountH, decimal PaidAmt, DataSet TestDat, string username, decimal VatAmt, decimal VacuumAmt, int ReferById)
        {

            string Data = TestDat.GetXml();
            Data = Data.Replace("'", "''");
            Data = Data.Replace("T00:00:00+06:00", "");
            Data = Data.Replace("T00:00:00+07:00", "");
            Data = Data.Replace("T18:00:00+06:00", "");
            Data = Data.Replace("T05:00:00+06:00", "");
            Data = Data.Replace("T05:00:00+06:00", "");
            Data = Data.Replace("T06:00:00+06:00", "");
            Data = Data.Replace("T05:00:00+06:00", "");
            Data = Data.Replace("T04:00:00+06:00", "");

            string VacuumData = VacuumsData.GetXml();
            VacuumData = VacuumData.Replace("'", "''");
            VacuumData = VacuumData.Replace("T00:00:00+06:00", "");
            VacuumData = VacuumData.Replace("T00:00:00+07:00", "");
            VacuumData = VacuumData.Replace("T18:00:00+06:00", "");
            VacuumData = VacuumData.Replace("T05:00:00+06:00", "");
            VacuumData = VacuumData.Replace("T05:00:00+06:00", "");
            VacuumData = VacuumData.Replace("T06:00:00+06:00", "");
            VacuumData = VacuumData.Replace("T05:00:00+06:00", "");
            VacuumData = VacuumData.Replace("T04:00:00+06:00", "");
            return new dalTestWithSchedule().InsertTest_Schedule_vacuum(VacuumData, PatientId, ReceiveDate, ReceiveTime,
                DeliveryDate, DeliveryTime, TotalAmt, DiscountR, DiscountH, PaidAmt, Data, username, VatAmt, VacuumAmt, ReferById);
        }

        public DataTable GetPatientServiceBySchedId(int ShedId)
        {
              return new dalTestWithSchedule().GetPatientServiceBySchedId(ShedId);
        }

        public int Delete(int ScheduleId, int TestId)
        {
            return new dalTestWithSchedule().Delete(ScheduleId,TestId);
        }
    }
}

