using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.App_Code.DAL;

namespace HMS.App_Code.BLL
{
    public class bllConsultantType
    {
        dalConsultantType objConsultantType = new dalConsultantType();
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objConsultantType.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
        public DataTable GetByID(int ConsultantTypeIdId)
        {
            return objConsultantType.GetByConsultantTypeId(ConsultantTypeIdId);
        }

        public DataTable GetAllConsultantTypeList()
        {
            return objConsultantType.GetAllConsultantTypeList();
        }

        public int Insert(string ConsultantTypeName)
        {
            return objConsultantType.Insert(ConsultantTypeName);
        }

        public int Update(int ConsultantTypeId, string ConsultantTypeName)
        {
            return objConsultantType.Update(ConsultantTypeId, ConsultantTypeName);
        }

        public int Delete(int ConsultantTypeId)
        {
            return objConsultantType.Delete(ConsultantTypeId);
        }
    }
}
