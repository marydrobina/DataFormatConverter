using System.Collections.Generic;
using System.IO;
using System.Linq;
using OfficeOpenXml;

namespace WindowsFormsApp1.XLSX
{
    public class XLSXReader : Reader
    {
        public XLSXReader()
        {
            
        }

        public List<Student> getStudentData(string filePath)
        {
            List<Student> participants = new List<Student>();
            using (ExcelPackage xlPackage = new ExcelPackage(new FileInfo(filePath)))
            {
                var myWorksheet = xlPackage.Workbook.Worksheets.First();
                var totalRows = myWorksheet.Dimension.End.Row;
                var totalColumns = myWorksheet.Dimension.End.Column;
                for (int rowNum = 1; rowNum <= totalRows; rowNum++)
                {
                    var studentData = myWorksheet
                        .Cells[rowNum, 1, rowNum, totalColumns]
                        .Select(c => c.Value == null ? string.Empty : c.Value.ToString())
                        .ToList();
                    participants.Add(
                        new Student(studentData[0], int.Parse(studentData[1]))
                    );
                }
            }
            return participants;
        }
    }
}