using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.App_Code.DAL;

namespace HMS.App_Code.BLL
{
    public class bllVacuum
    {
        dalVacuum objVacuum = new dalVacuum();
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objVacuum.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
        public DataTable GetByID(int VacuumId)
        {
            return objVacuum.GetByID(VacuumId);
        }
        public DataTable GetByServiceID(int ServiceId)
        {
            return objVacuum.GetByServiceID(ServiceId);
        }
        public DataTable GetAll()
        {
            return objVacuum.GetAll();
        }
        public int Insert(int ServiceId, string VacuumName, string Description, decimal VacuumPrice)
        {
            return objVacuum.Insert(ServiceId, VacuumName, Description, VacuumPrice);
        }

        public int Update(int VacuumId, int ServiceId, string VacuumName, string Description, decimal VacuumPrice)
        {
            return objVacuum.Update(VacuumId,ServiceId, VacuumName, Description, VacuumPrice);
        }
        public int Delete(int VacuumId)
        {
            return objVacuum.Delete(VacuumId);
        }
    }
}
