using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Model
{
   public class Vat
    {
          public int VatId{get;set;}
        public decimal VatPercent{get;set;}
        public string Description { get; set; }
        public Vat()
        {
            this.VatId = 0;
            this.VatPercent = 0;
            this.Description = "";
        }

        public Vat(int VatId, decimal VatPercent, string Description)
        {
            this.VatId = VatId;
            this.VatPercent = VatPercent;
            this.Description = Description;
        }
    }
}
