namespace EA_Logistics_Control
{
    partial class FormContacts
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
            this.MS_Signors = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // MS_Signors
            // 
            this.MS_Signors.Location = new System.Drawing.Point(0, 0);
            this.MS_Signors.Name = "MS_Signors";
            this.MS_Signors.Size = new System.Drawing.Size(528, 24);
            this.MS_Signors.TabIndex = 2;
            this.MS_Signors.Text = "menuStrip1";
            // 
            // FContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 430);
            this.Controls.Add(this.MS_Signors);
            this.MainMenuStrip = this.MS_Signors;
            this.Name = "FContacts";
            this.Text = "Consignors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Signors;
    }
}