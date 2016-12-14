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
    class dalReportData
    {


        public DataTable GetTestCatagoryReport(int SheduleId, int typeId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@SheduleId", SheduleId));
            altParams.Add(new SqlParameter("@typeId", typeId));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_rptTestCatagoryReport", altParams);
        }
    }
}
