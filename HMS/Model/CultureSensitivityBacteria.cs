using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Model
{
    public class CultureSensitivityBacteria
    {
        public int BacteriaId { get; set; }
        public string BacteriaName { get; set; }
        public string Description { get; set; }

        public CultureSensitivityBacteria()
        {
            this.BacteriaId = 0;
            this.BacteriaName = "";
            this.Description = "";
        }
        public CultureSensitivityBacteria(int BacteriaId, string BacteriaName, string Description)
        {
            this.BacteriaId = BacteriaId;
            this.BacteriaName = BacteriaName;
            this.Description = Description;
        }
    }
}
