namespace GazeAwareForms
{
    partial class HelloGaze_Login
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.dateofVisit = new System.Windows.Forms.DateTimePicker();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtMedicalExpertName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(468, 428);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(367, 428);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 30);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(363, 165);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(196, 23);
            this.Welcome.TabIndex = 13;
            this.Welcome.Text = "Welcome to HelloGaze!";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(336, 365);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(95, 21);
            this.DateLabel.TabIndex = 12;
            this.DateLabel.Text = "Date of Visit";
            // 
            // dateofVisit
            // 
            this.dateofVisit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofVisit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofVisit.Location = new System.Drawing.Point(437, 359);
            this.dateofVisit.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateofVisit.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateofVisit.Name = "dateofVisit";
            this.dateofVisit.Size = new System.Drawing.Size(143, 28);
            this.dateofVisit.TabIndex = 11;
            // 
            // txtPatientId
            // 
            this.txtPatientId.BackColor = System.Drawing.Color.White;
            this.txtPatientId.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPatientId.Location = new System.Drawing.Point(308, 308);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(301, 28);
            this.txtPatientId.TabIndex = 10;
            this.txtPatientId.Text = "Patient ID";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.White;
            this.txtPatientName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPatientName.Location = new System.Drawing.Point(308, 260);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(301, 28);
            this.txtPatientName.TabIndex = 9;
            this.txtPatientName.Text = "Patient Name";
            // 
            // txtMedicalExpertName
            // 
            this.txtMedicalExpertName.BackColor = System.Drawing.Color.White;
            this.txtMedicalExpertName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicalExpertName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMedicalExpertName.Location = new System.Drawing.Point(308, 216);
            this.txtMedicalExpertName.Multiline = true;
            this.txtMedicalExpertName.Name = "txtMedicalExpertName";
            this.txtMedicalExpertName.Size = new System.Drawing.Size(301, 28);
            this.txtMedicalExpertName.TabIndex = 8;
            this.txtMedicalExpertName.Text = "Medical Expert Name";
           // this.txtMedicalExpertName.TextChanged += new System.EventHandler(this.txtMedicalExpertName_TextChanged);
            //this.txtMedicalExpertName.Enter += new System.EventHandler(this.txtMedicalExpertName_Enter);
            // 
            // HelloGaze_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.dateofVisit);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.txtMedicalExpertName);
            this.Name = "HelloGaze_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelloGaze Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker dateofVisit;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtMedicalExpertName;
    }
}