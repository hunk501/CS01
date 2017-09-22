namespace CS01
{
    partial class Form1
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
            this.btnReadExcelFile = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExcelFile = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnReadExcelFile
            // 
            this.btnReadExcelFile.Location = new System.Drawing.Point(40, 149);
            this.btnReadExcelFile.Name = "btnReadExcelFile";
            this.btnReadExcelFile.Size = new System.Drawing.Size(213, 43);
            this.btnReadExcelFile.TabIndex = 0;
            this.btnReadExcelFile.Text = "Read/Save Excel Data";
            this.btnReadExcelFile.UseVisualStyleBackColor = true;
            this.btnReadExcelFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(114, 52);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(139, 20);
            this.txtHost.TabIndex = 2;
            this.txtHost.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOST:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "USERNAME:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(114, 78);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(139, 20);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PASSWORD:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(360, 78);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(139, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PORT:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(360, 52);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(139, 20);
            this.txtPort.TabIndex = 9;
            this.txtPort.Text = "3306";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "DB Name:";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(114, 104);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(385, 20);
            this.txtDBName.TabIndex = 11;
            this.txtDBName.Text = "sample1";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(288, 149);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(211, 41);
            this.btnTestConnection.TabIndex = 13;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.button4_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Record(s):";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(162, 228);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 20);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Excel File:";
            // 
            // txtExcelFile
            // 
            this.txtExcelFile.Location = new System.Drawing.Point(114, 26);
            this.txtExcelFile.Name = "txtExcelFile";
            this.txtExcelFile.Size = new System.Drawing.Size(385, 20);
            this.txtExcelFile.TabIndex = 18;
            this.txtExcelFile.Text = "F:\\\\excel_file.xlsx";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 251);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(459, 23);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 300);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtExcelFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnReadExcelFile);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comelec Uploader @ D. Lira version 0.0.0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadExcelFile;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Button btnTestConnection;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExcelFile;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

