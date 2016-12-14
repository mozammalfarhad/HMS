using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Model
{
    public class ReferFee
    {
        public int ReferFeeId{get;set;}
        public int ServiceId{get;set;}
        public float FeePercent{get;set;}

        public ReferFee()
        {
            this.ReferFeeId = 0;
            this.ServiceId = 0;
            this.FeePercent = 0;
        }

        public ReferFee(int ReferFeeId, int ServiceId, float FeePercent)
        {
            this.ReferFeeId = ReferFeeId;
            this.ServiceId = ServiceId;
            this.FeePercent = FeePercent;
        }
    }
}
