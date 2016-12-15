using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Model
{
   public class CompanyInformation
    {
        public int CompanyId{get;set;}
        public string ComapayName{get;set;}
        public string Logo{get;set;}
        public string Address{get;set;}
        public string Tel{get;set;}
        public string Mobile{get;set;}
        public string Fax{get;set;}

        public string Email { get; set; }
        public string Web { get; set; }
        public CompanyInformation()
        {
            this.CompanyId = 0;
            this.ComapayName = "";
            this.Address = "";
            this.Fax = "";
            this.Logo = "";
            this.Mobile = "";
            this.Tel = "";
            this.Email = "";
            this.Web = "";
        }

        public CompanyInformation(int CompanyId, string ComapayName, string Logo, string Address, string Tel, string Mobile, string Fax, string Email, string Web)
        {
            this.CompanyId = CompanyId;
            this.ComapayName = ComapayName;
            this.Address = Address;
            this.Fax = Fax;
            this.Logo = Logo;
            this.Mobile = Mobile;
            this.Tel = Tel;
            this.Email = Email;
            this.Web = Web;
        }
    }
}

