using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.App_Code.BLL;

namespace HMS.App_Code.BLL
{
    public class bllServiceAttribute
    {
        dalServiceAttribute objService = new dalServiceAttribute();
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objService.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
        public DataTable GetByServiceID(int ServiceId)
        {
            return objService.GetByServiceID(ServiceId);
        }
        public DataTable GetByID(int AttributeId)
        {
            return objService.GetByID(AttributeId);
        }
        public DataTable GetAll()
        {
            return objService.GetAll();
        }


        public int Insert(int ServiceId, string AttributeName, string MaleNormalRange, string FemaleNormalRange, int UnitId, string Comment)
        {
            return objService.Insert(ServiceId, AttributeName, MaleNormalRange, FemaleNormalRange, UnitId, Comment);
        }

        public int Update(int SerAttId, int ServiceId, string AttributeName, string MaleNormalRange, string FemaleNormalRange, int UnitId, string Comment)
        {
            return objService.Update(ServiceId, AttributeName, SerAttId, MaleNormalRange, FemaleNormalRange, UnitId,Comment);
        }

        public int Delete(int SerAttId)
        {
            return objService.Delete(SerAttId);
        }
    }
}
