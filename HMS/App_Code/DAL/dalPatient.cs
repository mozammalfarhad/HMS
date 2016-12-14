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
    class dalPatient
    {
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_PatientGetAll", altParams);
            return dt;
        }
        public DataTable GetAll()
        {
            ArrayList altParams = new ArrayList();
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_PatientGetList", altParams);
            return dt;
        }
        public DataTable GetByPatientID(int PatientID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@PatientID", PatientID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_PatientGetByID", altParams);
        }

        public DataTable GetByPatientCode(int PatientCode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@PatientCode", PatientCode));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_PatientGetByCode", altParams);
        }
        public int Insert(string PatientCode,string Name, string Email, string Address, string MobileNo, int Age, string BloodGroup, string Image, string Gender, int RrefrById)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@PatientCode", PatientCode));
            altParams.Add(new SqlParameter("@Name", Name));
            altParams.Add(new SqlParameter("@Email", Email));
            altParams.Add(new SqlParameter("@Address", Address));
            altParams.Add(new SqlParameter("@MobileNo", MobileNo));
            altParams.Add(new SqlParameter("@Age", Age));
            altParams.Add(new SqlParameter("@BloodGroup", BloodGroup));
            altParams.Add(new SqlParameter("@Image", Image));
            altParams.Add(new SqlParameter("@Gender", Gender));
            altParams.Add(new SqlParameter("@RrefrById", RrefrById));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_PatientInsert", altParams);
        }
        public int Update(int PatientID, string PatientCode, string Name, string Email, string Address, string MobileNo, int Age, string BloodGroup, string Image, string Gender, int RrefrById)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@Name", Name));
            altParams.Add(new SqlParameter("@Email", Email));
            altParams.Add(new SqlParameter("@Address", Address));
            altParams.Add(new SqlParameter("@MobileNo", MobileNo));
            altParams.Add(new SqlParameter("@Age", Age));
            altParams.Add(new SqlParameter("@BloodGroup", BloodGroup));
            altParams.Add(new SqlParameter("@Image", Image));
            altParams.Add(new SqlParameter("@Gender", Gender));
            altParams.Add(new SqlParameter("@RrefrById", RrefrById));
            altParams.Add(new SqlParameter("@PatientCode", PatientCode));
            altParams.Add(new SqlParameter("@PatientID", PatientID));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("SP_PatientUpdate", altParams);
        }
        public int Delete(int PatientID)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@PatientID", PatientID));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_PatientDelete", altParams);
        }
    }
}
