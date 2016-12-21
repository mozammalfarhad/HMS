using HMS.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIT.DataLogicLayer;

namespace HMS.DAL
{
    public class dalCultureSentivityBacteria
    {
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_CultureSensitivityBacteriaGetAll", altParams);
            return dt;
        }
        public int Insert(CultureSensitivityBacteria Bacteria)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@BacteriaName", Bacteria.BacteriaName));
            altParams.Add(new SqlParameter("@Description", Bacteria.Description));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_CultureSentivityBacteriaInsert", altParams);
        }
        public int Update(CultureSensitivityBacteria Bacteria)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@BacteriaId", Bacteria.BacteriaId));
            altParams.Add(new SqlParameter("@BacteriaName", Bacteria.BacteriaName));
            altParams.Add(new SqlParameter("@Description", Bacteria.Description));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_CultureSentivityBacteriaUpdate", altParams);
        }
        public int Delete(int BacteriaId)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@BacteriaId", BacteriaId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_CultureSentivityBacteriaDelete", altParams);
        }
        public DataTable GetAll()
        {
            DataTable dt = DatabaseManager.GetInstance().GetDataTable("select * from   CultureSentivityBacteria ");
            return dt;
        }
    }
}
