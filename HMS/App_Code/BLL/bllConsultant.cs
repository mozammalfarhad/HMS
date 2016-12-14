using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.App_Code.DAL;

namespace HMS.App_Code.BLL
{
    public class bllConsultant
    {
        dalConsultant objConsultant = new dalConsultant();
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objConsultant.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
        public DataTable GetByID(int ConsultantId)
        {
            return objConsultant.GetByConsultantID(ConsultantId);
        }

        public DataTable GetAllCode()
        {
            return objConsultant.GetAllConsultantCode();
        }
        public DataTable GetAllConsultantList()
        {
            return objConsultant.GetAllConsultantList();
        }
        public DataTable GetLaboratoristList()
        {
            return objConsultant.GetLaboratoristList();
        }
        public DataTable GetByCode(int ConsultantCode)
        {
            return objConsultant.GetByConsultantCode(ConsultantCode);
        }

        public int Insert(string Name, string Email, string Address, string MobileNo, int DepartmentId, string Image, string Qualification, string Gender, int consultantTypeId)
        {
            return objConsultant.Insert(Name, Email, Address, MobileNo, DepartmentId, Image, Qualification, Gender, consultantTypeId);
        }

        public int Update(int ConsultantId, string ConsultantCode, string Name, string Email, string Address, string MobileNo, int DepartmentId, string Image, string Qualification, string Gender, int consultantTypeId)
        {
            return objConsultant.Update(ConsultantId, ConsultantCode, Name, Email, Address, MobileNo, DepartmentId, Image, Qualification, Gender, consultantTypeId);
        }

        public int Delete(int ConsultantId)
        {
            return objConsultant.Delete(ConsultantId);
        }

    }
}
