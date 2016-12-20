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
   public class dalCultureSensitivityMedicine
    {
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_CultureSensitivityMadicineGetAll", altParams);
            return dt;
        }
        public int Insert(CultureSensitivityMedicine medicines)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@MedicineName", medicines.MedicineName));
            altParams.Add(new SqlParameter("@Description", medicines.Description));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_CulureSentivityMedicineInsert", altParams);
        }
        public int Update(CultureSensitivityMedicine medicine)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@MedicineId", medicine.MedicineId));
            altParams.Add(new SqlParameter("@MedicineName", medicine.MedicineName));
            altParams.Add(new SqlParameter("@Description", medicine.Description));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_CultureSentivityMedicineUpdate", altParams);
        }
        public int Delete(int MedicineId)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@MedicineId", MedicineId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_CultureSentivityMedicineDelete", altParams);
        }
        public DataTable GetAll()
        {
            DataTable dt = DatabaseManager.GetInstance().GetDataTable("select * from   CultureSentivityMedicine ");
            return dt;
        }
    }
}
