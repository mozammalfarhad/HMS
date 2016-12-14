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
    public class dalService
    {
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@StartRowIndex", StartRowIndex));
            altParams.Add(new SqlParameter("@MaxRows", MaxRows));
            altParams.Add(new SqlParameter("@Criteria", Criteria));
            altParams.Add(new SqlParameter("@PrintMode", PrintMode));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceGetAll", altParams);
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
        public DataTable GetByServiceID(int ServiceID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ServiceId", ServiceID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_ServiceGetById", altParams);
        }
        public int Insert(string ServiceName, int TypeId, string ServiceShortName, string MaleNormalRange, string FemaleNormalRange, int UnitId, decimal Rate, decimal Discount, bool isChecked)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@TypeId", TypeId));
            altParams.Add(new SqlParameter("@ServiceName", ServiceName));
            altParams.Add(new SqlParameter("@ServiceShortName", ServiceShortName));
            altParams.Add(new SqlParameter("@MaleNormalRange", MaleNormalRange));
            altParams.Add(new SqlParameter("@FemaleNormalRange", FemaleNormalRange));
            altParams.Add(new SqlParameter("@UnitId", UnitId));
            altParams.Add(new SqlParameter("@Rate", Rate));
            altParams.Add(new SqlParameter("@Discount", Discount));
            altParams.Add(new SqlParameter("@HasAttribute", isChecked));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ServiceInsert", altParams);
        }
        public int Update(int ServiceId, string ServiceName, int TypeId, string ServiceShortName, string MaleNormalRange, string FemaleNormalRange, int UnitId, decimal Rate, decimal Discount, bool isChecked)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ServiceId", ServiceId));
            altParams.Add(new SqlParameter("@TypeId", TypeId));
            altParams.Add(new SqlParameter("@ServiceName", ServiceName));
            altParams.Add(new SqlParameter("@ServiceShortName", ServiceShortName));
            altParams.Add(new SqlParameter("@MaleNormalRange", MaleNormalRange));
            altParams.Add(new SqlParameter("@FemaleNormalRange", FemaleNormalRange));
            altParams.Add(new SqlParameter("@UnitId", UnitId));
            altParams.Add(new SqlParameter("@Discount", Discount));
            altParams.Add(new SqlParameter("@Rate", Rate));
            altParams.Add(new SqlParameter("@HasAttribute", isChecked));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("SP_ServiceUpdate", altParams);
        }
        public int Delete(int ServiceId)
        {

            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ServiceId", ServiceId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Sp_ServiceDelete", altParams);
        }
    }
}
