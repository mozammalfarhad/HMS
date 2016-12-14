using HMS.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.App_Code.BLL
{
    class bllReferrerFeeDetails
    {
        dalReferrerFeeDetails objRef = new dalReferrerFeeDetails();
        public DataTable GetAllWithPagination(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objRef.GetAllWithPagination(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
        public DataTable GetAllWithoutPagination(string Criteria)
        {
            return objRef.GetAllWithoutPagination(Criteria);
        }
    }
}
