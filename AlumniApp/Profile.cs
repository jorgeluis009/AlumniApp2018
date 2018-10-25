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
    public partial class Profile : Form
    {
        private int _id { get; set; }

        public Profile(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            DLL.DTO.UserDto x;
            if (_id == 1)
            {
                x = Sourcing.GetProfile(Student.GetInstance().IdUser);
                labelType.Text = "Student";
            }
            else if (_id == 2)
            {
                x = Sourcing.GetProfile(Teacher.GetInstance().IdUser);
                labelType.Text = "Teacher";
            }
            else
            {
                x = Sourcing.GetProfile(Supervisor.GetInstance().IdUser);
                labelType.Text = "Supervisor";
            }

            labelUserName.Text = x.UserName;
            labelName.Text = x.Name;
            labelLastName.Text = x.LastName;
            labelAddress.Text = x.Address;
        }
    }
}
