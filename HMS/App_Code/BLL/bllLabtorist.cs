using HMS.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.App_Code.BLL
{
    class bllLabtorist
    {
        dalLabtorist objDepartment = new dalLabtorist();
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objDepartment.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
        public DataTable GetByID(int LabId)
        {
            return objDepartment.GetByLabtoristCode(LabId);
        }

        public DataTable GetByCode(int LabCode)
        {
            return objDepartment.GetByLabtoristCode(LabCode);
        }

        public int Insert(string Name, string Email, string Address, string MobileNo, string Image, string Qualification, string Gender)
        {
            return objDepartment.Insert( Name, Email, Address, MobileNo, Image, Qualification, Gender);
        }

        public int Update(int LabId, string LabCode, string Name, string Email, string Address, string MobileNo, string Image, string Qualification, string Gender)
        {
            return objDepartment.Update(LabId, LabCode, Name, Email, Address, MobileNo, Image, Qualification, Gender);
        }

        public int Delete(int LabId)
        {
            return objDepartment.Delete(LabId);
        }
    }
}
