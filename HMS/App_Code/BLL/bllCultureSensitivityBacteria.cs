
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
  public  class bllCultureSensitivityBacteria
    {
        dalCultureSentivityBacteria objBacteria = new dalCultureSentivityBacteria();
        public int Insert(CultureSensitivityBacteria bacteria)
        { 
            return objBacteria.Insert(bacteria);
        }

        public int Update(CultureSensitivityBacteria bacteria)
        {
            return objBacteria.Update(bacteria);
        }

        public int Delete(int BacteriaId)
        {
            return objBacteria.Delete(BacteriaId);
        }

        public DataTable GetAll()
        {
            return objBacteria.GetAll();
        }

        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objBacteria.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
    }
}
