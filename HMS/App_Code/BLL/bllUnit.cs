using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.App_Code.BLL;

namespace HMS.App_Code.BLL
{
    public class bllUnit
    {
        dalUnit objUnit = new dalUnit();
        public DataTable GetAll(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objUnit.GetAll(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
        public DataTable GetList()
        {
            return objUnit.GetList();
        }
        public DataTable GetByID(int ServiceId)
        {
            return objUnit.GetByID(ServiceId);
        }

      


        public int Insert(string UnitName)
        {
            return objUnit.Insert(UnitName);
        }

        public int Update(int UnitId, string UnitName)
        {
            return objUnit.Update(UnitId, UnitName);
        }

        public int Delete(int UnitId)
        {
            return objUnit.Delete(UnitId);
        }
    }
}
