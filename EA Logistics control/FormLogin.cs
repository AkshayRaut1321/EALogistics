using System;
using System.Windows.Forms;

namespace EA_Logistics_Control
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void printButton_Click(System.Object sender, System.EventArgs e)
        {
            //Report1 r = new Report1();
            //DataTable dt = new DataTable("test");
            //dt.Columns.Add("testCol");
            //DataRow dr = dt.NewRow();
            //dr["testcol"] = "values";
            //dt.Rows.Add(dr);
            //DataSet ds = new DataSet();
            //ds.Tables.Add(dt);
            //r.SetDataSource(ds);
            //PrintForm p = new PrintForm();
            //p.CaptureScreen(this);
            //r.PrintToPrinter(1, true, 0, 0);
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            MdiDashboard varDashboard = (this.MdiParent as MdiDashboard);
            varDashboard.UserInfo.IsActive = true;
            varDashboard.CheckSession();
        }
    }
}
