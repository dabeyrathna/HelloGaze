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
            this.label3 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.dateofVisit = new System.Windows.Forms.DateTimePicker();
            this.PatientID = new System.Windows.Forms.TextBox();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.MedicalExpertName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "© HelloGaze 2018";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(439, 392);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 30);
            this.Exit.TabIndex = 29;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(338, 392);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 30);
            this.Login.TabIndex = 28;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(277, 116);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(303, 40);
            this.Welcome.TabIndex = 27;
            this.Welcome.Text = "Welcome to HelloGaze!";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(307, 329);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(95, 21);
            this.DateLabel.TabIndex = 26;
            this.DateLabel.Text = "Date of Visit";
            // 
            // dateofVisit
            // 
            this.dateofVisit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofVisit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofVisit.Location = new System.Drawing.Point(408, 323);
            this.dateofVisit.Name = "dateofVisit";
            this.dateofVisit.Size = new System.Drawing.Size(143, 28);
            this.dateofVisit.TabIndex = 25;
            // 
            // PatientID
            // 
            this.PatientID.BackColor = System.Drawing.Color.White;
            this.PatientID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientID.ForeColor = System.Drawing.Color.Silver;
            this.PatientID.Location = new System.Drawing.Point(279, 272);
            this.PatientID.Name = "PatientID";
            this.PatientID.Size = new System.Drawing.Size(301, 28);
            this.PatientID.TabIndex = 24;
            this.PatientID.Text = "Patient ID";
            this.PatientID.Enter += new System.EventHandler(this.PatientID_Enter);
            this.PatientID.Leave += new System.EventHandler(this.PatientID_Leave);
            // 
            // PatientName
            // 
            this.PatientName.BackColor = System.Drawing.Color.White;
            this.PatientName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.ForeColor = System.Drawing.Color.Silver;
            this.PatientName.Location = new System.Drawing.Point(279, 224);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(301, 28);
            this.PatientName.TabIndex = 23;
            this.PatientName.Text = "Patient Name";
            this.PatientName.Enter += new System.EventHandler(this.PatientName_Enter);
            this.PatientName.Leave += new System.EventHandler(this.PatientName_Leave);
            // 
            // MedicalExpertName
            // 
            this.MedicalExpertName.BackColor = System.Drawing.Color.White;
            this.MedicalExpertName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicalExpertName.ForeColor = System.Drawing.Color.Silver;
            this.MedicalExpertName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MedicalExpertName.Location = new System.Drawing.Point(279, 180);
            this.MedicalExpertName.Multiline = true;
            this.MedicalExpertName.Name = "MedicalExpertName";
            this.MedicalExpertName.Size = new System.Drawing.Size(301, 28);
            this.MedicalExpertName.TabIndex = 22;
            this.MedicalExpertName.Text = "Medical Expert Name";
            this.MedicalExpertName.Enter += new System.EventHandler(this.MedicalExpertName_Enter);
            this.MedicalExpertName.Leave += new System.EventHandler(this.MedicalExpertName_Leave);
            // 
            // HelloGaze_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.dateofVisit);
            this.Controls.Add(this.PatientID);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.MedicalExpertName);
            this.Name = "HelloGaze_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelloGaze Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker dateofVisit;
        private System.Windows.Forms.TextBox PatientID;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.TextBox MedicalExpertName;
    }
}