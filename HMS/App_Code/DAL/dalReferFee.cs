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
    class dalReferFee
    {

        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ReferFeeGetAll", altParams);
            return dt;
        }
        public DataTable GetAll()
        {
            ArrayList altParams = new ArrayList();
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceGetList", altParams);
            return dt;
        }
        public DataTable GetByTypeID(int typeId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ServiceTypeId", typeId));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceGetByTypeId", altParams);
            return dt;
        }
        public DataTable GetByreferId(int ReferFeeID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ReferFeeId", ReferFeeID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ReferFeeGetByID", altParams);
        }
        public int Insert(ReferFee refer)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ServiceId", refer.ServiceId));
            altParams.Add(new SqlParameter("@FeePercent", refer.FeePercent));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ReferFeeInsert", altParams);
        }
        public int Update(ReferFee refer)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ServiceId", refer.ServiceId));
            altParams.Add(new SqlParameter("@FeePercent", refer.FeePercent));
            altParams.Add(new SqlParameter("@ReferFeeId", refer.ReferFeeId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("SP_ReferFeeUpdate", altParams);
        }
        public int Delete(int referId)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ReferFeeId", referId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ReferFeeDelete", altParams);
        }
    }
}
