using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Data.SqlClient;
using EA_Logistics_Control.Models;
using ExtraFunctions;

namespace EA_Logistics_Control
{
    public partial class FormAttachConsignment : Form
    {

        #region defined - Form properties
        private DataSet dataSet { get; set; }

        /// <summary>
        /// Any kind of message that needs Operator's attention will be assigned to msg property.
        /// </summary>
        private string message { get; set; }

        /// <summary>
        /// Int property to store Error number for specific error messages which will be stored in log file.
        /// </summary>
        private int iErrId { get; set; }
        #endregion

        #region defined - Control limits

        /// <summary>
        /// Int property that will be used to iterate through array of extra charges in pEC, bEC, tbEC.
        /// </summary>
        private int chargePointer { get; set; }

        /// <summary>
        /// Int property that will be used to iterate through array of multiple points in pMP, bMP, tbMP.
        /// </summary>
        private int multiPointer { get; set; }

        /// <summary>
        /// A List of type string
        /// </summary>
        private List<string> setText { get; set; }

        private DataTable dataTableConsignments;
        private Dictionary<Control, ErrorProvider> diControlsBillsMandatory;
        private Dictionary<Control, string> diControlsBillsNum;
        private CConsignments ConsignmentForBilling;

        #endregion

        #region Properties declared - Control arrays

        /// <summary>
        /// Panel array to allow iteration of dynamically created panels which will further contain dynamically created input fields for Extra Charges that may be applied.
        /// </summary>
        private Panel[] pnlCharges { get; set; }

        /// <summary>
        /// Panel array to allow iteration of dynamically created panels which will further contain dynamically created input fields for Delivery points that may be applied.
        /// </summary>
        private Panel[] pnlPoints { get; set; }

        /// <summary>
        /// ComboBox array to allow iteration of dynamically created ComboBoxes containing names for Extra Charges that may be applied.
        /// </summary>
        private ComboBox[] cbxCharges { get; set; }

        /// <summary>
        /// TextBox array to allow iteration of dynamically created TextBoxes containing values for Extra Charges that may be applied.
        /// </summary>
        private TextBox[] txtCharges { get; set; }

        /// <summary>
        /// TextBox array to allow iteration of dynamically created TextBoxes containing values for names of Delivery Points (aka Multipoints) that may be applied.
        /// </summary>
        private TextBox[] txtPoints { get; set; }

        /// <summary>
        /// Button array to allow iteration of dynamically created Buttons that allow a user to remove unnecesary extra charges from array pEC.
        /// </summary>
        private Button[] btnCharges { get; set; }

        /// <summary>
        /// Button array to allow iteration of dynamically created Buttons that allow a user to remove unnecessary Delivery Points (aka Multipoints) from array pMP.
        /// </summary>
        private Button[] btnPoints { get; set; }

        /// <summary>
        /// Label array to allow iteration of dynamically created Labels showing Unit of Currency for Extra Charges that may be applied.
        /// </summary>
        private Label[] lblCharges { get; set; }

        #endregion

        #region defined - user defined methods

        #region rendering - dynamic controls

        /// <summary>
        /// Loads all charges from database that can be applied to a bill through ComboBoxes.
        /// </summary>
        private void loadDynamicControlArrays(string panel)
        {
            if (panel == "extra")
            {
                pnlCharges = new Panel[100];
                cbxCharges = new ComboBox[100];
                txtCharges = new TextBox[100];
                btnCharges = new Button[100];
                lblCharges = new Label[100];
                //dataSet = CCatCharges.getDataAll(
            }
            else
            {
                pnlPoints = new Panel[100];
                txtPoints = new TextBox[100];
                btnPoints = new Button[100];
            }
        }

