namespace _2020061801GHCS_FileIO
{
    partial class frmEditor
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
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdFname = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(42, 54);
            this.txtDoc.Multiline = true;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(404, 327);
            this.txtDoc.TabIndex = 0;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(486, 54);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(212, 61);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "ReadFile";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(486, 131);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(212, 61);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "WriteFile";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(42, 12);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(404, 26);
            this.txtFname.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(486, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(51, 27);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofdFname
            // 
            this.ofdFname.FileName = "openFileDialog1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(486, 216);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(212, 61);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 396);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtDoc);
            this.Name = "frmEditor";
            this.Text = "Text Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdFname;
        private System.Windows.Forms.Button btnClear;
    }
}

