using System;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using ExtraFunctions;

namespace EA_Logistics_Control.Models
{
    class CCities
    {
        public int CityID { get; set; }
        public string Name { get; set; }
        public int StateID { get; set; }
        public string strError = "";

        static DataTable DT;

        /// <summary>
        /// Returns a DataTable instance with all matching rows from database based on flag and primary id, name or foreign id.
        /// </summary>
        /// <param name="flag">Conditional parameter that decides which conditional column to check among primary id, name and foreign id</param>
        /// <param name="cid">Primary Key as ID of table that can be compared to get single row</param>
        /// <param name="cname">Row that matches exact name can be retrieved using Name</param>
        /// <param name="sid">Foreign Key of table as ID that can be compared to retrieve set of multiple records</param>
        /// <returns></returns>
        public static DataTable getAllData(string flag, string cid = null, string cname = null, string sid = null)
        {
            try
            {
                DT = new DataTable();
                DBAccess da = new DBAccess();
                da.CommandText = "sp_ealog_cities_select";
                da.Parameters.Add(new SqlParameter("flag", flag));
                da.Parameters.Add(new SqlParameter("cid", cid));
                da.Parameters.Add(new SqlParameter("cname", cname));
                da.Parameters.Add(new SqlParameter("sid", cname));
                DT = da.getDataTable();
                return DT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Returns a Class instance having properties mapped with values from single matching row from database based on flag and primary id, name or foreign id.
        /// </summary>
        /// <param name="flag">Conditional parameter that decides which conditional column to check among primary id, name and foreign id</param>
        /// <param name="cid">Primary Key as ID of table that can be compared to get single row</param>
        /// <param name="cname">Row that matches exact name can be retrieved using Name</param>
        /// <returns></returns>
        public static CCities getInstance(string flag, string cid = null, string cname = null)
        {
            CCities cTemp;
            object ObjVar;
            try
            {
                int propCount = 0;
                cTemp = new CCities();
                DT.Clear();
                DT = getAllData(flag, cid, cname);

                foreach (PropertyInfo pi in cTemp.GetType().GetProperties())
                {
                    if (!DT.Rows[0].IsNull(propCount))
                    {
                        ObjVar= DT.Rows[0][propCount];
                        pi.SetValue(cTemp, ObjVar);
                    }
                    propCount++;
                }
                return cTemp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (DT != null)
                    DT.Clear();
                ObjVar = null;
                cTemp = null;
            }
        }
    }
}
