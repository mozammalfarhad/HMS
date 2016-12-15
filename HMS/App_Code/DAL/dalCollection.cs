using HMS.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIT.DataLogicLayer;

namespace HMS.App_Code.DAL
{
    class dalCollection
    {
        public DataTable GetCollectionByScheduleID(int ScheduleId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ScheduleId", ScheduleId));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_CollectionGetBySheduleId", altParams);
        }
        public int Insert(Collection collection)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ScheduleId", collection.ScheduleId));
            altParams.Add(new SqlParameter("@PaidAmount", collection.PaidAmount));
            altParams.Add(new SqlParameter("@isCash", collection.isCash));
            altParams.Add(new SqlParameter("@UserName", collection.userName));
            altParams.Add(new SqlParameter("@Date", collection.Date));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_CollectionInsert", altParams);
        }

        public int Update(Collection collection)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@CollId", collection.CollId));
            altParams.Add(new SqlParameter("@ScheduleId", collection.ScheduleId));
            altParams.Add(new SqlParameter("@PaidAmount", collection.PaidAmount));
            altParams.Add(new SqlParameter("@isCash", collection.isCash));
            altParams.Add(new SqlParameter("@UserName", collection.userName));
            altParams.Add(new SqlParameter("@Date", collection.Date));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_CollectionUpdate", altParams);
        }

        public DataTable GetDueCollection(DateTime DateFrom,DateTime DateTo)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@FromDate", DateFrom));
            altParams.Add(new SqlParameter("@ToDate", DateTo));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("rpt_DueListGetByDateRange", altParams);
        }
    }
}
