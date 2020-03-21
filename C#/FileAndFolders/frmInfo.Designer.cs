namespace FileAndFolders
{
    partial class frmInfo
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
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstFnames = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(12, 97);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(792, 39);
            this.txtInfo.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 317);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(770, 51);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Show Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(13, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(568, 26);
            this.txtPath.TabIndex = 2;
            this.txtPath.Text = "d:\\\\";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(612, 8);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(176, 35);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(612, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(16, 394);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(273, 26);
            this.txtFname.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(330, 387);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstFnames
            // 
            this.lstFnames.FormattingEnabled = true;
            this.lstFnames.ItemHeight = 20;
            this.lstFnames.Location = new System.Drawing.Point(10, 153);
            this.lstFnames.Name = "lstFnames";
            this.lstFnames.ScrollAlwaysVisible = true;
            this.lstFnames.Size = new System.Drawing.Size(777, 144);
            this.lstFnames.TabIndex = 7;
            this.lstFnames.SelectedIndexChanged += new System.EventHandler(this.lstFnames_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(468, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(604, 392);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstFnames);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.txtInfo);
            this.Name = "frmInfo";
            this.Text = "Information ";
            this.Load += new System.EventHandler(this.frmInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstFnames;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

