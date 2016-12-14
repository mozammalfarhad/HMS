using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.App_Code.DAL;
using HMS.Model;

namespace HMS.App_Code.BLL
{
   public class bllVat
    {
       public DataTable GetVatPercent()
       {
           return new dalVat().GetVatPercent();
       }

       public int Insert(Vat vat)
       {
           return new dalVat().Insert(vat);
       }
    }
}
