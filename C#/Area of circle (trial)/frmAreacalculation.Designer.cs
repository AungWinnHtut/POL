namespace Area_of_circle__trial_
{
    partial class frmAreacalculation
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
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(137, 24);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(185, 26);
            this.txtRadius.TabIndex = 0;
            this.txtRadius.TextChanged += new System.EventHandler(this.txtRadius_TextChanged);
            this.txtRadius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRadius_KeyDown);
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(138, 98);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(184, 26);
            this.txtArea.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(138, 146);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 44);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl01.Location = new System.Drawing.Point(61, 30);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(59, 20);
            this.lbl01.TabIndex = 3;
            this.lbl01.Text = "Radius";
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl02.Location = new System.Drawing.Point(61, 101);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(51, 20);
            this.lbl02.TabIndex = 4;
            this.lbl02.Text = " Area ";
            // 
            // frmAreacalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 203);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtRadius);
            this.Name = "frmAreacalculation";
            this.Text = "Area calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label lbl02;
    }
}

