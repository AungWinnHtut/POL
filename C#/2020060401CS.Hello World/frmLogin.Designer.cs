namespace _2020060401CS.Hello_World
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
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblUname = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(223, 52);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(222, 26);
            this.txtUname.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(223, 117);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(222, 26);
            this.txtPass.TabIndex = 1;
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(61, 53);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(89, 20);
            this.lblUname.TabIndex = 2;
            this.lblUname.Text = "User Name";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(61, 126);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(78, 20);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(516, 52);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 94);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 167);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUname);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnLogin;
    }
}