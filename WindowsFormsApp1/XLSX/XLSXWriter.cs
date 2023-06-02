using ClosedXML.Excel;

namespace WindowsFormsApp1.XLSX
{
    public class XLSXWriter : Writer
    {
        public XLSXWriter()
        {
            
        }

        public void write(string filePath, TestResults testResults)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Test_Results");
            ws.Cell(1, 1).InsertTable(testResults.getParticipants());
            wb.SaveAs(filePath);
        }

        public void write(string filePath, TestResults testResults, object setting)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add((string)setting);
            ws.Cell(1, 1).InsertTable(testResults.getParticipants());
            wb.SaveAs(filePath);
        }
    }
}