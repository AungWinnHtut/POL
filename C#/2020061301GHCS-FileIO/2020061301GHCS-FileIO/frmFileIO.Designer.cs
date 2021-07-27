namespace _2020061301GHCS_FileIO
{
    partial class frmFileIO
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
            this.btnReadFile = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdFname = new System.Windows.Forms.OpenFileDialog();
            this.btnTest = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(295, 12);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(162, 41);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(12, 19);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(225, 26);
            this.txtFname.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(14, 74);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(443, 262);
            this.txtOutput.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(247, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(33, 26);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofdFname
            // 
            this.ofdFname.FileName = "openFileDialog1";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(484, 15);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(201, 115);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.ItemHeight = 20;
            this.lstList.Items.AddRange(new object[] {
            "apple",
            "ant",
            "arrow"});
            this.lstList.Location = new System.Drawing.Point(490, 140);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(363, 184);
            this.lstList.TabIndex = 5;
            this.lstList.SelectedIndexChanged += new System.EventHandler(this.lstList_SelectedIndexChanged);
            // 
            // frmFileIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 356);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.btnReadFile);
            this.Name = "frmFileIO";
            this.Text = "File IO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdFname;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ListBox lstList;
    }
}

