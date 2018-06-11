namespace GazeAwareForms
{
    partial class StartForm
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
            this.btnMode1 = new System.Windows.Forms.Button();
            this.btnMode2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMode1
            // 
            this.btnMode1.Location = new System.Drawing.Point(282, 82);
            this.btnMode1.Name = "btnMode1";
            this.btnMode1.Size = new System.Drawing.Size(444, 55);
            this.btnMode1.TabIndex = 0;
            this.btnMode1.Text = "Mode1";
            this.btnMode1.UseVisualStyleBackColor = true;
            this.btnMode1.Click += new System.EventHandler(this.btnMode1_Click);
            // 
            // btnMode2
            // 
            this.btnMode2.Location = new System.Drawing.Point(282, 167);
            this.btnMode2.Name = "btnMode2";
            this.btnMode2.Size = new System.Drawing.Size(444, 55);
            this.btnMode2.TabIndex = 1;
            this.btnMode2.Text = "Mode2";
            this.btnMode2.UseVisualStyleBackColor = true;
            this.btnMode2.Click += new System.EventHandler(this.btnMode2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(282, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(444, 53);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 675);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMode2);
            this.Controls.Add(this.btnMode1);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMode1;
        private System.Windows.Forms.Button btnMode2;
        private System.Windows.Forms.Button btnExit;
    }
}