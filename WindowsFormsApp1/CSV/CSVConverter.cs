using DocumentFormat.OpenXml.Office2010.CustomUI;
using ServiceStack.Text;

namespace WindowsFormsApp1.CSV
{
    public class CSVConverter : Converter
    {
        public CSVConverter()
        {
            
        }

        public string convert(TestResults testResults)
        {
            return CsvSerializer.SerializeToCsv(testResults.getParticipants());
        }

        public string convert(TestResults testResults, object setting)
        {
            CsvConfig.ItemSeperatorString = (string) setting;
            return CsvSerializer.SerializeToCsv(testResults.getParticipants());

        }
    }
}