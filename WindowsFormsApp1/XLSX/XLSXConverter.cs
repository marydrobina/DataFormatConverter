using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.XLSX
{
    public class XLSXConverter : Converter
    {
        public XLSXConverter()
        {

        }

        public string convert(TestResults testResults)
        {
            List<string> output = new List<string>();
            foreach (var participant in testResults.getParticipants())
            {
                output.Add(participant.name + " " + participant.score);
            }

            return String.Join(", ", output.ToArray());
        }

        public string convert(TestResults testResults, object setting)
        {
            return this.convert(testResults);
        }
    }
}