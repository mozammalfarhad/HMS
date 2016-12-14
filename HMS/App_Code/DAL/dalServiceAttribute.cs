using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIT.DataLogicLayer;

namespace HMS.App_Code.BLL
{
    public class dalServiceAttribute
    {
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceAttributeGetAll", altParams);
            return dt;
        }
        public DataTable GetAll()
        {
            ArrayList altParams = new ArrayList();
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceAttributeGetList", altParams);
            return dt;
        }
        public DataTable GetByID(int ServiceAttID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ServiceAttId", ServiceAttID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceAttributeGetById", altParams);
        }
        public DataTable GetByServiceID(int ServiceID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ServiceId", ServiceID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceAttributeGetByServiceId", altParams);
        }
        public int Insert(int ServiceId, string AttributeName, string MaleNormalRange, string FemaleNormalRange, int UnitId, string Comment)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ServiceId", ServiceId));
            altParams.Add(new SqlParameter("@AttributeName", AttributeName));
            altParams.Add(new SqlParameter("@MNormalRange", MaleNormalRange));
            altParams.Add(new SqlParameter("@FNormalRange", FemaleNormalRange));
            altParams.Add(new SqlParameter("@UnitId", UnitId));
            altParams.Add(new SqlParameter("@Comment", Comment));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ServiceAttributeInsert", altParams);
        }
        public int Update(int ServiceId, string AttributeName, int SerAtId, string MaleNormalRange, string FemaleNormalRange, int UnitId, string Comment)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@SerAtId", SerAtId));
            altParams.Add(new SqlParameter("@ServiceId", ServiceId));
            altParams.Add(new SqlParameter("@AttributeName", AttributeName));
            altParams.Add(new SqlParameter("@MNormalRange", MaleNormalRange));
            altParams.Add(new SqlParameter("@FNormalRange", FemaleNormalRange));
            altParams.Add(new SqlParameter("@UnitId", UnitId));
            altParams.Add(new SqlParameter("@Comment", Comment));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("SP_ServiceAttributeUpdate", altParams);
        }
        public int Delete(int ServiceId)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@SerAtId", ServiceId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ServiceAttributeDelete", altParams);
        }
    }
}
