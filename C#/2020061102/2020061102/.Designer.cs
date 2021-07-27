namespace _2020061102
{
    partial class Form1
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
            this.btnHelloword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHelloword
            // 
            this.btnHelloword.Location = new System.Drawing.Point(531, 105);
            this.btnHelloword.Name = "btnHelloword";
            this.btnHelloword.Size = new System.Drawing.Size(160, 80);
            this.btnHelloword.TabIndex = 0;
            this.btnHelloword.Text = "HelloWord";
            this.btnHelloword.UseVisualStyleBackColor = true;
            this.btnHelloword.Click += new System.EventHandler(this.btnHelloword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHelloword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelloword;
    }
}