        /// <summary>
        /// Creates additional charges for an LR.
        /// </summary>
        private void addCharges()
        {
            if (pnlCharges == null)
                loadDynamicControlArrays("extra");

            pnlCharges[++chargePointer] = new Panel();
            btnCharges[chargePointer] = new Button();
            cbxCharges[chargePointer] = new ComboBox();
            lblCharges[chargePointer] = new Label();
            txtCharges[chargePointer] = new TextBox();

            txtCharges[chargePointer].KeyPress += TB_KeyPress;
            cbxCharges[chargePointer].LostFocus += cbExtra_LostFocus;
            btnCharges[chargePointer].Click += bExtra_Remove_Click;
            btnCharges[chargePointer].BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory().Replace(@"bin\Debug", @"pictures\ico_remove.ico"), true);
            pnlCharges[chargePointer].BackColor = Color.Transparent;
            cbxCharges[chargePointer].DropDownStyle = ComboBoxStyle.DropDown;

            pnlCharges[chargePointer].Name = "P_Extra_RT_" + chargePointer.ToString();
            btnCharges[chargePointer].Name = "B_Extra_RT_" + chargePointer.ToString();
            cbxCharges[chargePointer].Name = "CB_Extra_RT_" + chargePointer.ToString();
            lblCharges[chargePointer].Name = "L_Extra_RT_" + chargePointer.ToString();
            txtCharges[chargePointer].Name = "TB_Extra_RT_" + chargePointer.ToString();

            btnCharges[chargePointer].Size = new System.Drawing.Size((txtCharges[chargePointer].Height + (txtCharges[chargePointer].Height * 15 / 100)), (txtCharges[chargePointer].Height + (txtCharges[chargePointer].Height * 15 / 100)));
            btnCharges[chargePointer].AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCharges[chargePointer].BackgroundImageLayout = ImageLayout.Center;
            lblCharges[chargePointer].AutoSize = true;
            cbxCharges[chargePointer].Width = 138;
            lblCharges[chargePointer].Width = 32;
            txtCharges[chargePointer].Width = 80;
            pnlCharges[chargePointer].Width = cbxCharges[chargePointer].Width + cbxCharges[chargePointer].Width + lblCharges[chargePointer].Width + btnCharges[chargePointer].Width;
            pnlCharges[chargePointer].AutoSize = true;
            pnlCharges[chargePointer].AutoSizeMode = AutoSizeMode.GrowAndShrink;

            if (chargePointer == 0)
                pnlCharges[chargePointer].Location = new System.Drawing.Point(0, 0);
            else
                pnlCharges[chargePointer].Location = new System.Drawing.Point(pnlCharges[chargePointer - 1].Left, pnlCharges[chargePointer - 1].Top + pnlCharges[chargePointer - 1].Height + (pnlCharges[chargePointer - 1].Height - (int)(pnlCharges[chargePointer - 1].Height * 83.333 / 100)));

            cbxCharges[chargePointer].Location = new System.Drawing.Point(8, 8);
            lblCharges[chargePointer].Location = new System.Drawing.Point(cbxCharges[chargePointer].Left + cbxCharges[chargePointer].Width + 12, cbxCharges[chargePointer].Top);
            txtCharges[chargePointer].Location = new System.Drawing.Point(lblCharges[chargePointer].Left + lblCharges[chargePointer].Width, lblCharges[chargePointer].Top);
            btnCharges[chargePointer].Location = new System.Drawing.Point(txtCharges[chargePointer].Left + txtCharges[chargePointer].Width + 4, txtCharges[chargePointer].Top - 2);

            if (!dataSet.Tables.Contains("ExtraCharges"))
            {
                DataTable dtTemp = CCatCharges.getDataAll("all");
                dtTemp.TableName = "ExtraCharges";
                dataSet.Tables.Add(dtTemp.Copy());
                cbxCharges[chargePointer].DataSource = dataSet.Tables["ExtraCharges"];
                cbxCharges[chargePointer].DisplayMember = "Name";
                cbxCharges[chargePointer].ValueMember = "CID";
                setText = new List<string>(dataSet.Tables["ExtraCharges"].Rows.Count);
                dtTemp.Dispose();
                dtTemp = null;
            }

            lblCharges[chargePointer].Text = "Rs.";
            txtCharges[chargePointer].TextAlign = HorizontalAlignment.Right;

            pnlCharges[chargePointer].Controls.Add(btnCharges[chargePointer]);
            pnlCharges[chargePointer].Controls.Add(cbxCharges[chargePointer]);
            pnlCharges[chargePointer].Controls.Add(lblCharges[chargePointer]);
            pnlCharges[chargePointer].Controls.Add(txtCharges[chargePointer]);
            pnlExtraCharges.Controls.Add(pnlCharges[chargePointer]);
        }

