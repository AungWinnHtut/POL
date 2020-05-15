namespace _2020051201CS_UI
{
    partial class frmConverter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFormula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboU2 = new System.Windows.Forms.ComboBox();
            this.cboU1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtU2 = new System.Windows.Forms.TextBox();
            this.txtU1 = new System.Windows.Forms.TextBox();
            this.cboSelector = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFormula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboU2);
            this.groupBox1.Controls.Add(this.cboU1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtU2);
            this.groupBox1.Controls.Add(this.txtU1);
            this.groupBox1.Controls.Add(this.cboSelector);
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Location = new System.Drawing.Point(154, 215);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(51, 20);
            this.lblFormula.TabIndex = 7;
            this.lblFormula.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(24, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Formula";
            // 
            // cboU2
            // 
            this.cboU2.FormattingEnabled = true;
            this.cboU2.Location = new System.Drawing.Point(310, 120);
            this.cboU2.Name = "cboU2";
            this.cboU2.Size = new System.Drawing.Size(211, 28);
            this.cboU2.TabIndex = 5;
            this.cboU2.SelectedIndexChanged += new System.EventHandler(this.cboU2_SelectedIndexChanged);
            // 
            // cboU1
            // 
            this.cboU1.FormattingEnabled = true;
            this.cboU1.Location = new System.Drawing.Point(28, 121);
            this.cboU1.Name = "cboU1";
            this.cboU1.Size = new System.Drawing.Size(211, 28);
            this.cboU1.TabIndex = 4;
            this.cboU1.SelectedIndexChanged += new System.EventHandler(this.cboU1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // txtU2
            // 
            this.txtU2.Location = new System.Drawing.Point(310, 93);
            this.txtU2.Name = "txtU2";
            this.txtU2.Size = new System.Drawing.Size(212, 26);
            this.txtU2.TabIndex = 2;
            // 
            // txtU1
            // 
            this.txtU1.Location = new System.Drawing.Point(28, 93);
            this.txtU1.Name = "txtU1";
            this.txtU1.Size = new System.Drawing.Size(212, 26);
            this.txtU1.TabIndex = 1;
            this.txtU1.TextChanged += new System.EventHandler(this.txtU1_TextChanged);
            // 
            // cboSelector
            // 
            this.cboSelector.FormattingEnabled = true;
            this.cboSelector.Location = new System.Drawing.Point(25, 33);
            this.cboSelector.Name = "cboSelector";
            this.cboSelector.Size = new System.Drawing.Size(497, 28);
            this.cboSelector.TabIndex = 0;
            this.cboSelector.SelectedIndexChanged += new System.EventHandler(this.cboSelector_SelectedIndexChanged);
            // 
            // frmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 280);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConverter";
            this.Text = "Green Hackers Unit Converter";
            this.Load += new System.EventHandler(this.frmConverter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSelector;
        private System.Windows.Forms.ComboBox cboU2;
        private System.Windows.Forms.ComboBox cboU1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtU2;
        private System.Windows.Forms.TextBox txtU1;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label label2;
    }
}