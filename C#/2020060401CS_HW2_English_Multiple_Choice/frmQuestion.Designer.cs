namespace _2020060401CS_HW2_English_Multiple_Choice
{
    partial class frmQuestion
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
            this.picQuestion = new System.Windows.Forms.PictureBox();
            this.rdoAns1 = new System.Windows.Forms.RadioButton();
            this.rdoAns2 = new System.Windows.Forms.RadioButton();
            this.rdoAns3 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblMarks = new System.Windows.Forms.Label();
            this.txtMarks = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // picQuestion
            // 
            this.picQuestion.Location = new System.Drawing.Point(16, 24);
            this.picQuestion.Name = "picQuestion";
            this.picQuestion.Size = new System.Drawing.Size(266, 183);
            this.picQuestion.TabIndex = 0;
            this.picQuestion.TabStop = false;
            // 
            // rdoAns1
            // 
            this.rdoAns1.AutoSize = true;
            this.rdoAns1.Location = new System.Drawing.Point(307, 24);
            this.rdoAns1.Name = "rdoAns1";
            this.rdoAns1.Size = new System.Drawing.Size(71, 24);
            this.rdoAns1.TabIndex = 1;
            this.rdoAns1.TabStop = true;
            this.rdoAns1.Text = "Ans1";
            this.rdoAns1.UseVisualStyleBackColor = true;
            // 
            // rdoAns2
            // 
            this.rdoAns2.AutoSize = true;
            this.rdoAns2.Location = new System.Drawing.Point(307, 54);
            this.rdoAns2.Name = "rdoAns2";
            this.rdoAns2.Size = new System.Drawing.Size(71, 24);
            this.rdoAns2.TabIndex = 2;
            this.rdoAns2.TabStop = true;
            this.rdoAns2.Text = "Ans2";
            this.rdoAns2.UseVisualStyleBackColor = true;
            // 
            // rdoAns3
            // 
            this.rdoAns3.AutoSize = true;
            this.rdoAns3.Location = new System.Drawing.Point(307, 84);
            this.rdoAns3.Name = "rdoAns3";
            this.rdoAns3.Size = new System.Drawing.Size(71, 24);
            this.rdoAns3.TabIndex = 3;
            this.rdoAns3.TabStop = true;
            this.rdoAns3.Text = "Ans3";
            this.rdoAns3.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(365, 262);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 41);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(14, 269);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(52, 20);
            this.lblMarks.TabIndex = 5;
            this.lblMarks.Text = "Marks";
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(89, 262);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(46, 26);
            this.txtMarks.TabIndex = 6;
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 308);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rdoAns3);
            this.Controls.Add(this.rdoAns2);
            this.Controls.Add(this.rdoAns1);
            this.Controls.Add(this.picQuestion);
            this.Name = "frmQuestion";
            this.Text = "Question";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picQuestion;
        private System.Windows.Forms.RadioButton rdoAns1;
        private System.Windows.Forms.RadioButton rdoAns2;
        private System.Windows.Forms.RadioButton rdoAns3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.TextBox txtMarks;
    }
}

