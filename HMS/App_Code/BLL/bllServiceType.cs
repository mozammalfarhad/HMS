using HMS.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.App_Code.BLL
{
    class bllServiceType
    {
        dalServiceType objServiceType = new dalServiceType();
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objServiceType.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
        public DataTable GetAll()
        {
            return objServiceType.GetAll();
        }
        public DataTable GetByID(int TypeId)
        {
            return objServiceType.GetByServiceTypeByID(TypeId);
        }

        public int Insert(string TypeName)
        {
            return objServiceType.Insert(TypeName);
        }

        public int Update(int TypeId, string TypeName)
        {
            return objServiceType.Update(TypeId, TypeName);
        }

        public int Delete(int DeptId)
        {
            return objServiceType.Delete(DeptId);
        }
    }
}