        /// <summary>
        /// Adds delivery point(s) controls
        /// </summary>
        private void addPoints()
        {
            if (pnlPoints == null)
                loadDynamicControlArrays("");

            pnlPoints[++multiPointer] = new Panel();
            txtPoints[multiPointer] = new TextBox();
            btnPoints[multiPointer] = new Button();

            btnPoints[multiPointer].Click += bMP_Remove_Click;
            btnPoints[multiPointer].BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory().Replace(@"bin\Debug", @"pictures\ico_remove.ico"), true);
            txtPoints[multiPointer].Width = pnlMultiPoints.Width - (pnlMultiPoints.Width * 25 / 100);
            btnPoints[multiPointer].Size = new System.Drawing.Size((txtPoints[multiPointer].Height + (txtPoints[multiPointer].Height * 15 / 100)), (txtPoints[multiPointer].Height + (txtPoints[multiPointer].Height * 15 / 100)));
            btnPoints[multiPointer].AutoSizeMode = AutoSizeMode.GrowAndShrink;

            pnlPoints[multiPointer].BackColor = Color.Transparent;
            btnPoints[multiPointer].BackgroundImageLayout = ImageLayout.Center;

            pnlPoints[multiPointer].Width = txtPoints[multiPointer].Width + btnPoints[multiPointer].Width;
            pnlPoints[multiPointer].AutoSize = true;
            pnlPoints[multiPointer].AutoSizeMode = AutoSizeMode.GrowAndShrink;

            if (multiPointer == 0)
                pnlPoints[multiPointer].Location = new System.Drawing.Point(8, 8);
            else
                pnlPoints[multiPointer].Location = new System.Drawing.Point(pnlPoints[multiPointer - 1].Left, pnlPoints[multiPointer - 1].Top + pnlPoints[multiPointer - 1].Height + (pnlPoints[multiPointer - 1].Height / 80));

            txtPoints[multiPointer].Location = new System.Drawing.Point(8, 8);
            btnPoints[multiPointer].Location = new System.Drawing.Point(txtPoints[multiPointer].Left + txtPoints[multiPointer].Width + 8, txtPoints[multiPointer].Top);

