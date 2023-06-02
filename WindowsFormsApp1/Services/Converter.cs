namespace WindowsFormsApp1
{
    public interface Converter
    {
        string convert(TestResults testResults);
        string convert(TestResults testResults, object setting);

    }
}