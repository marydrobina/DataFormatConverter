using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public interface Reader
    {
        List<Student> getStudentData(string filePath);
    }
}