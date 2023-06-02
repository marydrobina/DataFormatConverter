using System.Collections.Generic;

namespace WindowsFormsApp1.CSV
{
    public class CSVParser : Parser
    {
        public CSVParser()
        {
            
        }

        public TestResults parseDataToTestResult(List<Student> inputData)
        {
            return new TestResults(inputData);
        }
    }
}