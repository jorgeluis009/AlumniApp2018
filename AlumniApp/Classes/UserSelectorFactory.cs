using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alumni;
using DLL = Alumni.App.Db;

namespace AlumniApp.Classes
{
    class UserSelectorFactory
    {
        public DLL.DTO.UserDto User { get; set; }

        public UserSelectorFactory(DLL.DTO.UserDto user)
        {
            this.User = user;
        }

        public UserFactory CreateAccount()
        {
            if (User.IdUserType == 1)
                return new StudentFactory(User);
            else if (User.IdUserType  == 2)
                return new TeacherFactory(User);

            return new SupervisorFactory(User);
        }

    }
}