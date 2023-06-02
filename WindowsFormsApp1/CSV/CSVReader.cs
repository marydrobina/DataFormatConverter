using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace WindowsFormsApp1.CSV
{
    public class CSVReader : Reader
    {
        public CSVReader()
        {
            
        }

        public List<Student> getStudentData(string filePath)
        {
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                Delimiter = ","
            };
            StreamReader reader = new StreamReader(filePath);
            List<Student> participants = new List<Student>();
            using (var csvReader = new CsvReader(reader, csvConfig))
            {
                csvReader.Read();
                while (csvReader.Read())
                {
                    csvReader.TryGetField<string>(0, out var currentName);
                    csvReader.TryGetField<string>(1, out var currentScoreStr);
                    var currentScore = int.Parse(currentScoreStr);
                    participants.Add(new Student(currentName, currentScore));
                }
            }
            reader.Close();
            return participants;
        }
    }
}