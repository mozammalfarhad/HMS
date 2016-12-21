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
    public class dalTestResultAttribute
    {
        public int InsertUpdateTestResultAttribute(string TestResultAttributeData)
        {
                ArrayList altParams = new ArrayList();
                altParams.Add(new SqlParameter("@TestResultAttributeXml", TestResultAttributeData));
                return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("sp_TestResultAttributeInsertUpdate", altParams);
           
        }
       

        //public int Delete(int ScheduleId, int TestId)
        //{
        //    ArrayList altParams = new ArrayList();

        //    altParams.Add(new SqlParameter("@ShedId", ScheduleId));
        //    altParams.Add(new SqlParameter("@TestId", TestId));
        //    return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("sp_deletePatientTest", altParams);
        //}
    }
}
