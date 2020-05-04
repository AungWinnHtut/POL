namespace CS_rev1
{
    partial class frmTest1
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
            this.btnTest = new System.Windows.Forms.Button();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtDouble = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(617, 57);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(150, 44);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(49, 30);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(363, 26);
            this.txtInt.TabIndex = 1;
            // 
            // txtDouble
            // 
            this.txtDouble.Location = new System.Drawing.Point(49, 75);
            this.txtDouble.Name = "txtDouble";
            this.txtDouble.Size = new System.Drawing.Size(363, 26);
            this.txtDouble.TabIndex = 2;
            // 
            // frmTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDouble);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.btnTest);
            this.Name = "frmTest1";
            this.Text = "Test ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtDouble;
    }
}

