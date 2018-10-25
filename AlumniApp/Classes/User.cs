using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL = Alumni.App.Db;

namespace AlumniApp.Classes
{
    abstract class User
    {
        public string Address { get; set; }
        public string FullName { get; set; }
        public int IdUser { get; set; }
        public int IdUserType { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public bool[] Permissions { get; set; }

        /*public static User StoreUser()
        {
            DLL.DTO.UserDto DTOuser;
            user.Address = user.Address;
            user.FullName = user.FullName;
            user.IdUser = user.IdUser;
            user.IdUserType = user.IdUserType;
            user.Name = user.Name;
            user.LastName = user.LastName;
            user.SecondLastName = user.SecondLastName;
            user.Password = user.Password;
            user.UserName = user.UserName;
            return user;
        }*/
    }
}