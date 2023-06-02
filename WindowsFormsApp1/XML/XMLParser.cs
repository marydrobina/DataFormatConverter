using System.Collections.Generic;

namespace WindowsFormsApp1.XML
{
    public class XMLParser : Parser
    {
        public XMLParser()
        {
            
        }
        
        public TestResults parseDataToTestResult(List<Student> inputData)
        {
            return new TestResults(inputData);
        }
    }
}