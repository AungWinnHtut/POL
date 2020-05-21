namespace _2020052101CS_7zip
{
    partial class frm7zip
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
            this.btnZip = new System.Windows.Forms.Button();
            this.btnUnzip = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnZip
            // 
            this.btnZip.Location = new System.Drawing.Point(725, 32);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(219, 54);
            this.btnZip.TabIndex = 0;
            this.btnZip.Text = "Zip Archive";
            this.btnZip.UseVisualStyleBackColor = true;
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // btnUnzip
            // 
            this.btnUnzip.Location = new System.Drawing.Point(725, 126);
            this.btnUnzip.Name = "btnUnzip";
            this.btnUnzip.Size = new System.Drawing.Size(219, 54);
            this.btnUnzip.TabIndex = 1;
            this.btnUnzip.Text = "UnZip Archive";
            this.btnUnzip.UseVisualStyleBackColor = true;
            this.btnUnzip.Click += new System.EventHandler(this.btnUnzip_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(29, 112);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(669, 310);
            this.txtOutput.TabIndex = 2;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "7z",
            "zip"});
            this.cboType.Location = new System.Drawing.Point(34, 36);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(151, 28);
            this.cboType.TabIndex = 3;
            this.cboType.Text = "7z";
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(213, 37);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(175, 26);
            this.txtFname.TabIndex = 4;
            this.txtFname.Text = "archive";
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(412, 40);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 26);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "password";
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frm7zip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnUnzip);
            this.Controls.Add(this.btnZip);
            this.Name = "frm7zip";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm7zip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.Button btnUnzip;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

