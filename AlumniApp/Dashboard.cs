using AlumniApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL = Alumni.App.Db;

namespace AlumniApp
{
    public partial class Dashboard : Form
    {
        
        private int _id { get; set; }

        public Dashboard(int id)
        {
            _id = id;
            InitializeComponent();
            GrantPermits(id);
        }  

        private void GrantPermits(int id)
        {
            if (id == 3)
            {
                BtnGrades.Visible = false;
                this.Width = 270;
                this.Height = 280;
            }
            // 400 x 370 original 720 x 290
            else
            {
                this.Width = 520;
                this.Height = 290;
            }
        }

        public Dashboard()
        {
            InitializeComponent();   
        }

        private void BtnGrades_Click(object sender, EventArgs e)
        {
            var grades = new GradesView(_id);
            grades.ShowDialog();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            var prof = new Profile(_id);
            prof.ShowDialog();
        }
    }
}
