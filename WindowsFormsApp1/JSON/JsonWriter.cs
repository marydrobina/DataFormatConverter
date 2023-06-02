using System.IO;

namespace WindowsFormsApp1.JSON
{
    public class JsonWriter : Writer
    {
        private Converter _converter;
        public JsonWriter()
        {
            _converter = new JsonConverterToString();
        }
        
        public void write(string filePath, TestResults testResults)
        {
            File.WriteAllText(filePath, _converter.convert(testResults));
        }
        public void write(string filePath, TestResults testResults, object isBeautiful)
        {
            File.WriteAllText(filePath, _converter.convert(testResults, isBeautiful));
        }
    }
}