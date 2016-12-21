using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIT.DataLogicLayer;

namespace HMS.App_Code.BLL
{
    public class dalUnit
    {
      
        public DataTable GetAll(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
           
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_UnitGetAll", altParams);
           
            return dt;
        }
        public DataTable GetList()
        {
            ArrayList altParams = new ArrayList();
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_UnitGetList", altParams);
            return dt;
        }
        public DataTable GetByID(int UnitId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UnitId", UnitId));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_UnitGetByID", altParams);
        }

      
        public int Insert(string Name)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UnitName",Name));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_UnitInsert", altParams);
        }
        public int Update(int UnitId, string UnitName)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UnitId", UnitId));
            altParams.Add(new SqlParameter("@UnitName", UnitName));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("SP_UnitUpdate", altParams);
        }
        public int Delete(int UnitId)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UnitId", UnitId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_UnitDelete", altParams);
        }
    }
}
