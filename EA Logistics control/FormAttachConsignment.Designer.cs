namespace EA_Logistics_Control
{
    partial class FormAttachConsignment
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
            this.errProConsignmentNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlExtraCharges = new System.Windows.Forms.Panel();
            this.linkAddExtraCharge = new System.Windows.Forms.LinkLabel();
            this.pnlMultiPoints = new System.Windows.Forms.Panel();
            this.linkAddMultiPoint = new System.Windows.Forms.LinkLabel();
            this.btnAddConsignment = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPackages = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblConsignee = new System.Windows.Forms.Label();
            this.lblConsignmentNo = new System.Windows.Forms.Label();
            this.datePickerConsignment = new System.Windows.Forms.DateTimePicker();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblConsignor = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.rdbValue = new System.Windows.Forms.RadioButton();
            this.rdbFTL = new System.Windows.Forms.RadioButton();
            this.rdbLCV = new System.Windows.Forms.RadioButton();
            this.txtConsignmentNo = new System.Windows.Forms.TextBox();
            this.txtPackages = new System.Windows.Forms.TextBox();
            this.txtConsignmentAmount = new System.Windows.Forms.TextBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbConsignor = new System.Windows.Forms.ComboBox();
            this.cbConsignee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProConsignmentNo)).BeginInit();
            this.SuspendLayout();
            // 
            // errProConsignmentNo
            // 
            this.errProConsignmentNo.ContainerControl = this;
            // 
            // pnlExtraCharges
            // 
            this.pnlExtraCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlExtraCharges.Location = new System.Drawing.Point(37, 326);
            this.pnlExtraCharges.Name = "pnlExtraCharges";
            this.pnlExtraCharges.Size = new System.Drawing.Size(391, 132);
            this.pnlExtraCharges.TabIndex = 164;
            // 
            // linkAddExtraCharge
            // 
            this.linkAddExtraCharge.AutoSize = true;
            this.linkAddExtraCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAddExtraCharge.Location = new System.Drawing.Point(34, 304);
            this.linkAddExtraCharge.Name = "linkAddExtraCharge";
            this.linkAddExtraCharge.Size = new System.Drawing.Size(123, 17);
            this.linkAddExtraCharge.TabIndex = 163;
            this.linkAddExtraCharge.TabStop = true;
            this.linkAddExtraCharge.Text = "Add extra charges";
            // 
            // pnlMultiPoints
            // 
            this.pnlMultiPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMultiPoints.Location = new System.Drawing.Point(440, 326);
            this.pnlMultiPoints.Name = "pnlMultiPoints";
            this.pnlMultiPoints.Size = new System.Drawing.Size(391, 132);
            this.pnlMultiPoints.TabIndex = 166;
            // 
            // linkAddMultiPoint
            // 
            this.linkAddMultiPoint.AutoSize = true;
            this.linkAddMultiPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAddMultiPoint.Location = new System.Drawing.Point(437, 304);
            this.linkAddMultiPoint.Name = "linkAddMultiPoint";
            this.linkAddMultiPoint.Size = new System.Drawing.Size(110, 17);
            this.linkAddMultiPoint.TabIndex = 165;
            this.linkAddMultiPoint.TabStop = true;
            this.linkAddMultiPoint.Text = "Add extra points";
            // 
            // btnAddConsignment
            // 
            this.btnAddConsignment.AutoSize = true;
            this.btnAddConsignment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddConsignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddConsignment.Location = new System.Drawing.Point(726, 285);
            this.btnAddConsignment.Name = "btnAddConsignment";
            this.btnAddConsignment.Size = new System.Drawing.Size(43, 27);
            this.btnAddConsignment.TabIndex = 162;
            this.btnAddConsignment.Text = "Add";
            this.btnAddConsignment.UseVisualStyleBackColor = true;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(437, 211);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(88, 17);
            this.lblRate.TabIndex = 240;
            this.lblRate.Text = "Rate (in Rs.)";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInvoiceNo.Location = new System.Drawing.Point(34, 162);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(104, 17);
            this.lblInvoiceNo.TabIndex = 239;
            this.lblInvoiceNo.Text = "Invoice number";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(437, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(124, 17);
            this.lblDate.TabIndex = 241;
            this.lblDate.Text = "Consignment Date";
            // 
            // lblPackages
            // 
            this.lblPackages.AutoSize = true;
            this.lblPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPackages.Location = new System.Drawing.Point(437, 165);
            this.lblPackages.Name = "lblPackages";
            this.lblPackages.Size = new System.Drawing.Size(96, 17);
            this.lblPackages.TabIndex = 238;
            this.lblPackages.Text = "Packages Qty";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(34, 211);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(91, 17);
            this.lblWeight.TabIndex = 242;
            this.lblWeight.Text = "Weight (Ton)";
            // 
            // lblConsignee
            // 
            this.lblConsignee.AutoSize = true;
            this.lblConsignee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblConsignee.Location = new System.Drawing.Point(437, 71);
            this.lblConsignee.Name = "lblConsignee";
            this.lblConsignee.Size = new System.Drawing.Size(75, 17);
            this.lblConsignee.TabIndex = 237;
            this.lblConsignee.Text = "Consignee";
            // 
            // lblConsignmentNo
            // 
            this.lblConsignmentNo.AutoSize = true;
            this.lblConsignmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblConsignmentNo.Location = new System.Drawing.Point(34, 30);
            this.lblConsignmentNo.Name = "lblConsignmentNo";
            this.lblConsignmentNo.Size = new System.Drawing.Size(144, 17);
            this.lblConsignmentNo.TabIndex = 244;
            this.lblConsignmentNo.Text = "Consignment Number";
            // 
            // datePickerConsignment
            // 
            this.datePickerConsignment.CustomFormat = "";
            this.datePickerConsignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.datePickerConsignment.Location = new System.Drawing.Point(567, 25);
            this.datePickerConsignment.Name = "datePickerConsignment";
            this.datePickerConsignment.Size = new System.Drawing.Size(202, 23);
            this.datePickerConsignment.TabIndex = 226;
            this.datePickerConsignment.Value = new System.DateTime(2015, 2, 12, 0, 0, 0, 0);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtInvoiceNo.Location = new System.Drawing.Point(184, 162);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(202, 23);
            this.txtInvoiceNo.TabIndex = 227;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(567, 208);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(202, 23);
            this.txtRate.TabIndex = 235;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(184, 208);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(202, 23);
            this.txtWeight.TabIndex = 231;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(437, 259);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(106, 17);
            this.lblAmount.TabIndex = 245;
            this.lblAmount.Text = "Amount (in Rs.)";
            // 
            // lblConsignor
            // 
            this.lblConsignor.AutoSize = true;
            this.lblConsignor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblConsignor.Location = new System.Drawing.Point(34, 71);
            this.lblConsignor.Name = "lblConsignor";
            this.lblConsignor.Size = new System.Drawing.Size(72, 17);
            this.lblConsignor.TabIndex = 246;
            this.lblConsignor.Text = "Consignor";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFrom.Location = new System.Drawing.Point(34, 116);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(40, 17);
            this.lblFrom.TabIndex = 248;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTo.Location = new System.Drawing.Point(437, 116);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(40, 17);
            this.lblTo.TabIndex = 254;
            this.lblTo.Text = "From";
            // 
            // rdbValue
            // 
            this.rdbValue.AutoSize = true;
            this.rdbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbValue.Location = new System.Drawing.Point(184, 237);
            this.rdbValue.Name = "rdbValue";
            this.rdbValue.Size = new System.Drawing.Size(62, 21);
            this.rdbValue.TabIndex = 232;
            this.rdbValue.Text = "Value";
            this.rdbValue.UseVisualStyleBackColor = true;
            // 
            // rdbFTL
            // 
            this.rdbFTL.AutoSize = true;
            this.rdbFTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFTL.Location = new System.Drawing.Point(265, 237);
            this.rdbFTL.Name = "rdbFTL";
            this.rdbFTL.Size = new System.Drawing.Size(52, 21);
            this.rdbFTL.TabIndex = 233;
            this.rdbFTL.Text = "LCV";
            this.rdbFTL.UseVisualStyleBackColor = true;
            // 
            // rdbLCV
            // 
            this.rdbLCV.AutoSize = true;
            this.rdbLCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLCV.Location = new System.Drawing.Point(335, 237);
            this.rdbLCV.Name = "rdbLCV";
            this.rdbLCV.Size = new System.Drawing.Size(51, 21);
            this.rdbLCV.TabIndex = 234;
            this.rdbLCV.Text = "FTL";
            this.rdbLCV.UseVisualStyleBackColor = true;
            // 
            // txtConsignmentNo
            // 
            this.txtConsignmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConsignmentNo.Location = new System.Drawing.Point(184, 27);
            this.txtConsignmentNo.Name = "txtConsignmentNo";
            this.txtConsignmentNo.Size = new System.Drawing.Size(202, 23);
            this.txtConsignmentNo.TabIndex = 225;
            this.txtConsignmentNo.Leave += new System.EventHandler(this.txtConsignmentNo_Leave);
            // 
            // txtPackages
            // 
            this.txtPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPackages.Location = new System.Drawing.Point(567, 162);
            this.txtPackages.Name = "txtPackages";
            this.txtPackages.Size = new System.Drawing.Size(202, 23);
            this.txtPackages.TabIndex = 229;
            // 
            // txtConsignmentAmount
            // 
            this.txtConsignmentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsignmentAmount.Location = new System.Drawing.Point(567, 256);
            this.txtConsignmentAmount.Name = "txtConsignmentAmount";
            this.txtConsignmentAmount.Size = new System.Drawing.Size(202, 23);
            this.txtConsignmentAmount.TabIndex = 236;
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(184, 113);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(202, 21);
            this.cbFrom.TabIndex = 250;
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(567, 113);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(202, 21);
            this.cbTo.TabIndex = 251;
            // 
            // cbConsignor
            // 
            this.cbConsignor.FormattingEnabled = true;
            this.cbConsignor.Location = new System.Drawing.Point(184, 68);
            this.cbConsignor.Name = "cbConsignor";
            this.cbConsignor.Size = new System.Drawing.Size(202, 21);
            this.cbConsignor.TabIndex = 252;
            // 
            // cbConsignee
            // 
            this.cbConsignee.FormattingEnabled = true;
            this.cbConsignee.Location = new System.Drawing.Point(567, 68);
            this.cbConsignee.Name = "cbConsignee";
            this.cbConsignee.Size = new System.Drawing.Size(202, 21);
            this.cbConsignee.TabIndex = 253;
            // 
            // FormAttachConsignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 498);
            this.Controls.Add(this.cbConsignee);
            this.Controls.Add(this.cbConsignor);
            this.Controls.Add(this.lblConsignmentNo);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.pnlExtraCharges);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.linkAddExtraCharge);
            this.Controls.Add(this.txtConsignmentAmount);
            this.Controls.Add(this.pnlMultiPoints);
            this.Controls.Add(this.txtPackages);
            this.Controls.Add(this.linkAddMultiPoint);
            this.Controls.Add(this.txtConsignmentNo);
            this.Controls.Add(this.btnAddConsignment);
            this.Controls.Add(this.rdbLCV);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.rdbFTL);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.rdbValue);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblPackages);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblConsignor);
            this.Controls.Add(this.lblConsignee);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.datePickerConsignment);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.txtRate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAttachConsignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAttachConsignment";
            this.Load += new System.EventHandler(this.FormAttachConsignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProConsignmentNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errProConsignmentNo;
        private System.Windows.Forms.ComboBox cbConsignee;
        private System.Windows.Forms.ComboBox cbConsignor;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.TextBox txtConsignmentAmount;
        private System.Windows.Forms.TextBox txtPackages;
        private System.Windows.Forms.TextBox txtConsignmentNo;
        private System.Windows.Forms.RadioButton rdbLCV;
        private System.Windows.Forms.RadioButton rdbFTL;
        private System.Windows.Forms.RadioButton rdbValue;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblConsignor;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.DateTimePicker datePickerConsignment;
        private System.Windows.Forms.Label lblConsignmentNo;
        private System.Windows.Forms.Label lblConsignee;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblPackages;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnAddConsignment;
        private System.Windows.Forms.LinkLabel linkAddMultiPoint;
        private System.Windows.Forms.Panel pnlMultiPoints;
        private System.Windows.Forms.LinkLabel linkAddExtraCharge;
        private System.Windows.Forms.Panel pnlExtraCharges;
    }
}