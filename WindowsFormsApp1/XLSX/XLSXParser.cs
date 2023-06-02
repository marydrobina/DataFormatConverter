using System.Collections.Generic;

namespace WindowsFormsApp1.XLSX
{
    public class XLSXParser : Parser
    {
        public XLSXParser()
        {
            
        }

        public TestResults parseDataToTestResult(List<Student> inputData)
        {
            return new TestResults(inputData);
        }
    }
}