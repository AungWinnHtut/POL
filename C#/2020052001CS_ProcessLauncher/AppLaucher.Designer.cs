namespace _2020052001CS_ProcessLauncher
{
    partial class AppLaucher
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
            this.btnLauncher = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLauncher
            // 
            this.btnLauncher.Location = new System.Drawing.Point(791, 122);
            this.btnLauncher.Name = "btnLauncher";
            this.btnLauncher.Size = new System.Drawing.Size(229, 112);
            this.btnLauncher.TabIndex = 0;
            this.btnLauncher.Text = "Launch";
            this.btnLauncher.UseVisualStyleBackColor = true;
            this.btnLauncher.Click += new System.EventHandler(this.btnLauncher_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(705, 51);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(315, 26);
            this.txtQuery.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(47, 91);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(640, 361);
            this.txtOutput.TabIndex = 2;
            // 
            // AppLaucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 526);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnLauncher);
            this.Name = "AppLaucher";
            this.Text = "Application Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLauncher;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

