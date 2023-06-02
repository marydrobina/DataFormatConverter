using System.Collections.Generic;

namespace WindowsFormsApp1.JSON
{
    public class JsonParser : Parser
    {
        public JsonParser()
        {
            
        }
        public TestResults parseDataToTestResult(List<Student> inputData)
        {
            return new TestResults(inputData);
        }
    }
}