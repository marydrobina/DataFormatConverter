using System.IO;

namespace WindowsFormsApp1.XML
{
    public class XMLWriter : Writer
    {
        private Converter _converter;
        public XMLWriter()
        {
            _converter = new XMLConverter();
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