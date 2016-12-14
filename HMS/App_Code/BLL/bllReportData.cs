using HMS.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.App_Code.BLL
{
    class bllReportData
    {
        dalReportData drd = new dalReportData();
        public DataTable GetTestCatagoryReport(int SheduleId, int typeId)
        {
            return drd.GetTestCatagoryReport(SheduleId, typeId);
        }
    }
}
