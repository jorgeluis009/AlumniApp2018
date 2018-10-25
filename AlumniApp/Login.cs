using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlumniApp.Classes;
using Alumni;
using DLL = Alumni.App.Db;

namespace AlumniApp
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DLL.DTO.LogInReponseDto loginResponse = Sourcing.Login(txtName.Text, txtPass.Text);
            
           if (!loginResponse.HasError)
           {
                CreateFactory(loginResponse);     
           }
            else
           {
                MessageBox.Show(loginResponse.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void CreateFactory(DLL.DTO.LogInReponseDto loginResponse)
        {
            DLL.DTO.UserDto User = Sourcing.GetUser();
            
            UserSelectorFactory Fact = new UserSelectorFactory(User);
            UserFactory accountFact = Fact.CreateAccount();
            User account = accountFact.CreateAccount();
            
            Hide();
            var Dashboard = new Dashboard(User.IdUserType);
            Dashboard.Show();
        }
    }
}