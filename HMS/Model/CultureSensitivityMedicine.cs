using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Model
{
    public class CultureSensitivityMedicine
    {
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string Description { get; set; }

        public CultureSensitivityMedicine()
        {
            this.MedicineId = 0;
            this.MedicineName = "";
            this.Description = "";
        }
        public CultureSensitivityMedicine(int MedicineId, string MedicineName, string Description)
        {
            this.MedicineId = MedicineId;
            this.MedicineName = MedicineName;
            this.Description = Description;
        }

    }
}
