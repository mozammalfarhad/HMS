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
    class bllCollection
    {
        dalCollection col = new dalCollection();
        public bllCollection()
        {
        }

        public DataTable GetCollectionByScheduleID(int ScheduleId)
        {
            return col.GetCollectionByScheduleID(ScheduleId);
        }

        public int Insert(Collection collection)
        {
            return col.Insert(collection);
        }

        public int Update(Collection collection)
        {
            return col.Update(collection);
        }
    }
}
