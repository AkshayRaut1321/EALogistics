using System;
using System.Data.SqlClient;
using System.Data;
using ExtraFunctions;

namespace EA_Logistics_Control.Models
{
    class CParties
    {
        public int PartyID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public int StateID { get; set; }

        static DataTable DT;

        public static DataTable getAllData(string flag, string pid = null, string pname = null)
        {
            try
            {
                DBAccess da = new DBAccess();
                da.Parameters.Add(new SqlParameter("flag", flag));

                if (pid != null)
                    da.Parameters.Add(new SqlParameter("pid", pid));

                if (pname != null)
                    da.Parameters.Add(new SqlParameter("pname", pname));
                
                da.CommandText = "sp_ealog_parties_select";
                DT = da.getDataTable();
                return DT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static object getScalar(string flag, string pid = null, string pname = null)
        {
            try
            {
                return getAllData(flag, pid, pname).Rows[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
