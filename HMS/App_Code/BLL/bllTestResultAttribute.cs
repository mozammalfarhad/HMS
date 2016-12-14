using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.App_Code.DAL;

namespace HMS.App_Code.BLL
{
    public class bllTestResultAttribute
    {
        public int InsertUpdateTestResultAttribute(DataSet TestResultAttributeData)
        {

            var Data = TestResultAttributeData.GetXml();
            Data = Data.Replace("'", "''");
            Data = Data.Replace("T00:00:00+06:00", "");
            Data = Data.Replace("T00:00:00+07:00", "");
            Data = Data.Replace("T18:00:00+06:00", "");
            Data = Data.Replace("T05:00:00+06:00", "");
            Data = Data.Replace("T05:00:00+06:00", "");
            Data = Data.Replace("T06:00:00+06:00", "");
            Data = Data.Replace("T05:00:00+06:00", "");
            Data = Data.Replace("T04:00:00+06:00", "");
            return new dalTestResultAttribute().InsertUpdateTestResultAttribute(Data);
        }

        //public DataTable GetPatientServiceBySchedId(int ShedId)
        //{
        //    return new dalTestWithSchedule().GetPatientServiceBySchedId(ShedId);
        //}

        //public int Delete(int ScheduleId, int TestId)
        //{
        //    return new dalTestWithSchedule().Delete(ScheduleId, TestId);
        //}
    }
}
