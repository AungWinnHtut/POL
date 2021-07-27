namespace _2021070101_CS_HelloWorld
{
    partial class frmLogin
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
            this.lblUname = new System.Windows.Forms.Label();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(28, 31);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(83, 20);
            this.lblUname.TabIndex = 0;
            this.lblUname.Text = "Username";
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(175, 25);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(118, 26);
            this.txtUname.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(175, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(118, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(28, 73);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(360, 22);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(155, 38);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(360, 73);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 38);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.btnCancel);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtUname);
            this.grpLogin.Controls.Add(this.lblUname);
            this.grpLogin.Location = new System.Drawing.Point(30, 17);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(545, 132);
            this.grpLogin.TabIndex = 6;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Lgoin";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 160);
            this.Controls.Add(this.grpLogin);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpLogin;
    }
}