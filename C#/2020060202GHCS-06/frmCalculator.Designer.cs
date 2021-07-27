namespace _2020060202GHCS_06
{
    partial class frmCalculator
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
            this.btnHello = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHello = new System.Windows.Forms.Label();
            this.txtHello = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(425, 32);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(132, 39);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Say Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(107, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(107, 115);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(0, 20);
            this.lblHello.TabIndex = 3;
            // 
            // txtHello
            // 
            this.txtHello.Location = new System.Drawing.Point(105, 162);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(85, 26);
            this.txtHello.TabIndex = 4;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHello);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnHello);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TextBox txtHello;
    }
}

