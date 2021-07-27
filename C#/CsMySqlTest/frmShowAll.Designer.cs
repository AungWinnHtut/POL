namespace WindowsFormsApp5
{
    partial class frmShowAll
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
            this.components = new System.ComponentModel.Container();
            this.dgvStuData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvLogin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStuData
            // 
            this.dgvStuData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuData.Location = new System.Drawing.Point(6, 25);
            this.dgvStuData.Name = "dgvStuData";
            this.dgvStuData.RowHeadersWidth = 62;
            this.dgvStuData.Size = new System.Drawing.Size(974, 233);
            this.dgvStuData.TabIndex = 0;
            this.dgvStuData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStuData_CellClick);
            this.dgvStuData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStuData_CellContentClick);
            this.dgvStuData.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStuData_CellMouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStuData);
            this.groupBox1.Location = new System.Drawing.Point(19, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(991, 271);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Location = new System.Drawing.Point(1016, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 381);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(18, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 142);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(18, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 142);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(19, 584);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 40);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 36);
            this.toolStripMenuItem1.Text = "Delete";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(195, 588);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(152, 38);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export Excel File";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvLogin);
            this.groupBox3.Location = new System.Drawing.Point(19, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(991, 271);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login Data";
            // 
            // dgvLogin
            // 
            this.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogin.Location = new System.Drawing.Point(6, 25);
            this.dgvLogin.Name = "dgvLogin";
            this.dgvLogin.RowHeadersWidth = 62;
            this.dgvLogin.Size = new System.Drawing.Size(974, 233);
            this.dgvLogin.TabIndex = 0;
            // 
            // frmShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 625);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmShowAll";
            this.Text = "Student Data Table";
            this.Load += new System.EventHandler(this.frmShowAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStuData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvLogin;
    }
}