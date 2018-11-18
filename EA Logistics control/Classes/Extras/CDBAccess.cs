using System;
//  additional namepsaces
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ExtraFunctions
{
    public class DBAccess
    {
        
        SqlConnection SCon;
        SqlCommand SCom;
        SqlDataAdapter SDA;
        DataTable DT;

        public DBAccess()
        {
            SCon =  new SqlConnection(ConfigurationManager.ConnectionStrings["EA_Logistics_Control.Properties.Settings.LogisticsLocalDBCS"].ConnectionString);
            SCom = new SqlCommand();
            SCom.Connection = SCon;
            SCom.CommandType = CommandType.StoredProcedure;
        }
        
        public string ConStr
        {
            get
            {
                if (SCon.ConnectionString == null)
                    return "";
                return SCon.ConnectionString;
            }
            set
            {
                SCon = new SqlConnection(value.ToString());
            }
        }

        public string CommandText
        {
            get
            {
                return SCom.CommandText;
            }
            set
            {
                SCom.CommandText = value;
            }
        }

        public CommandType CommandType
        {
            get
            {
                return SCom.CommandType;
            }
            set
            {
                SCom.CommandType = value;
            }
        }

        public IDataParameterCollection Parameters
        {
            get
            {
                return SCom.Parameters;
            }
        }

        public static DataTable GetKeyValueDataTable(string Key, string Value, string TableName)
        {
            DataTable DT;
            DBAccess c;
            try
            {
                c = new DBAccess();
                c.CommandText = "sp_ealog_GetKeyValue";
                c.Parameters.Add(new SqlParameter("key", Key));
                c.Parameters.Add(new SqlParameter("value", Value));
                c.Parameters.Add(new SqlParameter("table", TableName));
                DT = c.getDataTable();
                return DT;
            }
            finally
            {
                c = null;
                DT = null;
            }
        }

        /// <summary>
        /// Returns a DataSet instance containing data which was queried based on Connection and Command string parameters.
        /// </summary>
        /// <param name="SqlCon">The SQL connection string.</param>
        /// <param name="SqlCom">The SQL command string.</param>
        /// <returns></returns>
        public DataTable getDataTable()
        {
            SDA = new SqlDataAdapter();
            DT = new DataTable();
            try
            {
                SDA.SelectCommand = SCom;
                SDA.SelectCommand.Connection = SCon;

                if (SCon.State == ConnectionState.Closed)
                    SCon.Open();
                SDA.Fill(DT);
            }
            finally
            {
                if (SCon != null)
                {
                    SCon.Close();
                }
                if (SDA != null)
                {
                    SDA = null;
                }
            }
            return DT;
        }

        public int ExecuteNonQuery()
        {
            try
            {
                using (SCon)
                {
                    SCon.Open();
                    return SCom.ExecuteNonQuery();
                }
            }
            finally
            {
                if (SCon != null)
                {
                    SCon.Close();
                }
            }
        }

        /// <summary>
        /// Although this method executes inline sql queries rather than stored procedures, it is written to work in case other methods are not applicable.
        /// </summary>
        /// <param name="cmdText">This parameter takes stored procedure</param>
        /// <returns></returns>
        public static DataTable ExecuteSpDataSet(string cmdText)
        {
            SqlDataAdapter SDA = new SqlDataAdapter();
            DataTable DT = new DataTable();
            try
            {
                SDA.SelectCommand.CommandText = cmdText;
                SDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                SDA.Fill(DT);
                return DT;
            }
            finally
            {
                if (SDA != null)
                {
                    SDA = null;
                }
            }
        }

        /// <summary>
        /// Although this method executes inline sql queries rather than stored procedures, it is written to work in case other methods are not applicable.
        /// </summary>
        /// <param name="cmdText">Inline select query is passed through this variable.</param>
        /// <returns></returns>
        public static DataTable ExecuteQueryDataSet(string cmdText)
        {
            SqlDataAdapter SDA = new SqlDataAdapter();
            DataTable DT = new DataTable();
            try
            {
                SDA.SelectCommand.CommandText = cmdText;
                SDA.Fill(DT);
                return DT;
            }
            finally
            {
                if (SDA != null)
                {
                    SDA = null;
                }
            }
        }

        /// <summary>
        /// Returns a boolean value determining whether a value in a specific column of a specific table existed.
        /// </summary>
        /// <param name="tableName">Name of the table in which value might exist.</param>
        /// <param name="existCol">Name of the column which may contain specific value.</param>
        /// <param name="existVal">Value to be checked for existance in specific table.</param>
        public static bool checkDuplicate(string tableName, string existCol, string existVal)
        {
            bool result = false;
            SqlCommand SCom = new SqlCommand();
            SqlConnection SCon = new SqlConnection();
            try
            {
                SCom.CommandText="sp_CheckDuplicate";
                SCon = new SqlConnection(ConfigurationManager.ConnectionStrings["EA_Logistics_Control.Properties.Settings.LogisticsLocalDBCS"].ConnectionString);
                SCom.Connection = SCon;
                SCom.CommandType = CommandType.StoredProcedure;

                SCom.Parameters.AddWithValue("table", tableName);
                SCom.Parameters.AddWithValue("compare", existCol);
                SCom.Parameters.AddWithValue("param", existVal);

                SqlParameter sp = new SqlParameter("retval", SqlDbType.Bit);
                sp.Direction = ParameterDirection.Output;
                SCom.Parameters.Add(sp);

                if (SCon.State==ConnectionState.Closed)
                    SCon.Open();

                SCom.ExecuteNonQuery();
                bool.TryParse(sp.Value.ToString(), out result);
            }
            catch (Exception Ex)
            {
                throw Ex;
                //if (Ex is SqlException)
                //    iErrId = -126;
                //else
                //    iErrId = -1;
                //setErrorLog(iErrId, Ex.Message);
            }
            finally
            {
                if (SCon !=null)
                {
                    SCon.Close();
                }
                if (SCom != null)
                {
                    SCom = null;
                }
            }
            return result;
        }

        /// <summary>
        /// General static method for retrieving single value based on a conditional value. It takes table name, column to return, comparison column and comparison value
        /// </summary>
        /// <param name="table"></param>
        /// <param name="retrieve"></param>
        /// <param name="compare"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object getScalar(string retrieve, string table, string compare, string param)
        {
            DataTable DT;
            DBAccess cda;
            try
            {
                cda = new DBAccess();
                cda.CommandText = "sp_ealog_GetScalar";
                cda.Parameters.Add(new SqlParameter("retrieve", retrieve));
                cda.Parameters.Add(new SqlParameter("table", table));
                cda.Parameters.Add(new SqlParameter("compare", compare));
                cda.Parameters.Add(new SqlParameter("param", param));
                DT = cda.getDataTable();
                return DT.Rows[0][0];
            }
            catch (Exception ex)
            {
                CLogger.setErrorLog(1, ex.Message);
                return null;
            }
            finally
            {
                DT = null;
            }
        }

        /// <summary>
        /// temporary method that reduces code... to get max id from a table.
        /// </summary>
        internal static int GetMaxNext(string get, string from, string where)
        {
            var testCSMNO = new object();
            try
            {
                testCSMNO = DBAccess.getScalar(get, from, where, null);
                int Eno = -1;
                if (testCSMNO != DBNull.Value && testCSMNO != null)
                    Eno = Convert.ToInt32(testCSMNO);
                else
                    Eno = 0;

                return Eno + 1;
            }
            finally
            {
                testCSMNO = null;
                get = null;
                from = null;
                where = null;
            }
        }
    }
}
