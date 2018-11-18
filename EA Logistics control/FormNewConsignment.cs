using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using EA_Logistics_Control.Models;
using ExtraFunctions;

namespace EA_Logistics_Control
{
    public partial class FormNewConsignment : Form
    {
        #region defined - Form fields, properties and UI Control helpers

        #region defined - Form properties
        /// <summary>
        /// Int property to store Error number for specific error messages which will be stored in log file.
        /// </summary>
        private int iErrId { get; set; }

        /// <summary>
        /// Any kind of message that needs Operator's attention will be assigned to msg property.
        /// </summary>
        private string message { get; set; }
        #endregion

        #region defined - Control helpers
        private Dictionary<Control, ErrorProvider> diContConsignmentsMand = new Dictionary<Control, ErrorProvider>();
        private Dictionary<Control, string> diContConsignmentsNum = new Dictionary<Control, string>();
        #endregion

        #endregion

        #region custom methods
        public void Save()
        {
            int resRows = -1;
            CConsignments c;
            try
            {
                System.Windows.Forms.Control.ControlCollection CCLR = P_IC.Controls;

                if (!CRunTimeUI.showErrorOnFields(diContConsignmentsMand))
                {
                    //throw new Exception("User must fill in all empty text fields.");

                    if (DBAccess.checkDuplicate("Consignments", "ConsignmentNo", TB_IC_No.Text))
                    {
                        (this.MdiParent as MdiDashboard).SetNotification("", NotificationPriority.Ready);
                        //toolStripStatusMDI.Text = "Duplicate entry found!";
                        //statusStripMDI.BackColor = Color.Red;
                        return;
                    }

                    c = new CConsignments();

                    foreach (Control cTemp in P_IC.Controls)
                    {
                        if (cTemp.Name.StartsWith("TB_") && cTemp.Name.Contains("_O_") && cTemp.Text == "")
                            cTemp.Text = "";
                    }

                    c.ConsignmentNo = Convert.ToInt32(TB_IC_No.Text);
                    c.ConsignmentDate = DateTime.Now;
                    c.InvoiceNo = TB_IC_Inv.Text;
                    c.SignorID = Convert.ToInt32(cbConsignor.SelectedValue);
                    c.SigneeID = Convert.ToInt32(cbConsignee.SelectedValue);
                    c.TravelFromID = Convert.ToInt32(cbFrom.SelectedValue);
                    c.TravelToID = Convert.ToInt32(cbTo.SelectedValue);
                    c.Packages = Convert.ToInt32(TB_IC_Packages.Text);
                    c.Contents = TB_IC_Desc.Text;
                    c.VehicleNo = TB_IC_Vehicle.Text;
                    c.Rate = Convert.ToDecimal(TB_IC_Rate.Text);
                    c.Weight = Convert.ToDecimal(TB_IC_Weight.Text);
                    c.Amount = Convert.ToDecimal(TB_IC_Amount.Text);

                    resRows = c.Insert();
                    if (resRows > 0)
                    {
                        (this.MdiParent as MdiDashboard).SetNotification("New consignment has been saved.", NotificationPriority.Success);
                        CRunTimeUI.clearFields(P_IC.Controls, diContConsignmentsMand, true);
                        TB_IC_No.Text = DBAccess.GetMaxNext("ConsignmentNo", "Consignments", "max").ToString();
                    }
                }
            }
            catch (Exception Ex)
            {
                if (Ex is SqlException)
                    iErrId = -126;

                message = "Project: EA Logistics Control\nTarget:" + Ex.TargetSite.ToString() + "\nException:" + Ex.GetType().ToString() + "\nMessage:" + Ex.Message;
                if (Ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("The Consignment entry alrady exists for this CN number " + TB_IC_No.Text, Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                    MessageBox.Show(message);
                CLogger.setErrorLog(iErrId, message);
            }
            finally
            {
                c = null;
            }
        }
        #endregion

        #region event handling
        public FormNewConsignment()
        {
            InitializeComponent();
        }

        private void FormNewConsignment_Load(object sender, EventArgs e)
        {
            #region  Setting up UI
            RB_IC_Value.Checked = true;
            P_IC.Dock = DockStyle.Fill;
            DTP_IC.Format = DateTimePickerFormat.Custom;
            DTP_IC.Text = DateTime.Now.ToShortDateString();
            DTP_IC.CustomFormat = "dd/MM/yyyy";

            TB_IC_No.MaxLength = TB_IC_Packages.MaxLength = 10;
            TB_IC_Amount.MaxLength = TB_IC_Rate.MaxLength = TB_IC_Weight.MaxLength = 13;
            TB_IC_Inv.MaxLength = 20;
            TB_IC_Vehicle.MaxLength = 20;
            TB_IC_Desc.MaxLength = 500;
            TB_IC_Amount.TextAlign = TB_IC_Packages.TextAlign = TB_IC_Rate.TextAlign = TB_IC_Weight.TextAlign = HorizontalAlignment.Right;

            //cbConsignor.DropDownStyle = ComboBoxStyle.DropDown;

            CRunTimeUI.setBackColor(P_IC.Controls, Color.Transparent);
            #endregion

            #region Setting up data
            TB_IC_No.Text = DBAccess.GetMaxNext("ConsignmentNo", "Consignments", "max").ToString();

            DataTable dt = DBAccess.GetKeyValueDataTable("CityID", "City", "Cities");
            dt.Rows.InsertAt(dt.NewRow(), 0);
            dt.Rows[0]["CityId"] = 0;
            dt.Rows[0]["City"] = "--select--";
            cbFrom.DisplayMember = cbTo.DisplayMember = "City";
            cbFrom.ValueMember = cbTo.ValueMember = "CityID";
            //  Sometimes it gives ArgumentException at the time of binding DisplayMember to data source, which is why I am assigning them before Data source.
            cbFrom.DataSource = dt;
            cbTo.DataSource = dt.Copy();
            dt = null;

            dt = DBAccess.GetKeyValueDataTable("PartyID", "Name", "Parties");
            dt.Rows.InsertAt(dt.NewRow(), 0);
            dt.Rows[0]["PartyID"] = 0;
            dt.Rows[0]["Name"] = "--select--";
            cbConsignor.DisplayMember = cbConsignee.DisplayMember = "Name";
            cbConsignor.ValueMember = cbConsignee.ValueMember = "PartyID";
            cbConsignor.DataSource = dt;
            cbConsignee.DataSource = dt.Copy();
            dt = null;
            #endregion

            #region Collecting numeric controls
            diContConsignmentsNum.Add(TB_IC_No, "Int");
            diContConsignmentsNum.Add(TB_IC_Packages, "Int");
            diContConsignmentsNum.Add(TB_IC_Weight, "Decimal");
            diContConsignmentsNum.Add(TB_IC_Rate, "Decimal");
            diContConsignmentsNum.Add(TB_IC_Amount, "Decimal");
            #endregion

            #region Collecting compulsory controls
            diContConsignmentsMand.Add(TB_IC_No, EP_IC_No);
            diContConsignmentsMand.Add(cbConsignor, EP_IC_Signor);
            diContConsignmentsMand.Add(cbConsignee, EP_IC_Signee);
            diContConsignmentsMand.Add(cbFrom, EP_IC_Signee);
            diContConsignmentsMand.Add(cbTo, EP_IC_To);
            diContConsignmentsMand.Add(TB_IC_Weight, EP_IC_Weight);
            #endregion

            #region Load MDI parent's controls for notifications
            //controlsArrayMDI = this.MdiParent.Controls.Find("statusStrip", true);
            //if (controlsArrayMDI.Length == 1)
            //{
            //    statusStripMDI = controlsArrayMDI[0] as StatusStrip;
            //    backColorStatusStripMDI = statusStripMDI.BackColor;
            //    toolStripItemsArr = statusStripMDI.Items.Find("toolStripStatusLabel", false);
            //    if (toolStripItemsArr.Length == 1)
            //    {
            //        toolStripStatusMDI = toolStripItemsArr[0];
            //    }
            //}
            #endregion
            TB_IC_No.Focus();
        }

        private void B_IC_Clear_Click(object sender, EventArgs e)
        {
            CRunTimeUI.clearFields(P_IC.Controls, diContConsignmentsMand, true);
            TB_IC_No.Focus();
        }

        private void TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox control = (TextBox)sender;
            if (diContConsignmentsNum.ContainsKey(control))
            {
                CRunTimeUI.restrictKeys(diContConsignmentsNum, control, e);
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            TB_IC_Weight.Enabled = RB_IC_Value.Checked;
        }

        private void FRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Control c = new Control();
            bool hasData = false;
            DialogResult dr;

            /*  I had earlier used just "ControlCollection" as parameter datatype in AreFieldsEmpty() so it referenced System.Windows.Forms.Form.ControlCollection
             *  whereas all controls of the form or panel or any other container are stored in System.Windows.Forms.Control.ControlCollection.
             *  I even tried type-casting the controls of a panel (i.e. Control.ControlCollection) into Form.ControlCollection to make it work but 
             *  it threw exception as both are in different namespaces.
             *  So after realizing the error, I changed the datatype in that method to Control.ControlCollection and then pass the controls of panel. */
            try
            {
                hasData = CRunTimeUI.getBoolOnEmptyFields(onEmpty: false, nested: true, cc: P_IC.Controls);

                if (hasData)
                {
                    dr = MessageBox.Show("Are you sure you want to close this application without saving the new entry?", "Require closing confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.setErrorLog(-1, ex.Message);
            }
            finally
            {
                c = null;
            }
        }

        private void TB_TextChanged(object sender, EventArgs e)
        {
            TextBox tbTemp = (TextBox)sender;
            string m = "Fill in required fields.";

            //  Following section performs setting or resetting ErrorProvider for its corresponding caller TextBox.

            if (tbTemp.Text == "")
            {
                if (diContConsignmentsMand.ContainsKey(tbTemp))
                {
                    diContConsignmentsMand[tbTemp].SetError(tbTemp, m);
                }
            }
            else
            {
                if (diContConsignmentsMand.ContainsKey(tbTemp))
                {
                    diContConsignmentsMand[tbTemp].Clear();
                }
            }
        }
        #endregion
    }
}
