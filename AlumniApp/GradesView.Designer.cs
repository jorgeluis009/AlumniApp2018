namespace AlumniApp
{
    partial class GradesView
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
            this.GradesDataGrid = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.Subjectlabel = new System.Windows.Forms.Label();
            this.SubjectTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GradesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GradesDataGrid
            // 
            this.GradesDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.GradesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GradesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradesDataGrid.Location = new System.Drawing.Point(21, 70);
            this.GradesDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GradesDataGrid.Name = "GradesDataGrid";
            this.GradesDataGrid.RowTemplate.Height = 24;
            this.GradesDataGrid.Size = new System.Drawing.Size(875, 242);
            this.GradesDataGrid.TabIndex = 0;
            this.GradesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GradesDataGrid_CellContentClick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.labelTitle.Location = new System.Drawing.Point(12, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(233, 47);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "My Grades";
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.btnDownload.Location = new System.Drawing.Point(642, 331);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(254, 48);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download Grades";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Visible = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Subjectlabel
            // 
            this.Subjectlabel.AutoSize = true;
            this.Subjectlabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subjectlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.Subjectlabel.Location = new System.Drawing.Point(447, 32);
            this.Subjectlabel.Name = "Subjectlabel";
            this.Subjectlabel.Size = new System.Drawing.Size(124, 34);
            this.Subjectlabel.TabIndex = 3;
            this.Subjectlabel.Text = "Subject:";
            // 
            // SubjectTitle
            // 
            this.SubjectTitle.AutoSize = true;
            this.SubjectTitle.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectTitle.ForeColor = System.Drawing.Color.Silver;
            this.SubjectTitle.Location = new System.Drawing.Point(566, 40);
            this.SubjectTitle.Name = "SubjectTitle";
            this.SubjectTitle.Size = new System.Drawing.Size(69, 21);
            this.SubjectTitle.TabIndex = 4;
            this.SubjectTitle.Text = "subject";
            // 
            // GradesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(908, 391);
            this.Controls.Add(this.SubjectTitle);
            this.Controls.Add(this.Subjectlabel);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.GradesDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GradesView";
            this.Text = "GradesView";
            this.Load += new System.EventHandler(this.GradesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GradesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GradesDataGrid;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label Subjectlabel;
        private System.Windows.Forms.Label SubjectTitle;
    }
}