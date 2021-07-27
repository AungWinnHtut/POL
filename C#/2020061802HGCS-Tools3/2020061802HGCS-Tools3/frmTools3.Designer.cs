namespace _2020061802HGCS_Tools3
{
    partial class frmTools3
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
            this.lstView = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.colCreationTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstView
            // 
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colPhone,
            this.colCreationTime});
            this.lstView.FullRowSelect = true;
            this.lstView.GridLines = true;
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(42, 37);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(534, 363);
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(603, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(186, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 168;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Phone Number";
            this.colPhone.Width = 170;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(603, 159);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(186, 44);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(603, 37);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(185, 66);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Select Files";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // colCreationTime
            // 
            this.colCreationTime.Text = "Creation Time";
            this.colCreationTime.Width = 175;
            // 
            // frmTools3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstView);
            this.Name = "frmTools3";
            this.Text = "Tools3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ColumnHeader colCreationTime;
    }
}

