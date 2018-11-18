namespace EA_Logistics_Control
{
    partial class FormNewBill
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
            this.BTSP = new System.Windows.Forms.ToolStripPanel();
            this.TTSP = new System.Windows.Forms.ToolStripPanel();
            this.RTSP = new System.Windows.Forms.ToolStripPanel();
            this.LTSP = new System.Windows.Forms.ToolStripPanel();
            this.CP = new System.Windows.Forms.ToolStripContentPanel();
            this.errProStatical = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProParty = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProTotal = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.cbParty = new System.Windows.Forms.ComboBox();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPaying = new System.Windows.Forms.Label();
            this.datePickerBill = new System.Windows.Forms.DateTimePicker();
            this.txtStatical = new System.Windows.Forms.TextBox();
            this.lblStatical = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvConsignments = new System.Windows.Forms.DataGridView();
            this.errProBillNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextAttachConsignment = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProStatical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProParty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProTotal)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProBillNo)).BeginInit();
            this.SuspendLayout();
            // 
            // BTSP
            // 
            this.BTSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTSP.Location = new System.Drawing.Point(0, 175);
            this.BTSP.Name = "BTSP";
            this.BTSP.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BTSP.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BTSP.Size = new System.Drawing.Size(150, 0);
            // 
            // TTSP
            // 
            this.TTSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.TTSP.Location = new System.Drawing.Point(0, 0);
            this.TTSP.Name = "TTSP";
            this.TTSP.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TTSP.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TTSP.Size = new System.Drawing.Size(150, 25);
            // 
            // RTSP
            // 
            this.RTSP.Dock = System.Windows.Forms.DockStyle.Right;
            this.RTSP.Location = new System.Drawing.Point(150, 25);
            this.RTSP.Name = "RTSP";
            this.RTSP.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RTSP.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.RTSP.Size = new System.Drawing.Size(0, 150);
            // 
            // LTSP
            // 
            this.LTSP.Dock = System.Windows.Forms.DockStyle.Left;
            this.LTSP.Location = new System.Drawing.Point(0, 25);
            this.LTSP.Name = "LTSP";
            this.LTSP.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LTSP.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LTSP.Size = new System.Drawing.Size(0, 150);
            // 
            // CP
            // 
            this.CP.Size = new System.Drawing.Size(150, 150);
            // 
            // errProStatical
            // 
            this.errProStatical.ContainerControl = this;
            // 
            // errProParty
            // 
            this.errProParty.ContainerControl = this;
            // 
            // errProTotal
            // 
            this.errProTotal.ContainerControl = this;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnlHeader);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvConsignments);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1033, 418);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1033, 443);
            this.toolStripContainer1.TabIndex = 182;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.cbParty);
            this.pnlHeader.Controls.Add(this.lblBillNo);
            this.pnlHeader.Controls.Add(this.txtBillNo);
            this.pnlHeader.Controls.Add(this.lblTotal);
            this.pnlHeader.Controls.Add(this.txtAmount);
            this.pnlHeader.Controls.Add(this.lblPaying);
            this.pnlHeader.Controls.Add(this.datePickerBill);
            this.pnlHeader.Controls.Add(this.txtStatical);
            this.pnlHeader.Controls.Add(this.lblStatical);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Location = new System.Drawing.Point(3, 11);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1027, 108);
            this.pnlHeader.TabIndex = 183;
            // 
            // cbParty
            // 
            this.cbParty.FormattingEnabled = true;
            this.cbParty.Location = new System.Drawing.Point(117, 53);
            this.cbParty.Name = "cbParty";
            this.cbParty.Size = new System.Drawing.Size(375, 21);
            this.cbParty.TabIndex = 224;
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBillNo.Location = new System.Drawing.Point(10, 16);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(50, 17);
            this.lblBillNo.TabIndex = 42;
            this.lblBillNo.Text = "Bill no.";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBillNo.Location = new System.Drawing.Point(117, 13);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(124, 23);
            this.txtBillNo.TabIndex = 180;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotal.Location = new System.Drawing.Point(796, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 17);
            this.lblTotal.TabIndex = 57;
            this.lblTotal.Text = "Total Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAmount.Location = new System.Drawing.Point(894, 13);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 23);
            this.txtAmount.TabIndex = 119;
            // 
            // lblPaying
            // 
            this.lblPaying.AutoSize = true;
            this.lblPaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaying.Location = new System.Drawing.Point(10, 56);
            this.lblPaying.Name = "lblPaying";
            this.lblPaying.Size = new System.Drawing.Size(88, 17);
            this.lblPaying.TabIndex = 59;
            this.lblPaying.Text = "Paying Party";
            // 
            // datePickerBill
            // 
            this.datePickerBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.datePickerBill.Location = new System.Drawing.Point(371, 13);
            this.datePickerBill.Name = "datePickerBill";
            this.datePickerBill.Size = new System.Drawing.Size(121, 23);
            this.datePickerBill.TabIndex = 40;
            // 
            // txtStatical
            // 
            this.txtStatical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStatical.Location = new System.Drawing.Point(643, 13);
            this.txtStatical.Name = "txtStatical";
            this.txtStatical.Size = new System.Drawing.Size(124, 23);
            this.txtStatical.TabIndex = 58;
            // 
            // lblStatical
            // 
            this.lblStatical.AutoSize = true;
            this.lblStatical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatical.Location = new System.Drawing.Point(535, 16);
            this.lblStatical.Name = "lblStatical";
            this.lblStatical.Size = new System.Drawing.Size(102, 17);
            this.lblStatical.TabIndex = 59;
            this.lblStatical.Text = "Statical charge";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(323, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 44;
            this.lblDate.Text = " Date";
            // 
            // dgvConsignments
            // 
            this.dgvConsignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsignments.Location = new System.Drawing.Point(3, 142);
            this.dgvConsignments.Name = "dgvConsignments";
            this.dgvConsignments.Size = new System.Drawing.Size(242, 161);
            this.dgvConsignments.TabIndex = 182;
            // 
            // errProBillNo
            // 
            this.errProBillNo.ContainerControl = this;
            // 
            // contextAttachConsignment
            // 
            this.contextAttachConsignment.Name = "contextAttachConsignment";
            this.contextAttachConsignment.Size = new System.Drawing.Size(153, 26);
            // 
            // FormNewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1033, 443);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FormNewBill";
            this.Text = "New ";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProStatical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProParty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProTotal)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsignments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProBillNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.ToolStripContentPanel CP;

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;

        #region ToolStripPanel
        private System.Windows.Forms.ToolStripPanel BTSP;
        private System.Windows.Forms.ToolStripPanel TTSP;
        private System.Windows.Forms.ToolStripPanel RTSP;
        private System.Windows.Forms.ToolStripPanel LTSP;
        #endregion

        #region ErrorProvider

        private System.Windows.Forms.ErrorProvider errProStatical;
        private System.Windows.Forms.ErrorProvider errProParty;
        private System.Windows.Forms.ErrorProvider errProTotal;
        #endregion
        
        #region Panels

        #endregion

        #region Labels

        #endregion

        #region LinkLabel

        #endregion

        #region Button

        #endregion

        #region TextBox

        #endregion

        private System.Windows.Forms.ErrorProvider errProBillNo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.ComboBox cbParty;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblPaying;
        private System.Windows.Forms.DateTimePicker datePickerBill;
        private System.Windows.Forms.TextBox txtStatical;
        private System.Windows.Forms.Label lblStatical;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvConsignments;
        private System.Windows.Forms.ContextMenuStrip contextAttachConsignment;
    }
}

