namespace CsMySqlTest
{
    partial class frmDbase
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
            this.btnTestDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestDb
            // 
            this.btnTestDb.Location = new System.Drawing.Point(705, 38);
            this.btnTestDb.Name = "btnTestDb";
            this.btnTestDb.Size = new System.Drawing.Size(171, 57);
            this.btnTestDb.TabIndex = 0;
            this.btnTestDb.Text = "Test database";
            this.btnTestDb.UseVisualStyleBackColor = true;
            this.btnTestDb.Click += new System.EventHandler(this.btnTestDb_Click);
            // 
            // frmDbase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 371);
            this.Controls.Add(this.btnTestDb);
            this.Name = "frmDbase";
            this.Text = "Test Database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestDb;
    }
}

