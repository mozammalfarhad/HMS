using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.App_Code.DAL;

namespace HMS.App_Code.BLL
{
    public class bllStatement
    {
        public DataTable GetDailySummaryStatement(string UserName, DateTime FromDate, DateTime ToDate)
        {
            return new dalStatement().GetDailySummaryStatement(UserName,FromDate,ToDate);
        }
    }
}
