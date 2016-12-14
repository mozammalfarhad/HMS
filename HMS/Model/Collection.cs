using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Model
{
    class Collection
    {
        public int CollId{get;set;}
        public int ScheduleId{get;set;}
        public decimal PaidAmount{get;set;}
        public bool isCash{get;set;}
        public int UserId{get;set;}
        public string userName { get; set; }
        public DateTime Date{get;set;}
        public Collection()
        {
            this.CollId = 0;
            this.ScheduleId = 0;
            this.PaidAmount = 0;
            this.isCash = false;
            this.UserId = 0;
            this.userName = "";
            this.Date = DateTime.Now;
        }

        public Collection(int CollId, int ScheduleId, decimal PaidAmount, bool isCash, int UserId,string userName, DateTime Date)
        {
            this.CollId = CollId;
            this.ScheduleId = ScheduleId;
            this.PaidAmount = PaidAmount;
            this.isCash = isCash;
            this.UserId = UserId;
            this.userName = userName;
            this.Date = Date;
        }
    }
   
}
