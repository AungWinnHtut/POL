namespace _2020061102HGCS_MultipleChoice
{
    partial class frmMultipleChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultipleChoice));
            this.btnDice = new System.Windows.Forms.Button();
            this.txtDice = new System.Windows.Forms.TextBox();
            this.picQuestion = new System.Windows.Forms.PictureBox();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDice
            // 
            this.btnDice.Location = new System.Drawing.Point(161, 16);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(112, 62);
            this.btnDice.TabIndex = 0;
            this.btnDice.Text = "Dice";
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // txtDice
            // 
            this.txtDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDice.Location = new System.Drawing.Point(40, 12);
            this.txtDice.Name = "txtDice";
            this.txtDice.Size = new System.Drawing.Size(63, 66);
            this.txtDice.TabIndex = 1;
            // 
            // picQuestion
            // 
            this.picQuestion.Image = ((System.Drawing.Image)(resources.GetObject("picQuestion.Image")));
            this.picQuestion.Location = new System.Drawing.Point(40, 106);
            this.picQuestion.Name = "picQuestion";
            this.picQuestion.Size = new System.Drawing.Size(208, 180);
            this.picQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuestion.TabIndex = 2;
            this.picQuestion.TabStop = false;
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Location = new System.Drawing.Point(279, 124);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(83, 24);
            this.rdo1.TabIndex = 3;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "Zawgyi";
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Location = new System.Drawing.Point(279, 154);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(78, 24);
            this.rdo2.TabIndex = 4;
            this.rdo2.TabStop = true;
            this.rdo2.Text = "Ghost";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // rdo3
            // 
            this.rdo3.AutoSize = true;
            this.rdo3.Location = new System.Drawing.Point(279, 184);
            this.rdo3.Name = "rdo3";
            this.rdo3.Size = new System.Drawing.Size(108, 24);
            this.rdo3.TabIndex = 5;
            this.rdo3.TabStop = true;
            this.rdo3.Text = "Superman";
            this.rdo3.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(393, 104);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(181, 182);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmMultipleChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 383);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rdo3);
            this.Controls.Add(this.rdo2);
            this.Controls.Add(this.rdo1);
            this.Controls.Add(this.picQuestion);
            this.Controls.Add(this.txtDice);
            this.Controls.Add(this.btnDice);
            this.Name = "frmMultipleChoice";
            this.Text = "Multiple Choice";
            this.Load += new System.EventHandler(this.frmMultipleChoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDice;
        private System.Windows.Forms.TextBox txtDice;
        private System.Windows.Forms.PictureBox picQuestion;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.Button btnNext;
    }
}

