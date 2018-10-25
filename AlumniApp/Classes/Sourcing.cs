using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL = Alumni.App.Db;

namespace AlumniApp.Classes
{
    class Sourcing
    {
        private static DLL.UserService UserService = new DLL.UserService();
        private static DLL.AcademicInfoService AcademicInfo = new DLL.AcademicInfoService();
        private static DLL.DTO.UserDto _user;


        public static DLL.DTO.UserDto GetUser()
        {
            return _user;
        }

        public static DLL.DTO.LogInReponseDto Login(string user, string pass)
        {
            DLL.DTO.LogInReponseDto response = UserService.LogIn(user, pass);
            _user = response.LoggedUser;
            return response;
        }

        public static DLL.DTO.UserDto GetProfile(int id)
        {
            return UserService.GetProfile(id);
        }

        public static List<DLL.DTO.UserSubjectDto> GetGradesList(int id)
        {
            return AcademicInfo.GetSubjectsAndGradesByUser(id);
        }
    }
}
