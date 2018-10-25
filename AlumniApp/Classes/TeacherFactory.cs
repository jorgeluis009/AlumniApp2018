using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL = Alumni.App.Db;

namespace AlumniApp.Classes
{
    class TeacherFactory : UserFactory
    {
        private DLL.DTO.UserDto _user;

        public TeacherFactory(DLL.DTO.UserDto user)
        {
            this._user = user;

        }

        /// <summary>
        /// Here, things will be resolved in case there are more types of teacher
        /// </summary>
        /// <returns></returns>
        public override User CreateAccount()
        {
            return Teacher.Create(_user);
        }
    }
}
