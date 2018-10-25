using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL = Alumni.App.Db;

namespace AlumniApp.Classes
{
    class GradesHistoryAdapter : GradesHistoryTarget
    {
        public override DataTable GetGradesByUserId(int id)
        {
            List<DLL.DTO.UserSubjectDto> list = Sourcing.GetGradesList(id);
            DataTable results = new DataTable();
            results.Columns.Add(new DataColumn("Student", typeof(string)));
            results.Columns.Add(new DataColumn("Subject Name", typeof(string)));
            results.Columns.Add(new DataColumn("Unit 1", typeof(decimal)));
            results.Columns.Add(new DataColumn("Unit 2", typeof(decimal)));
            results.Columns.Add(new DataColumn("Unit 3", typeof(decimal)));
            results.Columns.Add(new DataColumn("Average", typeof(decimal)));

            for (int i = 0; i < list.Count; i++)
            {
                DataRow row = results.NewRow();
                row[0] = list[i].UserName;
                row[1] = list[i].SubjectName;
                row[2] = list[i].Grade1;
                row[3] = list[i].Grade2;
                row[4] = list[i].Grade3;
                row[5] = list[i].AverageSubject;                
                results.Rows.Add(row);
            }
            return results;
        }

		public override string[] GetGradesStringFormat(int id)
        {
            DLL.AcademicInfoService info = new DLL.AcademicInfoService();
            List<DLL.DTO.UserSubjectDto> list = info.GetSubjectsAndGradesByUser(id);

            string[] arr = new string[list.Count+1];
            float x, y, z;
            arr[0] = " Name\t\tSubject\t\t\t\tUnit 1\t Unit 2\t Unit 3\t Avg";
            
            for (int i = 0; i < list.Count(); i++)
            {
                x = (float)Math.Round(list[i].Grade1, 2);
                y = (float)Math.Round(list[i].Grade2, 2);
                z = (float)Math.Round(list[i].Grade3, 2);

                if (!list[i].SubjectName.Contains("Programación Orientada a Objetos"))
                {
                    arr[i + 1] = list[i].UserName + "\t" + list[i].SubjectName + "\t\t\t" + x
                        + "\t" + y + "\t" +
                        "\t" + z + "\t" + list[i].AverageSubject;
                }
                else{
                    arr[i + 1] = list[i].UserName + "\t" + list[i].SubjectName + "\t" + x
                        + "\t" + y + "\t" +
                        "\t" + z + "\t" + list[i].AverageSubject;
                }
            }
            return arr;
        }
 
    }
}
