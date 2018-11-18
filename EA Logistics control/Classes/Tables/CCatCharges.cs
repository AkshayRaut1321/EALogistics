using System;
using System.Data.SqlClient;
using System.Data;
using ExtraFunctions;

namespace EA_Logistics_Control.Models
{
    class CCatCharges
    {
        static DataTable DT;

        public static DataTable getDataAll(string flag, string cid = "")
        {
            try
            {
                DBAccess da = new DBAccess();

                da.CommandText = "sp_ealog_catcharges_select";
                da.Parameters.Add(new SqlParameter("flag", flag));
                if (cid != null)
                    da.Parameters.Add(new SqlParameter("cid", cid));

                DT = da.getDataTable();
                return DT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
