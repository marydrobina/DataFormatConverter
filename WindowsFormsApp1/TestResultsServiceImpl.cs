using WindowsFormsApp1.CSV;
using WindowsFormsApp1.JSON;
using WindowsFormsApp1.XLSX;
using WindowsFormsApp1.XML;

namespace WindowsFormsApp1
{
    public class TestResultsServiceImpl : TestResultsService
    {
        private readonly TestResults _testResults;

        public TestResultsServiceImpl()
        {
            _testResults = new TestResults();
        }

        public TestResultsServiceImpl (TestResults testResults)
        {
            _testResults = testResults;
        }

        public TestResults getTestResults()
        {
            return _testResults;
        }

        public void readData(string filePath, string extension)
        {
            Reader reader;
            Parser parser;
            switch (extension)
            {
                case string a when a.Contains("json"):
                    reader = new JsonReaderFile();
                    parser = new JsonParser();
                    _testResults.setParticipants(
                        parser.parseDataToTestResult(
                            reader.getStudentData(filePath)
                        ).getParticipants());
                    break;
                case string a when a.Contains("xml"):
                    reader = new XMLReader();
                    parser = new XMLParser();
                    _testResults.setParticipants(
                        parser.parseDataToTestResult(
                            reader.getStudentData(filePath)
                        ).getParticipants());
                    break;
                case string a when a.Contains("csv"):
                    reader = new CSVReader();
                    parser = new CSVParser();
                    _testResults.setParticipants(
                        parser.parseDataToTestResult(
                            reader.getStudentData(filePath)
                        ).getParticipants());
                    break;
                case string a when a.Contains("xlsx"):
                    reader = new XLSXReader();
                    parser = new XLSXParser();
                    _testResults.setParticipants(
                        parser.parseDataToTestResult(
                            reader.getStudentData(filePath)
                        ).getParticipants());
                    break;
            }
        }
    }
}
