namespace _2020050901CS_helloWorld
{
    partial class frmSecret
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
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(20, 17);
            this.txtSecret.Multiline = true;
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(524, 210);
            this.txtSecret.TabIndex = 0;
            this.txtSecret.Text = "This is Secret Information";
            // 
            // frmSecret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 237);
            this.Controls.Add(this.txtSecret);
            this.Name = "frmSecret";
            this.Text = "frmSecret";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSecret_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSecret;
    }
}