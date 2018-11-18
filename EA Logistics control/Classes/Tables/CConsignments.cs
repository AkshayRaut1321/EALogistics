using System;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using ExtraFunctions;

namespace EA_Logistics_Control.Models
{
    class CConsignments
    {
        public string strError = "";

        #region Properties
        public int ConsignmentNo { get; set; }
        public int BillNo { get; set; }
        public DateTime ConsignmentDate { get; set; }
        public string InvoiceNo { get; set; }
        public int SignorID { get; set; }
        public int SigneeID { get; set; }
        public int TravelFromID { get; set; }
        public int TravelToID { get; set; }
        public int Packages { get; set; }
        public string Contents { get; set; }
        public string VehicleNo { get; set; }
        public decimal Rate { get; set; }
        public decimal Weight { get; set; }
        public decimal Amount { get; set; }
        public bool Billed { get; set; }
        public string SignorStr { get; set; }
        public string SigneeStr { get; set; }
        public string TravelFromStr { get; set; }
        public string TravelToStr { get; set; }

        public PropertyInfo[] ExclusiveProperties
        {
            get;
            private set;
            //{
            //    return ExclusiveProps;
            //}
        }

        public PropertyInfo[] GridProperties
        {
            get;
            private set;
            //{
            //    return GridProps;
            //}
        }
        #endregion

        #region methods
        public CConsignments()
        {
            Billed = false;
            IEnumerable<PropertyInfo> propsIEnum = this.GetType().GetProperties().Where(x => x.Name != "SignorID" && x.Name != "SigneeID" && x.Name != "TravelFromID" && x.Name != "TravelToID" && x.Name != "GridProperties" && x.Name != "ExclusiveProperties");
            GridProperties = propsIEnum.ToArray();
            propsIEnum = this.GetType().GetProperties().Where(x => x.Name != "SignorStr" && x.Name != "SigneeStr" && x.Name != "TravelFromStr" && x.Name != "TravelToStr" && x.Name != "GridProperties" && x.Name != "ExclusiveProperties");
            ExclusiveProperties = propsIEnum.ToArray();
            propsIEnum = null;
        }

        /// <summary>
        /// Returns a DataTable instance with all matching rows from database based on primary id, name or foreign id.
        /// </summary>
        /// <param name="cno">Primary Key as ID of table that can be compared to get single row</param>
        /// <param name="cname">Row that matches exact name can be retrieved using Name</param>
        /// <param name="sid">Foreign Key of table as ID that can be compared to retrieve set of multiple records</param>
        /// <returns></returns>
        public static DataTable getAllData(string cno = null, bool billed = false)
        {
            DataTable DT = new DataTable();
            try
            {
                DBAccess da = new DBAccess();
                da.CommandText = "sp_ealog_consignments";
                da.Parameters.Add(new SqlParameter("option", "retrieve"));
                da.Parameters.Add(new SqlParameter("consignmentno", cno));
                da.Parameters.Add(new SqlParameter("billed", billed));
                DT = da.getDataTable();
                return DT;
            }
            finally
            {
                DT = null;
            }
        }

        internal static CConsignments getInstance(string ConsignmentNo, bool Billed)
        {
            object ObjVal;
            CConsignments cTemp;
            PropertyInfo[] arrPi;
            DataTable DT = new DataTable();

            try
            {
                cTemp = new CConsignments();
                DT = getAllData(ConsignmentNo, Billed);

                if (DT.Rows.Count > 0)
                {
                    arrPi = cTemp.GetType().GetProperties().First(x => x.Name == "GridProperties").GetValue(cTemp) as PropertyInfo[];

                    DT.Columns["TravelFrom"].ColumnName = "TravelFromID";
                    DT.Columns["TravelTo"].ColumnName = "TravelToID";

                    foreach (PropertyInfo pi in arrPi)
                    {
                        if (!DT.Rows[0].IsNull(pi.Name))
                        {
                            ObjVal = DT.Rows[0][pi.Name];
                            pi.SetValue(cTemp, ObjVal);
                        }
                    }
                    ObjVal = null;
                }
                else
                    cTemp.strError = "No consignment data found";
                return cTemp;
            }
            catch (Exception ex)
            {
                cTemp = new CConsignments() { strError = ex.Message };
                return cTemp;
            }
            finally
            {
                DT = null;
                ObjVal = null;
                cTemp = null;
                arrPi = null;
            }
        }

        internal int Insert()
        {
            StringBuilder sb = new StringBuilder("Party name doesn't exists");
            DBAccess cdba = new DBAccess();

            cdba.CommandText = "sp_ealog_consignments";
            cdba.Parameters.Add(new SqlParameter("option", "entry"));
            cdba.Parameters.Add(new SqlParameter("ConsignmentNo", ConsignmentNo));
            cdba.Parameters.Add(new SqlParameter("ConsignmentDate", ConsignmentDate));
            cdba.Parameters.Add(new SqlParameter("InvoiceNo", InvoiceNo));
            cdba.Parameters.Add(new SqlParameter("SignorId", SignorID));
            cdba.Parameters.Add(new SqlParameter("SigneeId", SigneeID));
            cdba.Parameters.Add(new SqlParameter("travelFromInt", TravelFromID));
            cdba.Parameters.Add(new SqlParameter("travelToInt", TravelToID));
            cdba.Parameters.Add(new SqlParameter("packages", Packages));
            cdba.Parameters.Add(new SqlParameter("contents", Contents));
            cdba.Parameters.Add(new SqlParameter("vehicleno", VehicleNo));
            cdba.Parameters.Add(new SqlParameter("rate", Rate));
            cdba.Parameters.Add(new SqlParameter("weight", Weight));
            cdba.Parameters.Add(new SqlParameter("amount ", Amount));
            return cdba.ExecuteNonQuery();
        }
        #endregion
    }
}