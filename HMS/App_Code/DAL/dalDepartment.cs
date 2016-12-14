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
    public class dalDepartment
    {
        public DataTable GetList(int StartRowIndex,int MaxRows, string Criteria,bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_departmentGetAll", altParams);
            return dt;
        }
        public DataTable GetAll()
        {
            DataTable dt = DatabaseManager.GetInstance().GetDataTable("select * from   Department ");
            return dt;
        }
        public DataTable GetByDepartmentID(int DeptID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@DepId", DeptID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_DepartmentGetByID", altParams);
        }
        public int Insert(string DeptName, string Description)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@DepartmentName", DeptName));
            altParams.Add(new SqlParameter("@Description", Description));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_DepartmentInsert", altParams);
        }
        public int Update(int DeptId,string DeptName, string Description)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@DepartmentName", DeptName));
            altParams.Add(new SqlParameter("@Description", Description));
            altParams.Add(new SqlParameter("@DepId", DeptId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_DepartmentUpdate", altParams);
        }
        public int Delete(int DeptId)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@DepId", DeptId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_DepartmentDelete", altParams);
        }
    }
}
