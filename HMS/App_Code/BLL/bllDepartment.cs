using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.App_Code.BLL;

namespace HMS.App_Code.BLL
{
    public class bllDepartment
    {
        dalDepartment objDepartment = new dalDepartment();
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objDepartment.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }

        public DataTable GetAllList()
        {
            return objDepartment.GetAll();
        }
        public DataTable GetByID(int DeptId)
        {
            return objDepartment.GetByDepartmentID(DeptId);
        }

        public int Insert(string DeptName, string Description)
        {
            return objDepartment.Insert(DeptName, Description);
        }

        public int Update(int DeptId, string DeptName, string Description)
        {
            return objDepartment.Update(DeptId,DeptName, Description);
        }

        public int Delete(int DeptId)
        {
            return objDepartment.Delete(DeptId);
        }
    }
}
