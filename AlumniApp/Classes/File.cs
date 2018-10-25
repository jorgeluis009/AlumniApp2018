using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace AlumniApp.Classes
{
    class File
    {
        public static void DownloadTXT(string[] content)
        {
            string x = GetPath();
            
            // string config = ConfigurationManager.AppSettings["formatKey"];

                try
                {
                    System.IO.File.WriteAllLines(x + "\\Grades.txt", content);
                    MessageBox.Show("File created on Desktop!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception e)
                {
                     MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        public static void DownloadDOCX(DataTable history)
        {
            using (DocX document = DocX.Create(GetPath()+"GRADES.docx"))
            {
                var titleParagraph = document.InsertParagraph();
                titleParagraph.Append("My Grades").Heading(HeadingType.Heading1);
                Paragraph p = document.InsertParagraph();
                var table = document.InsertTable(history.Rows.Count + 1, history.Columns.Count);

                table.AutoFit = AutoFit.Window;
                var border = new Border(Xceed.Words.NET.BorderStyle.Tcbs_single, BorderSize.one, 0, Color.Black);
                table.SetBorder(TableBorderType.InsideH, border);

                var Headers = table.Rows[0];
                
                // Titles
                for (int i = 0; i < history.Columns.Count; i++)
                    Headers.Cells[i].InsertParagraph().Append(history.Columns[i].ColumnName).Bold();

                for (int i = 0; i < history.Rows.Count; i++)
                {
                    var tableRow = table.Rows[i];
                    var Row = history.Rows[i];
                    for (int j = 0; j < history.Columns.Count; j++)
                        tableRow.Cells[j].InsertParagraph().Append(Row[j] + "");
                }

                // document.InsertTable(history);
                // p.Append("Hello World").Font(new FontFamily("Arial Black"));
                document.Save();
                MessageBox.Show("File created on Desktop!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private static string GetPath()
        {
            string x = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            System.IO.Directory.CreateDirectory(x + "\\AlumniDownloads");
            x += "\\AlumniDownloads\\";
            return x;
        }
    }
}
