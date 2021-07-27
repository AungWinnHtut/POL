namespace WindowsFormsApp5
{
    partial class MainForm
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboUname = new System.Windows.Forms.ComboBox();
            this.cboPass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cipherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(638, 155);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(158, 55);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(638, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 55);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 155);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(584, 124);
            this.dataGridView1.TabIndex = 2;
            // 
            // cboUname
            // 
            this.cboUname.FormattingEnabled = true;
            this.cboUname.Location = new System.Drawing.Point(16, 349);
            this.cboUname.Name = "cboUname";
            this.cboUname.Size = new System.Drawing.Size(121, 28);
            this.cboUname.TabIndex = 3;
            // 
            // cboPass
            // 
            this.cboPass.FormattingEnabled = true;
            this.cboPass.Location = new System.Drawing.Point(164, 349);
            this.cboPass.Name = "cboPass";
            this.cboPass.Size = new System.Drawing.Size(121, 28);
            this.cboPass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(318, 349);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(158, 88);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read Data";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(164, 411);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(121, 26);
            this.txtPass.TabIndex = 8;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(16, 411);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(121, 26);
            this.txtUname.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataBaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cipherToolStripMenuItem,
            this.browserToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // cipherToolStripMenuItem
            // 
            this.cipherToolStripMenuItem.Name = "cipherToolStripMenuItem";
            this.cipherToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.cipherToolStripMenuItem.Text = "Cipher";
            this.cipherToolStripMenuItem.Click += new System.EventHandler(this.cipherToolStripMenuItem_Click);
            // 
            // browserToolStripMenuItem
            // 
            this.browserToolStripMenuItem.Name = "browserToolStripMenuItem";
            this.browserToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.browserToolStripMenuItem.Text = "Browser";
            this.browserToolStripMenuItem.Click += new System.EventHandler(this.browserToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByTitleToolStripMenuItem,
            this.showAllToolStripMenuItem,
            this.studentRegisterToolStripMenuItem});
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(107, 34);
            this.dataBaseToolStripMenuItem.Text = "DataBase";
            // 
            // searchByTitleToolStripMenuItem
            // 
            this.searchByTitleToolStripMenuItem.Name = "searchByTitleToolStripMenuItem";
            this.searchByTitleToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
            this.searchByTitleToolStripMenuItem.Text = "Search by title";
            this.searchByTitleToolStripMenuItem.Click += new System.EventHandler(this.searchByTitleToolStripMenuItem_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // studentRegisterToolStripMenuItem
            // 
            this.studentRegisterToolStripMenuItem.Name = "studentRegisterToolStripMenuItem";
            this.studentRegisterToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
            this.studentRegisterToolStripMenuItem.Text = "Student Register";
            this.studentRegisterToolStripMenuItem.Click += new System.EventHandler(this.studentRegisterToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPass);
            this.Controls.Add(this.cboUname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Connect DB";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboUname;
        private System.Windows.Forms.ComboBox cboPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cipherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRegisterToolStripMenuItem;
    }
}

