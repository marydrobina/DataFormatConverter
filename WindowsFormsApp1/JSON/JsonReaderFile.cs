using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp1.JSON
{
    public class JsonReaderFile : Reader
    {
        public JsonReaderFile()
        {
            
        }
        
        public List<Student> getStudentData(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string json = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<List<Student>>(json);
        }
    }
}