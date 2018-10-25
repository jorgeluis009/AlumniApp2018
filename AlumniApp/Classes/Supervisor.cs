using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL = Alumni.App.Db;

namespace AlumniApp.Classes
{
    class Supervisor : User
    {
        private static Supervisor instance = null;
        private Supervisor(){}
        private Supervisor(DLL.DTO.UserDto user)
        {
            Address = user.Address;
            FullName = user.FullName;
            IdUser = user.IdUser;
            IdUserType = user.IdUserType;
            Name = user.Name;
            LastName = user.LastName;
            SecondLastName = user.SecondLastName;
            Password = user.Password;
            UserName = user.UserName;
            Permissions = new bool[3];
            Permissions[0] = true;
            Permissions[1] = false;
            Permissions[2] = true;
        }

        public static Supervisor Create(DLL.DTO.UserDto user)
        {
            if (instance == null)
                instance = new Supervisor(user);
            return instance;
        }

        // TODO: MUST BE FIXED 
        public static Supervisor GetInstance()
        {
            if (instance == null)
                instance = new Supervisor();
            return instance;
        }

    }
}
