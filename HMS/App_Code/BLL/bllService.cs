using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.App_Code.BLL;

namespace HMS.App_Code.BLL
{
    public class bllService
    {
        dalService objService = new dalService();
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objService.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
        public DataTable GetByID(int ServiceId)
        {
            return objService.GetByServiceID(ServiceId);
        }

        public DataTable GetAll()
        {
            return objService.GetAll();
        }
        public DataTable GetByTypeID(int typeId)
        {
            return objService.GetByTypeID(typeId);
        }

        public int Insert(int TypeId, string ServiceName, string ServiceShortName, string MaleNormalRange, string FemaleNormalRange, int UnitId, decimal Rate, decimal Discount, bool isChecked)
        {
            return objService.Insert(ServiceName, TypeId, ServiceShortName, MaleNormalRange, FemaleNormalRange, UnitId, Rate, Discount, isChecked);
        }

        public int Update(int ServiceId, int TypeId, string ServiceName, string ServiceShortName, string MaleNormalRange, string FemaleNormalRange, int UnitId, decimal Rate, decimal Discount, bool isChecked)
        {
            return objService.Update(ServiceId, ServiceName, TypeId, ServiceShortName, MaleNormalRange, FemaleNormalRange, UnitId,Rate,Discount,isChecked);
        }

        public int Delete(int ServiceId)
        {
            return objService.Delete(ServiceId);
        }
    }
}
