using System.IO;

namespace WindowsFormsApp1.CSV
{
    public class CSVWriter : Writer
    {
        private Converter _converter;
        
        public CSVWriter()
        {
            _converter = new CSVConverter();
        }

        public void write(string filePath, TestResults testResults)
        {
            File.WriteAllText(filePath, _converter.convert(testResults));
        }

        public void write(string filePath, TestResults testResults, object setting)
        {
            File.WriteAllText(filePath, _converter.convert(testResults, setting));

        }
    }
}