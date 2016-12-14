using HMS.App_Code.DAL;
using HMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.App_Code.BLL
{
    class bllReferFee
    {

        dalReferFee objService = new dalReferFee();
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objService.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
        public DataTable GetByID(int referId)
        {
            return objService.GetByreferId(referId);
        }

        public DataTable GetAll()
        {
            return objService.GetAll();
        }
        public DataTable GetByTypeID(int typeId)
        {
            return objService.GetByTypeID(typeId);
        }

        public int Insert(ReferFee refer)
        {
            return objService.Insert(refer);
        }

        public int Update(ReferFee refer)
        {
            return objService.Update(refer);
        }

        public int Delete(int referId)
        {
            return objService.Delete(referId);
        }
    }
}
