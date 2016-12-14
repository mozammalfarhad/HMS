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
    class dalLabtorist
    {
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_LabtoristGetAll", altParams);
            return dt;
        }
        public DataTable GetByLabtoristID(int LabId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@LabId", LabId));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_LabtoristGetByID", altParams);
        }

        public DataTable GetByLabtoristCode(int LabCode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@LabCode", LabCode));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_LabtoristGetByCode", altParams);
        }
        public int Insert(string Name, string Email, string Address, string MobileNo, string Image, string Qualification, string Gender)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@Name", Name));
            altParams.Add(new SqlParameter("@Email", Email));
            altParams.Add(new SqlParameter("@Address", Address));
            altParams.Add(new SqlParameter("@MobileNo", MobileNo));
            altParams.Add(new SqlParameter("@Image", Image));
            altParams.Add(new SqlParameter("@Qualification", Qualification));
            altParams.Add(new SqlParameter("@Gender", Gender));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_LabtoristInsert", altParams);
        }
        public int Update(int LabId, string LabCode, string Name, string Email, string Address, string MobileNo,string Image, string Qualification, string Gender)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@LabCode", LabCode));
            altParams.Add(new SqlParameter("@Name", Name));
            altParams.Add(new SqlParameter("@Email", Email));
            altParams.Add(new SqlParameter("@Address", Address));
            altParams.Add(new SqlParameter("@MobileNo", MobileNo));
            altParams.Add(new SqlParameter("@Image", Image));
            altParams.Add(new SqlParameter("@Qualification", Qualification));
            altParams.Add(new SqlParameter("@Gender", Gender));
            altParams.Add(new SqlParameter("@LabId", LabId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("SP_LabtoristUpdate", altParams);
        }
        public int Delete(int LabId)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@LabId", LabId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_PatientDelete", altParams);
        }
    }
}
