namespace AlumniApp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGrades = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnGrades);
            this.panel1.Controls.Add(this.BtnProfile);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 221);
            this.panel1.TabIndex = 0;
            // 
            // BtnGrades
            // 
            this.BtnGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BtnGrades.FlatAppearance.BorderSize = 0;
            this.BtnGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrades.ForeColor = System.Drawing.Color.White;
            this.BtnGrades.Image = ((System.Drawing.Image)(resources.GetObject("BtnGrades.Image")));
            this.BtnGrades.Location = new System.Drawing.Point(234, 31);
            this.BtnGrades.Name = "BtnGrades";
            this.BtnGrades.Size = new System.Drawing.Size(229, 158);
            this.BtnGrades.TabIndex = 1;
            this.BtnGrades.Text = "Grades";
            this.BtnGrades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGrades.UseVisualStyleBackColor = false;
            this.BtnGrades.Click += new System.EventHandler(this.BtnGrades_Click);
            // 
            // BtnProfile
            // 
            this.BtnProfile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnProfile.FlatAppearance.BorderSize = 0;
            this.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfile.ForeColor = System.Drawing.Color.White;
            this.BtnProfile.Image = ((System.Drawing.Image)(resources.GetObject("BtnProfile.Image")));
            this.BtnProfile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProfile.Location = new System.Drawing.Point(3, 31);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(229, 158);
            this.BtnProfile.TabIndex = 0;
            this.BtnProfile.Text = "Profile";
            this.BtnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProfile.UseVisualStyleBackColor = true;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CancelButton = this.BtnProfile;
            this.ClientSize = new System.Drawing.Size(504, 251);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGrades;
        private System.Windows.Forms.Button BtnProfile;
    }
}