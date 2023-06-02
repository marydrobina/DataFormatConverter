using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public interface Parser
    {
        TestResults parseDataToTestResult(List<Student> inputData);
    }
}