
using HMS.DAL;
using HMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BLL
{
    public class bllCultureSensitivityMedicine
    {
        dalCultureSensitivityMedicine objMedicine = new dalCultureSensitivityMedicine();
        public int Insert(CultureSensitivityMedicine medicine)
        {
            return objMedicine.Insert(medicine);
        }

        public int Update(CultureSensitivityMedicine medicines)
        {
            return objMedicine.Update(medicines);
        }

        public int Delete(int MedicineId)
        {
            return objMedicine.Delete(MedicineId);
        }
        public DataTable GetAll()
        {
            return objMedicine.GetAll();
        }

        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objMedicine.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
    }
}
