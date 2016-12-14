using HMS.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.App_Code.BLL
{
    class bllDoctor
    {
        dalDoctor objDepartment = new dalDoctor();
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objDepartment.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
        public DataTable GetByID(int DoctorId)
        {
            return objDepartment.GetByDoctorID(DoctorId);
        }

        public DataTable GetAllCode()
        {
            return objDepartment.GetAllDoctorCode();
        }
        public DataTable GetAllDoctorList()
        {
            return objDepartment.GetAllDoctorList();
        }

        public DataTable GetByCode(int DoctorCode)
        {
            return objDepartment.GetByDoctorCode(DoctorCode);
        }

        public int Insert( string Name, string Email, string Address, string MobileNo, int DepartmentId, string Image, string Qualification, string Gender)
        {
            return objDepartment.Insert(Name, Email, Address, MobileNo, DepartmentId, Image, Qualification, Gender);
        }

        public int Update(int DoctorId, string DoctorCode, string Name, string Email, string Address, string MobileNo, int DepartmentId, string Image, string Qualification, string Gender)
        {
            return objDepartment.Update(DoctorId, DoctorCode, Name, Email, Address, MobileNo, DepartmentId, Image, Qualification, Gender);
        }

        public int Delete(int DoctorId)
        {
            return objDepartment.Delete(DoctorId);
        }
    }
}
