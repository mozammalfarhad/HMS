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
    class dalDoctor
    {
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_DoctorGetAll", altParams);
            return dt;
        }

        public DataTable GetAllDoctorCode()
        {
            DataTable dt = DatabaseManager.GetInstance().GetDataTable("select DoctorCode from [dbo].[Doctor]");
            return dt;
        }
        public DataTable GetAllDoctorList()
        {
            DataTable dt = DatabaseManager.GetInstance().GetDataTable("select * from [dbo].[Doctor]");
            return dt;
        }
        public DataTable GetByDoctorID(int DoctorId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@DoctorId", DoctorId));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_DoctorGetByID", altParams);
        }

        public DataTable GetByDoctorCode(int DoctorCode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@DoctorCode", DoctorCode));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_DoctorGetByCode", altParams);
        }
        public int Insert(string Name, string Email, string Address, string MobileNo,int DepartmentId,string Image, string Qualification, string Gender)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@Name", Name));
            altParams.Add(new SqlParameter("@Email", Email));
            altParams.Add(new SqlParameter("@Address", Address));
            altParams.Add(new SqlParameter("@MobileNo", MobileNo));
            altParams.Add(new SqlParameter("@DepartmentId", DepartmentId));
            altParams.Add(new SqlParameter("@Image", Image));
            altParams.Add(new SqlParameter("@Qualification", Qualification));
            altParams.Add(new SqlParameter("@Gender", Gender));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_DoctorInsert", altParams);
        }
        public int Update(int DoctorId,string DoctorCode, string Name, string Email, string Address, string MobileNo, int DepartmentId, string Image, string Qualification, string Gender)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@Name", Name));
            altParams.Add(new SqlParameter("@Email", Email));
            altParams.Add(new SqlParameter("@Address", Address));
            altParams.Add(new SqlParameter("@MobileNo", MobileNo));
            altParams.Add(new SqlParameter("@DepartmentId", DepartmentId));
            altParams.Add(new SqlParameter("@Image", Image));
            altParams.Add(new SqlParameter("@Qualification", Qualification));
            altParams.Add(new SqlParameter("@Gender", Gender));
            altParams.Add(new SqlParameter("@DoctorCode", DoctorCode));
            altParams.Add(new SqlParameter("@DoctorId", DoctorId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("SP_DoctorUpdate", altParams);
        }
        public int Delete(int DoctorId)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@DoctorId", DoctorId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_DoctorDelete", altParams);
        }
    }
}