            pnlPoints[multiPointer].Controls.Add(txtPoints[multiPointer]);
            pnlPoints[multiPointer].Controls.Add(btnPoints[multiPointer]);
            pnlMultiPoints.Controls.Add(pnlPoints[multiPointer]);
        }

        #endregion

        #region Fields checking on Controls

        /// <summary>
        /// Removes a multi point from UI.
        /// </summary>
        /// <param name="bTemp"></param>
        private void removeMP(Button bTemp)
        {
            int pointer = Convert.ToInt32(bTemp.Name.Substring(bTemp.Name.LastIndexOf("_") + 1));
            int delpointer = pointer;
            int i, j;

            //  Try new for loop
            for (i = multiPointer; i >= pointer; i--)
            {
                if (pnlPoints[i] != null)
                {
                    for (j = pointer; j < i; j++)
                    {
                        if (pnlCharges[j] != null)
                        {
                            txtCharges[j].Text = txtCharges[j + 1].Text;
                        }
                    }
                    break;

                }
            }

            pnlPoints[i].Visible = false;
            txtPoints[i].Text = "";

            pnlPoints[multiPointer] = null;
            multiPointer--;
        }

        /// <summary>
        /// Removes extra charge from UI.
        /// </summary>
        /// <param name="bTemp"></param>
        private void removeEC(Button bTemp)
        {
            int pointer = Convert.ToInt32(bTemp.Name.Substring(bTemp.Name.LastIndexOf("_") + 1));
            int delpointer = pointer;
            int i, j;

            //  Try new for loop
            for (i = chargePointer; i >= pointer; i--)
            {
                if (pnlCharges[i] != null)
                {
                    for (j = pointer; j < i; j++)
                    {
                        if (pnlCharges[j] != null)
                        {
                            cbxCharges[j].Text = cbxCharges[j + 1].Text;
                            txtCharges[j].Text = txtCharges[j + 1].Text;
                        }
                    }
                    break;

                }
            }

            pnlCharges[i].Visible = false;
            txtCharges[i].Text = "";

            pnlCharges[chargePointer] = null;
            chargePointer--;
        }

        private void setTableForBillingConsignments(ref DataTable dtTemp, Type t)
        {
            PropertyInfo[] propertyInfoArray;
            try
            {
                propertyInfoArray = t.GetProperties();
                dtTemp = new DataTable();

                //CConsignments c = new CConsignments();
                foreach (PropertyInfo pi in propertyInfoArray)
                {
                    dtTemp.Columns.Add(new DataColumn(pi.Name));
                }

                DataRow row = dtTemp.NewRow();
                foreach (PropertyInfo pi in propertyInfoArray)
                {
                    row[pi.Name] = pi.GetValue(t);
                }
                dtTemp.Rows.Add(row);
            }
            finally
            {
                propertyInfoArray = null;
            }
        }

        #endregion

        #endregion

        private CRunTimeUI _uiManager;

        #region event handling
        public FormAttachConsignment()
        {
            _uiManager = new CRunTimeUI();
            InitializeComponent();
        }

        private void FormAttachConsignment_Load(object sender, EventArgs e)
        {
            chargePointer = -1;
            multiPointer = -1;

            #region
            diControlsBillsMandatory = new Dictionary<Control, ErrorProvider>();
            diControlsBillsNum = new Dictionary<Control, string>();
            #endregion

            #region
            diControlsBillsMandatory.Add(txtConsignmentNo, errProConsignmentNo);
            diControlsBillsNum.Add(txtConsignmentNo, "Int");
            #endregion

            this.AutoSize = true;

            _uiManager.makeFieldsReadOnly(this.Controls);
            txtConsignmentNo.ReadOnly = false;
            cbConsignee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbConsignee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTo.DropDownStyle = ComboBoxStyle.DropDownList;

            linkAddExtraCharge.LinkClicked += linkAddExtraCharge_LinkClicked;
            linkAddMultiPoint.LinkClicked += linkAddMultiPoint_LinkClicked;
        }

        private void btnAddConsignment_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> dictionaryExtraCharges = new Dictionary<string, decimal>();
            List<string> listMultiPoints = new List<string>();
            DataTable dtConsignment = new DataTable("ConsignmentForBilling");
            try
            {
                if (ConsignmentForBilling == null || ConsignmentForBilling.strError != "")
                {
                    errProConsignmentNo.SetError(txtConsignmentNo, "Consignment number is missing or wrong.");
                }
                else
                {
                    errProConsignmentNo.Clear();
                    setTableForBillingConsignments(ref dtConsignment, ConsignmentForBilling.GetType());

                    for (; chargePointer >= 0; chargePointer--)
                    {
                        if (pnlCharges[chargePointer] != null)
                        {
                            dictionaryExtraCharges.Add(cbxCharges[chargePointer].SelectedText, Convert.ToDecimal(txtCharges[chargePointer].Text));
                            pnlCharges[chargePointer].Visible = false;
                            pnlCharges[chargePointer].Dispose();
                            pnlCharges[chargePointer] = null;
                        }
                    }

                    for (; multiPointer >= 0; multiPointer--)
                    {
                        if (pnlPoints[multiPointer] != null)
                        {
                            listMultiPoints.Add(txtPoints[multiPointer].Text);
                            pnlPoints[multiPointer].Visible = false;
                            pnlPoints[multiPointer].Dispose();
                            pnlPoints[multiPointer] = null;
                        }
                    }

                    _uiManager.clearFields(this.Controls, diControlsBillsMandatory, true);

                }

                FormNewBill.AddConsignment(dtConsignment, dictionaryExtraCharges, listMultiPoints);
            }
            finally
            {
                ConsignmentForBilling = null;
                dictionaryExtraCharges = null;
                listMultiPoints = null;
                dtConsignment = null;
            }
        }

        private void linkAddMultiPoint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addPoints();
        }

        // Event Handler for Click event of Remove button that removes extra MultiPoints for a consignment.
        private void bMP_Remove_Click(object sender, EventArgs e)
        {
            Button bTemp = (Button)sender;
            removeMP(bTemp);
        }

        private void bExtra_Remove_Click(object sender, EventArgs e)
        {
            Button bTemp = (Button)sender;
            removeEC(bTemp);
        }

        private void cbExtra_LostFocus(object sender, EventArgs e)
        {
            int mePoint = -1;
            try
            {
                ComboBox cbTemp = (ComboBox)sender;
                mePoint = Convert.ToInt16(cbTemp.Name.Substring(cbTemp.Name.LastIndexOf("_") + 1));
                for (int i = 0; i < chargePointer; i++)
                {
                    if (cbxCharges[i] == null)
                        break;

                    if (i != mePoint && cbxCharges[i].Text == cbxCharges[mePoint].Text && cbxCharges[mePoint].Text != "")
                        throw new MutualExclusionException();
                }

                if (mePoint < setText.Count)
                    setText.RemoveAt(mePoint);

                //bool _found = false;
                //foreach (DataRow row in dt.Rows)
                //{
                //    if (row["display"].ToString() == comboBox1.Text)
                //    {
                //        _found = true;
                //        break;
                //    }
                //}
                //if (!_found)
                //{
                //    dt.Rows.Add(new object[] { comboBox1.Text, Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["value"]) + 1 });
                //    comboBox1.SelectedIndex = dt.Rows.Count - 1;
                //}

                setText.Insert(mePoint, cbTemp.Text);
            }
            catch (Exception Ex)
            {
                message = "Project: EA Logistics Control\nTarget:" + Ex.TargetSite.ToString() + "\nException:" + Ex.GetType().ToString() + "\nMessage:" + Ex.Message;
                CLogger.setErrorLog(iErrId, message);
                if (Ex is MutualExclusionException && cbxCharges.Length <= mePoint)
                {
                    iErrId = -2;
                    cbxCharges[mePoint].LostFocus -= cbExtra_LostFocus;
                    cbxCharges[mePoint].Text = setText[mePoint];
                    cbxCharges[mePoint].SelectedText = setText[mePoint];
                    message = "You can't apply same extra charges more than once.";
                    MessageBox.Show(message);
                    cbxCharges[mePoint].LostFocus += cbExtra_LostFocus;
                }
                else
                    MessageBox.Show(message);
            }
        }

        private void linkAddExtraCharge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addCharges();
        }

        private void pnlExtraCharges_MouseHover(object sender, EventArgs e)
        {
            if (pnlCharges != null && pnlCharges.Length > 0)
                pnlExtraCharges.Focus();
        }

        private void pnlMultiPoints_MouseHover(object sender, EventArgs e)
        {
            if (pnlPoints != null && pnlPoints.Length > 0)
                pnlMultiPoints.Focus();
        }

        private void txtConsignmentNo_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtConsignmentNo.Text == "")
                    return;
                ConsignmentForBilling = CConsignments.getInstance(txtConsignmentNo.Text, false);
                txtConsignmentAmount.Text = ConsignmentForBilling.Amount.ToString();
                _uiManager.clearFields(pnlExtraCharges.Controls, null, nested: true);
                _uiManager.clearFields(pnlMultiPoints.Controls, null, nested: true);
                if (ConsignmentForBilling.strError != null && ConsignmentForBilling.strError != "")
                {
                    MessageBox.Show("Consignments can not be loaded due to error : " + ConsignmentForBilling.strError);
                }
            }
            catch (Exception Ex)
            {
                if (Ex is SqlException)
                    iErrId = -126;
                MessageBox.Show(Ex.Message);
                message = "Project: EA Logistics Control\nTarget:" + Ex.TargetSite.ToString() + "\nException:" + Ex.GetType().ToString() + "\nMessage:" + Ex.Message;
                CLogger.setErrorLog(iErrId, message);
                _uiManager.clearFields(this.Controls, diControlsBillsMandatory, true);
            }
        }

        private void TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox c = (TextBox)sender;
            if (diControlsBillsNum.ContainsKey(c))
                _uiManager.restrictKeys(diControlsBillsNum, c, e);
        }
        #endregion

    }
}
