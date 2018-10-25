using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL = Alumni.App.Db;

namespace AlumniApp.Classes
{
    class Teacher : User
    {
        private static Teacher instance = null;
        private Teacher() { }
        private Teacher(DLL.DTO.UserDto user)
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
        public static Teacher Create(DLL.DTO.UserDto user)
        {
            if (instance == null)
                instance = new Teacher(user);
            return instance;
        }

        // TODO: MUST BE FIXED 
        public static Teacher GetInstance()
        {
            if (instance == null)
                instance = new Teacher();
            return instance;
        }
    }
}
