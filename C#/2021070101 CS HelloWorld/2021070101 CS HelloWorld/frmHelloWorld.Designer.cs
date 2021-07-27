namespace _2021070101_CS_HelloWorld
{
    partial class frmHelloWorld
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
            this.btnSayHello = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSayHello2 = new System.Windows.Forms.Button();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.tabProperties = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grpInput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPages.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.tabProperties.SuspendLayout();
            this.tabHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(6, 26);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(145, 46);
            this.btnSayHello.TabIndex = 0;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.lblName);
            this.grpInput.Controls.Add(this.txtName);
            this.grpInput.Location = new System.Drawing.Point(6, 5);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(324, 248);
            this.grpInput.TabIndex = 3;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Inputs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSayHello2);
            this.groupBox2.Controls.Add(this.btnSayHello);
            this.groupBox2.Location = new System.Drawing.Point(364, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 247);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnSayHello2
            // 
            this.btnSayHello2.Location = new System.Drawing.Point(6, 100);
            this.btnSayHello2.Name = "btnSayHello2";
            this.btnSayHello2.Size = new System.Drawing.Size(145, 46);
            this.btnSayHello2.TabIndex = 1;
            this.btnSayHello2.Text = "Say Hello 2";
            this.btnSayHello2.UseVisualStyleBackColor = true;
            this.btnSayHello2.Click += new System.EventHandler(this.btnSayHello2_Click);
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabInput);
            this.tabPages.Controls.Add(this.tabProperties);
            this.tabPages.Controls.Add(this.tabHelp);
            this.tabPages.Location = new System.Drawing.Point(19, 17);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(766, 292);
            this.tabPages.TabIndex = 5;
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.grpInput);
            this.tabInput.Controls.Add(this.groupBox2);
            this.tabInput.Location = new System.Drawing.Point(4, 29);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInput.Size = new System.Drawing.Size(758, 259);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Inputs";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // tabProperties
            // 
            this.tabProperties.Controls.Add(this.richTextBox1);
            this.tabProperties.Location = new System.Drawing.Point(4, 29);
            this.tabProperties.Name = "tabProperties";
            this.tabProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tabProperties.Size = new System.Drawing.Size(758, 259);
            this.tabProperties.TabIndex = 1;
            this.tabProperties.Text = "Properties";
            this.tabProperties.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 193);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.radioButton2);
            this.tabHelp.Controls.Add(this.radioButton1);
            this.tabHelp.Location = new System.Drawing.Point(4, 29);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Size = new System.Drawing.Size(758, 259);
            this.tabHelp.TabIndex = 2;
            this.tabHelp.Text = "Help";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(66, 80);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(64, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 455);
            this.Controls.Add(this.tabPages);
            this.Name = "frmHelloWorld";
            this.Text = "Hello World";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHelloWorld_FormClosing);
            this.Load += new System.EventHandler(this.frmHelloWorld_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPages.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tabProperties.ResumeLayout(false);
            this.tabHelp.ResumeLayout(false);
            this.tabHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TabPage tabProperties;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnSayHello2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

