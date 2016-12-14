using HMS.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.App_Code.BLL
{
    class bllPatient
    {
        dalPatient objPatient = new dalPatient();
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objPatient.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
        public DataTable GetAll()
        {
            return objPatient.GetAll();
        }
        public DataTable GetByID(int PatientID)
        {
            return objPatient.GetByPatientID(PatientID);
        }

        public DataTable GetByCode(int LabCode)
        {
            return objPatient.GetByPatientCode(LabCode);
        }

        public int Insert(string PatientCode,string Name, string Email, string Address, string MobileNo, int Age, string BloodGroup, string Image, string Gender, int RrefrById)
        {
            return objPatient.Insert(PatientCode,Name, Email, Address, MobileNo, Age, BloodGroup, Image, Gender, RrefrById);
        }

        public int Update(int PatientID, string PatientCode, string Name, string Email, string Address, string MobileNo, int Age, string BloodGroup, string Image, string Gender, int RrefrById)
        {
            return objPatient.Update(PatientID, PatientCode, Name, Email, Address, MobileNo, Age, BloodGroup,Image, Gender, RrefrById);
        }

        public int Delete(int PatientID)
        {
            return objPatient.Delete(PatientID);
        }
    }
}
