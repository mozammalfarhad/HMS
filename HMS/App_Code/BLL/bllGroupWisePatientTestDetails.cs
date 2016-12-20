using HMS.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.App_Code.BLL
{
    class bllGroupWisePatientTestDetails
    {
        dalGroupWisePatientTestDetails objTestDetails = new dalGroupWisePatientTestDetails();
        public DataTable GetGroupWisePatientTestDetails(DateTime FromDate, DateTime ToDate)
        {
            return objTestDetails.GetGroupWisePatientTestDetails(FromDate, ToDate);
        }
    }
}
