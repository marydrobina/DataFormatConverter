namespace WindowsFormsApp1
{
    public interface Writer
    {
        void write(string filePath, TestResults testResults);
        void write(string filePath, TestResults testResults, object setting);

    }
}