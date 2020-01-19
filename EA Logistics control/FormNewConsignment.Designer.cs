namespace EA_Logistics_Control
{
    partial class FormNewConsignment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.P_IC = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbConsignee = new System.Windows.Forms.ComboBox();
            this.cbConsignor = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.TB_IC_Amount = new System.Windows.Forms.TextBox();
            this.TB_IC_Packages = new System.Windows.Forms.TextBox();
            this.TB_IC_No = new System.Windows.Forms.TextBox();
            this.RB_IC_LCV = new System.Windows.Forms.RadioButton();
            this.RB_IC_FTL = new System.Windows.Forms.RadioButton();
            this.RB_IC_Value = new System.Windows.Forms.RadioButton();
            this.L_IC_To = new System.Windows.Forms.Label();
            this.L_IC_From = new System.Windows.Forms.Label();
            this.TB_IC_Desc = new System.Windows.Forms.TextBox();
            this.L_IC_Desc = new System.Windows.Forms.Label();
            this.L_IC_Consignor = new System.Windows.Forms.Label();
            this.L_IC_Amt = new System.Windows.Forms.Label();
            this.TB_IC_Weight = new System.Windows.Forms.TextBox();
            this.TB_IC_Rate = new System.Windows.Forms.TextBox();
            this.TB_IC_Vehicle = new System.Windows.Forms.TextBox();
            this.TB_IC_Inv = new System.Windows.Forms.TextBox();
            this.DTP_IC = new System.Windows.Forms.DateTimePicker();
            this.L_IC_Vehicle = new System.Windows.Forms.Label();
            this.L_IC_No = new System.Windows.Forms.Label();
            this.L_IC_Consignee = new System.Windows.Forms.Label();
            this.L_IC_Weight = new System.Windows.Forms.Label();
            this.L_IC_Packages = new System.Windows.Forms.Label();
            this.L_IC_Date = new System.Windows.Forms.Label();
            this.L_IC_InvoiceNo = new System.Windows.Forms.Label();
            this.L_IC_Rate = new System.Windows.Forms.Label();
            this.EP_IC_No = new System.Windows.Forms.ErrorProvider(this.components);
            this.EP_IC_Signor = new System.Windows.Forms.ErrorProvider(this.components);
            this.EP_IC_Signee = new System.Windows.Forms.ErrorProvider(this.components);
            this.EP_IC_From = new System.Windows.Forms.ErrorProvider(this.components);
            this.EP_IC_To = new System.Windows.Forms.ErrorProvider(this.components);
            this.EP_IC_VehicleNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.EP_IC_Weight = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.P_IC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_No)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_Signor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_Signee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_VehicleNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_Weight)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.P_IC);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(995, 490);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(995, 515);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // P_IC
            // 
            this.P_IC.AutoScroll = true;
            this.P_IC.BackColor = System.Drawing.Color.Silver;
            this.P_IC.Controls.Add(this.button3);
            this.P_IC.Controls.Add(this.button2);
            this.P_IC.Controls.Add(this.button1);
            this.P_IC.Controls.Add(this.cbConsignee);
            this.P_IC.Controls.Add(this.cbConsignor);
            this.P_IC.Controls.Add(this.cbTo);
            this.P_IC.Controls.Add(this.cbFrom);
            this.P_IC.Controls.Add(this.TB_IC_Amount);
            this.P_IC.Controls.Add(this.TB_IC_Packages);
            this.P_IC.Controls.Add(this.TB_IC_No);
            this.P_IC.Controls.Add(this.RB_IC_LCV);
            this.P_IC.Controls.Add(this.RB_IC_FTL);
            this.P_IC.Controls.Add(this.RB_IC_Value);
            this.P_IC.Controls.Add(this.L_IC_To);
            this.P_IC.Controls.Add(this.L_IC_From);
            this.P_IC.Controls.Add(this.TB_IC_Desc);
            this.P_IC.Controls.Add(this.L_IC_Desc);
            this.P_IC.Controls.Add(this.L_IC_Consignor);
            this.P_IC.Controls.Add(this.L_IC_Amt);
            this.P_IC.Controls.Add(this.TB_IC_Weight);
            this.P_IC.Controls.Add(this.TB_IC_Rate);
            this.P_IC.Controls.Add(this.TB_IC_Vehicle);
            this.P_IC.Controls.Add(this.TB_IC_Inv);
            this.P_IC.Controls.Add(this.DTP_IC);
            this.P_IC.Controls.Add(this.L_IC_Vehicle);
            this.P_IC.Controls.Add(this.L_IC_No);
            this.P_IC.Controls.Add(this.L_IC_Consignee);
            this.P_IC.Controls.Add(this.L_IC_Weight);
            this.P_IC.Controls.Add(this.L_IC_Packages);
            this.P_IC.Controls.Add(this.L_IC_Date);
            this.P_IC.Controls.Add(this.L_IC_InvoiceNo);
            this.P_IC.Controls.Add(this.L_IC_Rate);
            this.P_IC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_IC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_IC.Location = new System.Drawing.Point(0, 0);
            this.P_IC.Name = "P_IC";
            this.P_IC.Size = new System.Drawing.Size(995, 490);
            this.P_IC.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 227;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 36);
            this.button2.TabIndex = 226;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 225;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbConsignee
            // 
            this.cbConsignee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbConsignee.FormattingEnabled = true;
            this.cbConsignee.Location = new System.Drawing.Point(681, 72);
            this.cbConsignee.Name = "cbConsignee";
            this.cbConsignee.Size = new System.Drawing.Size(294, 24);
            this.cbConsignee.TabIndex = 224;
            // 
            // cbConsignor
            // 
            this.cbConsignor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbConsignor.FormattingEnabled = true;
            this.cbConsignor.Location = new System.Drawing.Point(171, 72);
            this.cbConsignor.Name = "cbConsignor";
            this.cbConsignor.Size = new System.Drawing.Size(296, 24);
            this.cbConsignor.TabIndex = 223;
            // 
            // cbTo
            // 
            this.cbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(681, 117);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(294, 24);
            this.cbTo.TabIndex = 222;
            // 
            // cbFrom
            // 
            this.cbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(171, 117);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(296, 24);
            this.cbFrom.TabIndex = 221;
            // 
            // TB_IC_Amount
            // 
            this.TB_IC_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_IC_Amount.Location = new System.Drawing.Point(681, 358);
            this.TB_IC_Amount.Name = "TB_IC_Amount";
            this.TB_IC_Amount.Size = new System.Drawing.Size(294, 23);
            this.TB_IC_Amount.TabIndex = 15;
            this.TB_IC_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            // 
            // TB_IC_Packages
            // 
            this.TB_IC_Packages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TB_IC_Packages.Location = new System.Drawing.Point(171, 246);
            this.TB_IC_Packages.Name = "TB_IC_Packages";
            this.TB_IC_Packages.Size = new System.Drawing.Size(296, 23);
            this.TB_IC_Packages.TabIndex = 8;
            this.TB_IC_Packages.TextChanged += new System.EventHandler(this.TB_IC_Packages_TextChanged);
            this.TB_IC_Packages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            // 
            // TB_IC_No
            // 
            this.TB_IC_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TB_IC_No.Location = new System.Drawing.Point(171, 31);
            this.TB_IC_No.Name = "TB_IC_No";
            this.TB_IC_No.Size = new System.Drawing.Size(296, 23);
            this.TB_IC_No.TabIndex = 0;
            this.TB_IC_No.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_IC_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            // 
            // RB_IC_LCV
            // 
            this.RB_IC_LCV.AutoSize = true;
            this.RB_IC_LCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_IC_LCV.Location = new System.Drawing.Point(413, 219);
            this.RB_IC_LCV.Name = "RB_IC_LCV";
            this.RB_IC_LCV.Size = new System.Drawing.Size(51, 21);
            this.RB_IC_LCV.TabIndex = 13;
            this.RB_IC_LCV.Text = "FTL";
            this.RB_IC_LCV.UseVisualStyleBackColor = true;
            // 
            // RB_IC_FTL
            // 
            this.RB_IC_FTL.AutoSize = true;
            this.RB_IC_FTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_IC_FTL.Location = new System.Drawing.Point(293, 219);
            this.RB_IC_FTL.Name = "RB_IC_FTL";
            this.RB_IC_FTL.Size = new System.Drawing.Size(52, 21);
            this.RB_IC_FTL.TabIndex = 12;
            this.RB_IC_FTL.Text = "LCV";
            this.RB_IC_FTL.UseVisualStyleBackColor = true;
            // 
            // RB_IC_Value
            // 
            this.RB_IC_Value.AutoSize = true;
            this.RB_IC_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_IC_Value.Location = new System.Drawing.Point(168, 219);
            this.RB_IC_Value.Name = "RB_IC_Value";
            this.RB_IC_Value.Size = new System.Drawing.Size(62, 21);
            this.RB_IC_Value.TabIndex = 11;
            this.RB_IC_Value.Text = "Value";
            this.RB_IC_Value.UseVisualStyleBackColor = true;
            // 
            // L_IC_To
            // 
            this.L_IC_To.AutoSize = true;
            this.L_IC_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_IC_To.Location = new System.Drawing.Point(551, 120);
            this.L_IC_To.Name = "L_IC_To";
            this.L_IC_To.Size = new System.Drawing.Size(25, 17);
            this.L_IC_To.TabIndex = 220;
            this.L_IC_To.Text = "To";
            // 
            // L_IC_From
            // 
            this.L_IC_From.AutoSize = true;
            this.L_IC_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_IC_From.Location = new System.Drawing.Point(21, 120);
            this.L_IC_From.Name = "L_IC_From";
            this.L_IC_From.Size = new System.Drawing.Size(40, 17);
            this.L_IC_From.TabIndex = 220;
            this.L_IC_From.Text = "From";
            // 
            // TB_IC_Desc
            // 
            this.TB_IC_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_IC_Desc.Location = new System.Drawing.Point(681, 220);
            this.TB_IC_Desc.Multiline = true;
            this.TB_IC_Desc.Name = "TB_IC_Desc";
            this.TB_IC_Desc.Size = new System.Drawing.Size(294, 100);
            this.TB_IC_Desc.TabIndex = 9;
            // 
            // L_IC_Desc
            // 
            this.L_IC_Desc.AutoSize = true;
            this.L_IC_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_IC_Desc.Location = new System.Drawing.Point(551, 223);
            this.L_IC_Desc.Name = "L_IC_Desc";
            this.L_IC_Desc.Size = new System.Drawing.Size(79, 17);
            this.L_IC_Desc.TabIndex = 218;
            this.L_IC_Desc.Text = "Description";
            // 
            // L_IC_Consignor
            // 
            this.L_IC_Consignor.AutoSize = true;
            this.L_IC_Consignor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_IC_Consignor.Location = new System.Drawing.Point(21, 75);
            this.L_IC_Consignor.Name = "L_IC_Consignor";
            this.L_IC_Consignor.Size = new System.Drawing.Size(72, 17);
            this.L_IC_Consignor.TabIndex = 79;
            this.L_IC_Consignor.Text = "Consignor";
            // 
            // L_IC_Amt
            // 
            this.L_IC_Amt.AutoSize = true;
            this.L_IC_Amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_IC_Amt.Location = new System.Drawing.Point(551, 361);
            this.L_IC_Amt.Name = "L_IC_Amt";
            this.L_IC_Amt.Size = new System.Drawing.Size(106, 17);
            this.L_IC_Amt.TabIndex = 78;
            this.L_IC_Amt.Text = "Amount (in Rs.)";
            // 
            // TB_IC_Weight
            // 
            this.TB_IC_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_IC_Weight.Location = new System.Drawing.Point(171, 297);
            this.TB_IC_Weight.Name = "TB_IC_Weight";
            this.TB_IC_Weight.Size = new System.Drawing.Size(296, 23);
            this.TB_IC_Weight.TabIndex = 10;
            this.TB_IC_Weight.TextAlignChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_IC_Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            // 
            // TB_IC_Rate
            // 
            this.TB_IC_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_IC_Rate.Location = new System.Drawing.Point(171, 361);
            this.TB_IC_Rate.Name = "TB_IC_Rate";
            this.TB_IC_Rate.Size = new System.Drawing.Size(296, 23);
            this.TB_IC_Rate.TabIndex = 14;
            this.TB_IC_Rate.TextChanged += new System.EventHandler(this.TB_IC_Rate_TextChanged);
            this.TB_IC_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            // 
            // TB_IC_Vehicle
            // 
            this.TB_IC_Vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TB_IC_Vehicle.Location = new System.Drawing.Point(681, 167);
            this.TB_IC_Vehicle.Name = "TB_IC_Vehicle";
            this.TB_IC_Vehicle.Size = new System.Drawing.Size(294, 23);
            this.TB_IC_Vehicle.TabIndex = 7;
            this.TB_IC_Vehicle.TextChanged += new System.EventHandler(this.TB_TextChanged);
            // 
            // TB_IC_Inv
            // 
            this.TB_IC_Inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TB_IC_Inv.Location = new System.Drawing.Point(171, 170);
            this.TB_IC_Inv.Name = "TB_IC_Inv";
            this.TB_IC_Inv.Size = new System.Drawing.Size(296, 23);
            this.TB_IC_Inv.TabIndex = 6;
            // 
            // DTP_IC
            // 
            this.DTP_IC.CustomFormat = "";
            this.DTP_IC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DTP_IC.Location = new System.Drawing.Point(681, 29);
            this.DTP_IC.Name = "DTP_IC";
            this.DTP_IC.Size = new System.Drawing.Size(294, 23);
            this.DTP_IC.TabIndex = 1;
            this.DTP_IC.Value = new System.DateTime(2015, 2, 12, 0, 0, 0, 0);
            // 
            // L_IC_Vehicle
            // 
            this.L_IC_Vehicle.AutoSize = true;
            this.L_IC_Vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_IC_Vehicle.Location = new System.Drawing.Point(551, 170);
            this.L_IC_Vehicle.Name = "L_IC_Vehicle";
            this.L_IC_Vehicle.Size = new System.Drawing.Size(106, 17);
            this.L_IC_Vehicle.TabIndex = 76;
            this.L_IC_Vehicle.Text = "Vehicle number";
            // 
            // L_IC_No
            // 
            this.L_IC_No.AutoSize = true;
            this.L_IC_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_IC_No.Location = new System.Drawing.Point(21, 34);
            this.L_IC_No.Name = "L_IC_No";
            this.L_IC_No.Size = new System.Drawing.Size(144, 17);
            this.L_IC_No.TabIndex = 77;
            this.L_IC_No.Text = "Consignment Number";
            // 
            // L_IC_Consignee
            // 
            this.L_IC_Consignee.AutoSize = true;
            this.L_IC_Consignee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_IC_Consignee.Location = new System.Drawing.Point(551, 75);
            this.L_IC_Consignee.Name = "L_IC_Consignee";
            this.L_IC_Consignee.Size = new System.Drawing.Size(75, 17);
            this.L_IC_Consignee.TabIndex = 70;
            this.L_IC_Consignee.Text = "Consignee";
            // 
            // L_IC_Weight
            // 
            this.L_IC_Weight.AutoSize = true;
            this.L_IC_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_IC_Weight.Location = new System.Drawing.Point(21, 297);
            this.L_IC_Weight.Name = "L_IC_Weight";
            this.L_IC_Weight.Size = new System.Drawing.Size(148, 17);
            this.L_IC_Weight.TabIndex = 75;
            this.L_IC_Weight.Text = "Weight (in Metric Ton)";
            // 
            // L_IC_Packages
            // 
            this.L_IC_Packages.AutoSize = true;
            this.L_IC_Packages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_IC_Packages.Location = new System.Drawing.Point(21, 246);
            this.L_IC_Packages.Name = "L_IC_Packages";
            this.L_IC_Packages.Size = new System.Drawing.Size(139, 17);
            this.L_IC_Packages.TabIndex = 71;
            this.L_IC_Packages.Text = "Number of packages";
            // 
            // L_IC_Date
            // 
            this.L_IC_Date.AutoSize = true;
            this.L_IC_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_IC_Date.Location = new System.Drawing.Point(551, 34);
            this.L_IC_Date.Name = "L_IC_Date";
            this.L_IC_Date.Size = new System.Drawing.Size(124, 17);
            this.L_IC_Date.TabIndex = 74;
            this.L_IC_Date.Text = "Consignment Date";
            // 
            // L_IC_InvoiceNo
            // 
            this.L_IC_InvoiceNo.AutoSize = true;
            this.L_IC_InvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.L_IC_InvoiceNo.Location = new System.Drawing.Point(21, 170);
            this.L_IC_InvoiceNo.Name = "L_IC_InvoiceNo";
            this.L_IC_InvoiceNo.Size = new System.Drawing.Size(104, 17);
            this.L_IC_InvoiceNo.TabIndex = 72;
            this.L_IC_InvoiceNo.Text = "Invoice number";
            // 
            // L_IC_Rate
            // 
            this.L_IC_Rate.AutoSize = true;
            this.L_IC_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_IC_Rate.Location = new System.Drawing.Point(21, 361);
            this.L_IC_Rate.Name = "L_IC_Rate";
            this.L_IC_Rate.Size = new System.Drawing.Size(88, 17);
            this.L_IC_Rate.TabIndex = 73;
            this.L_IC_Rate.Text = "Rate (in Rs.)";
            // 
            // EP_IC_No
            // 
            this.EP_IC_No.ContainerControl = this;
            // 
            // EP_IC_Signor
            // 
            this.EP_IC_Signor.ContainerControl = this;
            // 
            // EP_IC_Signee
            // 
            this.EP_IC_Signee.ContainerControl = this;
            // 
            // EP_IC_From
            // 
            this.EP_IC_From.ContainerControl = this;
            // 
            // EP_IC_To
            // 
            this.EP_IC_To.ContainerControl = this;
            // 
            // EP_IC_VehicleNo
            // 
            this.EP_IC_VehicleNo.ContainerControl = this;
            // 
            // EP_IC_Weight
            // 
            this.EP_IC_Weight.ContainerControl = this;
            // 
            // FormNewConsignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 515);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FormNewConsignment";
            this.Text = "New Consignment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewConsignment_FormClosing);
            this.Load += new System.EventHandler(this.FormNewConsignment_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.P_IC.ResumeLayout(false);
            this.P_IC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_No)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_Signor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_Signee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_VehicleNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_IC_Weight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel P_IC;
        private System.Windows.Forms.TextBox TB_IC_Amount;
        private System.Windows.Forms.TextBox TB_IC_Packages;
        private System.Windows.Forms.TextBox TB_IC_No;
        private System.Windows.Forms.RadioButton RB_IC_LCV;
        private System.Windows.Forms.RadioButton RB_IC_FTL;
        private System.Windows.Forms.RadioButton RB_IC_Value;
        private System.Windows.Forms.Label L_IC_To;
        private System.Windows.Forms.Label L_IC_From;
        private System.Windows.Forms.TextBox TB_IC_Desc;
        private System.Windows.Forms.Label L_IC_Desc;
        private System.Windows.Forms.Label L_IC_Consignor;
        private System.Windows.Forms.Label L_IC_Amt;
        private System.Windows.Forms.TextBox TB_IC_Weight;
        private System.Windows.Forms.TextBox TB_IC_Rate;
        private System.Windows.Forms.TextBox TB_IC_Vehicle;
        private System.Windows.Forms.TextBox TB_IC_Inv;
        private System.Windows.Forms.DateTimePicker DTP_IC;
        private System.Windows.Forms.Label L_IC_Vehicle;
        private System.Windows.Forms.Label L_IC_No;
        private System.Windows.Forms.Label L_IC_Consignee;
        private System.Windows.Forms.Label L_IC_Weight;
        private System.Windows.Forms.Label L_IC_Packages;
        private System.Windows.Forms.Label L_IC_Date;
        private System.Windows.Forms.Label L_IC_InvoiceNo;
        private System.Windows.Forms.Label L_IC_Rate;
        private System.Windows.Forms.ErrorProvider EP_IC_No;
        private System.Windows.Forms.ErrorProvider EP_IC_Signor;
        private System.Windows.Forms.ErrorProvider EP_IC_Signee;
        private System.Windows.Forms.ErrorProvider EP_IC_From;
        private System.Windows.Forms.ErrorProvider EP_IC_To;
        private System.Windows.Forms.ErrorProvider EP_IC_VehicleNo;
        private System.Windows.Forms.ErrorProvider EP_IC_Weight;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbConsignee;
        private System.Windows.Forms.ComboBox cbConsignor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}