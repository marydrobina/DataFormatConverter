using Newtonsoft.Json;

namespace WindowsFormsApp1.JSON
{
    public class JsonConverterToString : Converter
    {
        public JsonConverterToString()
        {
            
        }
        public string convert(TestResults testResults)
        {
            return JsonConvert.SerializeObject(testResults.getParticipants());
        }

        public string convert(TestResults testResults, object isBeautiful)
        {
            return JsonConvert.SerializeObject(testResults.getParticipants(), Formatting.Indented);
        }
    }
}