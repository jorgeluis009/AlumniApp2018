using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL = Alumni.App.Db;

namespace AlumniApp.Classes
{
    class SupervisorFactory : UserFactory
    {
        private DLL.DTO.UserDto _user;

        public SupervisorFactory(DLL.DTO.UserDto user)
        {
            this._user = user;
        }

        /// <summary>
        /// Here, things will be resolved in case there are more types of supervisor
        /// </summary>
        /// <returns></returns>
        public override User CreateAccount()
        {
            return Supervisor.Create(_user);
        }
    }
}
