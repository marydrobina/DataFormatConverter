namespace WindowsFormsApp1
{
    public interface TestResultsService
    {
        void readData(string filePath, string extension);
        TestResults getTestResults();

    }
}
