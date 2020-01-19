using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using ExtraFunctions;

namespace EA_Logistics_Control
{
    public partial class FormNewBill : Form
    {
        #region defined - Form fields, properties and UI Control helpers
        #region defined - Form properties

        /// <summary>
        /// Any kind of message that needs Operator's attention will be assigned to msg property.
        /// </summary>
        private string message { get; set; }

        /// <summary>
        /// Int property to store Error number for specific error messages which will be stored in log file.
        /// </summary>
        private int iErrId { get; set; }

        private DataSet dataSet { get; set; }

        #endregion

        #region defined - Control helpers
        private ToolStripMenuItem _tsmiAttachConsignment;
        private Dictionary<Control, ErrorProvider> diContBillsMand;
        private Dictionary<Control, string> diContBillsNum;
        #endregion

        #endregion

        private CRunTimeUI _uiManager;

        #region event handling
        public FormNewBill()
        {
            _uiManager = new CRunTimeUI();
            InitializeComponent();
        }

        private void FRecord_Load(object sender, EventArgs e)
        {
            #region Defining variables controls
            diContBillsMand = new Dictionary<Control, ErrorProvider>();

            diContBillsNum = new Dictionary<Control, string>();
            dataSet = new DataSet();
            #endregion

            #region Collecting numeric controls
            diContBillsNum.Add(txtBillNo, "Int");
            diContBillsNum.Add(txtStatical, "Decimal");
            diContBillsNum.Add(txtAmount, "Decimal");
            #endregion

            #region Collecting compulsory controls
            diContBillsMand.Add(txtBillNo, errProBillNo);
            diContBillsMand.Add(cbParty, errProParty);
            diContBillsMand.Add(txtStatical, errProStatical);
            diContBillsMand.Add(txtAmount, errProTotal);
            #endregion

            #region Setting up UI
            toolStripContainer1.Dock = DockStyle.Fill;
            dgvConsignments.Dock = DockStyle.Bottom;

            datePickerBill.CustomFormat = "dd/MM/yyyy";

            txtStatical.TextAlign = txtAmount.TextAlign = HorizontalAlignment.Right;

            dgvConsignments.ReadOnly = true;

            dgvConsignments.ContextMenuStrip = contextAttachConsignment;

            _tsmiAttachConsignment = new ToolStripMenuItem("Attach Consignment");
            _tsmiAttachConsignment.Click += _tsmiAttachConsignment_Click;

            contextAttachConsignment.Items.Add(_tsmiAttachConsignment);

            datePickerBill.Format = DateTimePickerFormat.Custom;

            this.WindowState = FormWindowState.Maximized;

            //  Starts Sets properties for panel controls that adds CNs to a Bill

            _uiManager.setBackColor(toolStripContainer1.ContentPanel.Controls, Color.Transparent);

            dgvConsignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvConsignments.AllowUserToAddRows = false;

            DataGridViewImageColumn dgvic = new DataGridViewImageColumn();
            dgvic.DisplayIndex = 0;
            dgvic.Icon = new System.Drawing.Icon(Directory.GetCurrentDirectory().Replace(@"bin\Debug", @"pictures\ico_remove.ico"));
            dgvConsignments.Columns.Add(dgvic);

            lblBillNo.Focus();
            #endregion

            #region Setting up data
            txtBillNo.Text = DBAccess.GetMaxNext("BillNo", "Bills", "max").ToString();
            cbParty.DisplayMember = "Name";
            cbParty.ValueMember = "PartyID";
            cbParty.DataSource = DBAccess.GetKeyValueDataTable("PartyID", "Name", "Parties");
            #endregion
        }

        void _tsmiAttachConsignment_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MdiDashboard).SetNotification("Loaded - form Attach Consignment", NotificationPriority.Success);
            FormAttachConsignment fac = new FormAttachConsignment();
            fac.ShowDialog(this);
        }

        private void TSMI_File_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void TSMI_File_Login_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
        }

        private void TB_TextChanged(object sender, EventArgs e)
        {
            TextBox tbTemp = (TextBox)sender;
            string remains = tbTemp.Name.Substring(tbTemp.Name.LastIndexOf("_") + 1);
            string m = "Fill in required fields.";

            //  Following section performs setting or resetting ErrorProvider for its corresponding caller TextBox.

            if (tbTemp.Text == "")
            {
                if (diContBillsMand.ContainsKey(tbTemp))
                    diContBillsMand[tbTemp].SetError(tbTemp, m);
            }
            else
            {
                if (diContBillsMand.ContainsKey(tbTemp))
                    diContBillsMand[tbTemp].Clear();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!_uiManager.showErrorOnFields(diContBillsMand))
            {

            }
            txtBillNo.Focus();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBillNo.TextChanged -= TB_TextChanged;
            txtAmount.TextChanged -= TB_TextChanged;
            _uiManager.clearFields(toolStripContainer1.ContentPanel.Controls, diContBillsMand, true, true);
            txtBillNo.TextChanged += TB_TextChanged;
            txtAmount.TextChanged += TB_TextChanged;
            txtBillNo.Focus();
        }

        private void TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox c = (TextBox)sender;
            if (diContBillsNum.ContainsKey(c))
                _uiManager.restrictKeys(diContBillsNum, c, e);
        }
        #endregion


        internal static void AddConsignment(DataTable dtConsignment, Dictionary<string, decimal> dictionaryExtraCharges, List<string> listMultiPoints)
        {
            throw new NotImplementedException();
        }
    }
}