namespace EA_Logistics_Control
{
    partial class FormLogin
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
            this.TBLoginPW = new System.Windows.Forms.TextBox();
            this.LLoginPW = new System.Windows.Forms.Label();
            this.TBLoginName = new System.Windows.Forms.TextBox();
            this.LLoginName = new System.Windows.Forms.Label();
            this.BLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBLoginPW
            // 
            this.TBLoginPW.Location = new System.Drawing.Point(139, 113);
            this.TBLoginPW.Name = "TBLoginPW";
            this.TBLoginPW.Size = new System.Drawing.Size(100, 20);
            this.TBLoginPW.TabIndex = 9;
            // 
            // LLoginPW
            // 
            this.LLoginPW.AutoSize = true;
            this.LLoginPW.Location = new System.Drawing.Point(46, 116);
            this.LLoginPW.Name = "LLoginPW";
            this.LLoginPW.Size = new System.Drawing.Size(53, 13);
            this.LLoginPW.TabIndex = 8;
            this.LLoginPW.Text = "Password";
            // 
            // TBLoginName
            // 
            this.TBLoginName.Location = new System.Drawing.Point(139, 55);
            this.TBLoginName.Name = "TBLoginName";
            this.TBLoginName.Size = new System.Drawing.Size(100, 20);
            this.TBLoginName.TabIndex = 7;
            // 
            // LLoginName
            // 
            this.LLoginName.AutoSize = true;
            this.LLoginName.Location = new System.Drawing.Point(46, 61);
            this.LLoginName.Name = "LLoginName";
            this.LLoginName.Size = new System.Drawing.Size(47, 13);
            this.LLoginName.TabIndex = 6;
            this.LLoginName.Text = "Login ID";
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(99, 172);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(99, 36);
            this.BLogin.TabIndex = 5;
            this.BLogin.Text = "Login";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.TBLoginPW);
            this.Controls.Add(this.LLoginPW);
            this.Controls.Add(this.TBLoginName);
            this.Controls.Add(this.LLoginName);
            this.Controls.Add(this.BLogin);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBLoginPW;
        private System.Windows.Forms.Label LLoginPW;
        private System.Windows.Forms.TextBox TBLoginName;
        private System.Windows.Forms.Label LLoginName;
        private System.Windows.Forms.Button BLogin;

    }
}