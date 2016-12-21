using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.App_Code.DAL;

namespace HMS.App_Code.BLL
{
    public class bllTestResult
    {
        dalTestResult objTestResult = new dalTestResult();
        //public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        //{
        //    return objTestResult.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        //}
        //public DataTable GetByID(int ConsultantId)
        //{
        //    return objTestResult.GetByConsultantID(ConsultantId);
        //}
        public int InsertTestResult(string Result, string Status, int SheduleId, int ServiceId)
        {
            return objTestResult.UpdateTestResultUpdate(Result, Status, SheduleId, ServiceId);
        }
        public int InsertTestSample(string samples, int SheduleId, int ServiceId)
        {
            return objTestResult.InsertUpdateTestSample(samples, SheduleId, ServiceId);
        }
        
        public DataTable GetTestResultGetWithAttribute(int TestId, int ShedId, int ServiceId)
        {
            return objTestResult.GetTestResultGetWithAttribute(TestId, ShedId, ServiceId);
        }

        public DataTable GetTestById(int TestId)
        {
            return objTestResult.GetTestById(TestId);
        }

        public DataTable PatientServiceGetBySchedId(int ShedId)
        {
            return objTestResult.PatientServiceGetBySchedId(  ShedId );
        }
        public DataTable PatientServiceDetailsGetBySchedId(int ShedId)
        {
            return objTestResult.PatientServiceDetailsGetBySchedId(ShedId);
        }
        public DataTable PatientServiceVacuumGetBySchedId(int ShedId)
        {
            return objTestResult.PatientServiceVacuumGetBySchedId(ShedId);
        }

    }
}
