namespace _2020061101HGCS_HelloWorld
{
    partial class frmHello
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
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(209, 116);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(143, 49);
            this.btn.TabIndex = 0;
            this.btn.Text = "Say HelloWord";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 373);
            this.Controls.Add(this.btn);
            this.Name = "frmHello";
            this.Text = "HelloWord";
            this.Load += new System.EventHandler(this.frmHello_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
    }
}

