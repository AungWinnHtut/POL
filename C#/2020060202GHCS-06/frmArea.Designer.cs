namespace _2020060202GHCS_06
{
    partial class frmArea
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
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.gbCalculation = new System.Windows.Forms.GroupBox();
            this.gbCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(226, 35);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(159, 77);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(22, 35);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(59, 20);
            this.lblRadius.TabIndex = 1;
            this.lblRadius.Text = "Radius";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(22, 86);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(43, 20);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(106, 35);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 26);
            this.txtRadius.TabIndex = 3;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(106, 86);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 26);
            this.txtArea.TabIndex = 4;
            // 
            // gbCalculation
            // 
            this.gbCalculation.Controls.Add(this.btnCalculate);
            this.gbCalculation.Controls.Add(this.txtArea);
            this.gbCalculation.Controls.Add(this.lblRadius);
            this.gbCalculation.Controls.Add(this.txtRadius);
            this.gbCalculation.Controls.Add(this.lblArea);
            this.gbCalculation.Location = new System.Drawing.Point(12, 12);
            this.gbCalculation.Name = "gbCalculation";
            this.gbCalculation.Size = new System.Drawing.Size(417, 128);
            this.gbCalculation.TabIndex = 5;
            this.gbCalculation.TabStop = false;
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 153);
            this.Controls.Add(this.gbCalculation);
            this.Name = "frmArea";
            this.Text = "Area of Circle Calculator";
            this.gbCalculation.ResumeLayout(false);
            this.gbCalculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.GroupBox gbCalculation;
    }
}