namespace Trial_0001
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblGram = new System.Windows.Forms.Label();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(443, 43);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(198, 63);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(71, 43);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(70, 20);
            this.lblKg.TabIndex = 1;
            this.lblKg.Text = "Kilogram";
            // 
            // lblGram
            // 
            this.lblGram.AutoSize = true;
            this.lblGram.Location = new System.Drawing.Point(77, 86);
            this.lblGram.Name = "lblGram";
            this.lblGram.Size = new System.Drawing.Size(49, 20);
            this.lblGram.TabIndex = 2;
            this.lblGram.Text = "Gram";
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(189, 37);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(150, 26);
            this.txtKg.TabIndex = 0;
            this.txtKg.TextChanged += new System.EventHandler(this.txtKg_TextChanged);
            this.txtKg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKg_KeyDown);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(189, 86);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(150, 26);
            this.txtG.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.lblGram);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblGram;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.TextBox txtG;
    }
}

