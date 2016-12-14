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
    public class dalConsultant
    {
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ConsultantGetAll", altParams);
            return dt;
        }

        public DataTable GetAllConsultantList()
        {
            ArrayList altParams = new ArrayList();
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ConsultantGetList", altParams);
            return dt;
        }
        public DataTable GetLaboratoristList()
        {
            ArrayList altParams = new ArrayList();
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_LaboratoristGetList", altParams);
            return dt;
        }
        
        public DataTable GetByConsultantID(int DoctorId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ConsultantId", DoctorId));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ConsultantGetByID", altParams);
        }
          public DataTable GetAllConsultantCode()
        {
            ArrayList altParams = new ArrayList();
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ConsultantCodeGetAll", altParams);
        }
        
        public DataTable GetByConsultantCode(int ConsultantCode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ConsultantCode", ConsultantCode));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ConsultantGetByCode", altParams);
        }
        public int Insert(string Name, string Email, string Address, string MobileNo, int DepartmentId, string Image, string Qualification, string Gender, int ConsultantTypeId)
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
            altParams.Add(new SqlParameter("@ConsultantTypeId", ConsultantTypeId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ConsultantInsert", altParams);
        }
        public int Update(int ConsultantId, string ConsultantCode, string Name, string Email, string Address, string MobileNo, int DepartmentId, string Image, string Qualification, string Gender, int ConsultantTypeId)
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
            altParams.Add(new SqlParameter("@ConsultantCode", ConsultantCode));
            altParams.Add(new SqlParameter("@ConsultantId", ConsultantId));
            altParams.Add(new SqlParameter("@ConsultantTypeId", ConsultantTypeId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("SP_ConsultantUpdate", altParams);
        }
        public int Delete(int ConsultantId)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ConsultantId", ConsultantId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ConsultantDelete", altParams);
        }
    }
}
