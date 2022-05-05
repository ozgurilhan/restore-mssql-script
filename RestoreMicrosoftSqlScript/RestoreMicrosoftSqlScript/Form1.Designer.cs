namespace RestoreMicrosoftSQLScript
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
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnInstallScript = new System.Windows.Forms.Button();
            this.btnCheckConnection = new System.Windows.Forms.Button();
            this.lblLoading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(6, 20);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(533, 45);
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.Text = "Data Source=koli.ozgurilhan.com;Initial Catalog=FinalHomeWork;Integrated Security" +
    "=False;Persist Security Info=False;User ID=KapadokyaUser;Password=KapadokyaPass;" +
    "MultipleActiveResultSets=True";
            // 
            // btnInstallScript
            // 
            this.btnInstallScript.Location = new System.Drawing.Point(150, 101);
            this.btnInstallScript.Name = "btnInstallScript";
            this.btnInstallScript.Size = new System.Drawing.Size(238, 45);
            this.btnInstallScript.TabIndex = 2;
            this.btnInstallScript.Text = "Delete DB Objects and Restore SQL Script";
            this.btnInstallScript.UseVisualStyleBackColor = true;
            this.btnInstallScript.Click += new System.EventHandler(this.btnInstallScript_Click);
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.Location = new System.Drawing.Point(12, 101);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(119, 45);
            this.btnCheckConnection.TabIndex = 3;
            this.btnCheckConnection.Text = "Check the Connection";
            this.btnCheckConnection.UseVisualStyleBackColor = true;
            this.btnCheckConnection.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(409, 117);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(16, 13);
            this.lblLoading.TabIndex = 4;
            this.lblLoading.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConnectionString);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ConnectionString";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 160);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.btnCheckConnection);
            this.Controls.Add(this.btnInstallScript);
            this.Name = "Form1";
            this.Text = "Microsoft SQL Server Script Importer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnInstallScript;
        private System.Windows.Forms.Button btnCheckConnection;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

