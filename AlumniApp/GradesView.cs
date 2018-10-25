using AlumniApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumniApp
{
    public partial class GradesView : Form
    {
        private int _id { get; set; }
        public GradesView(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void GradesView_Load(object sender, EventArgs e)
        {
            GradesHistoryTarget adapter = new GradesHistoryAdapter();
            DataTable history;

            if (_id == 1)
            {
                history = adapter.GetGradesByUserId(Student.GetInstance().IdUser);
                btnDownload.Visible = true;
                Subjectlabel.Visible = false;
                SubjectTitle.Visible = false;
            }
            else if (_id == 2)
            {
                history = adapter.GetGradesByUserId(Teacher.GetInstance().IdUser);
                labelTitle.Text = "Students Grades";
                SubjectTitle.Text = history.Rows[1][1].ToString();
                
            }
            else
                history = adapter.GetGradesByUserId(Supervisor.GetInstance().IdUser);

            GradesDataGrid.DataSource = history;
            GradesDataGrid.DefaultCellStyle.Font = new Font("Tahoma", 11);
            SetDataGridDesign();
        }

        private void SetDataGridDesign()
        {
            this.GradesDataGrid.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.GradesDataGrid.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

            this.GradesDataGrid.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            this.GradesDataGrid.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

            GradesDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GradesDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GradesDataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            GradesDataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GradesDataGrid.BackgroundColor = Color.White;

            GradesDataGrid.EnableHeadersVisualStyles = false;
            GradesDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GradesDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(62, 120, 150);
            GradesDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GradesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void btnDownload_Click(object sender, EventArgs e)
        {
            GradesHistoryTarget adapter = new GradesHistoryAdapter();
            string config = ConfigurationManager.AppSettings["formatKey"];
            DataTable history;

            switch (config)
            {
                case "txt":
                        string[] result = adapter.GetGradesStringFormat(Student.GetInstance().IdUser);
                        File.DownloadTXT(result);
                    break;
                case "docx":
                        history = adapter.GetGradesByUserId(Student.GetInstance().IdUser);
                        File.DownloadDOCX(history);
                    break;
                default:
                    break;
            }
        }
    }
}
