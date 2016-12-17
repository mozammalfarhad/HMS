using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.App_Code.DAL;

namespace HMS.App_Code.BLL
{
    public class bllPatientServicDetails
    {
        dalPatientServicDetails objPatientServicDetails = new dalPatientServicDetails();
        public DataTable GetPatientServicDetailsByID(int PatientID, int SheduleId)
        {
            return objPatientServicDetails.GetPatientServicDetailsByID(PatientID, SheduleId);
        }

        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objPatientServicDetails.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }

    }
}
