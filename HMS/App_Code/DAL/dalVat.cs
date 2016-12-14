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
    public class dalVat
    {
        public DataTable GetVatPercent()
        {
            ArrayList altParams = new ArrayList();
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("sp_VatGet", altParams);
        }
        public int Insert(Vat vat)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@VatId", vat.VatId));
            altParams.Add(new SqlParameter("@VatPercent", vat.VatPercent));
            altParams.Add(new SqlParameter("@Description", vat.Description));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("sp_VatinsertUpdate", altParams);
        }
    }
}
