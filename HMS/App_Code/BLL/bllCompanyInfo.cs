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
   public class bllCompanyInfo
    {

        dalCompanyInfo objCom = new dalCompanyInfo();
        public DataTable GetCompanyInfo()
        {
            return objCom.GetByCompanyInfo();
        }
        public int Insert(CompanyInformation compay)
        {
            return objCom.Insert(compay);
        }
        public int Update(CompanyInformation compay)
        {
            return objCom.Update(compay);
        }

    }
}

