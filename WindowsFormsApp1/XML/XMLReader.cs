using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApp1.XML
{
    public class XMLReader : Reader
    {
        public XMLReader()
        {
            
        }
        
        public List<Student> getStudentData(string filePath)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Student>));
            List<Student> participants = new List<Student>();
            using (XmlReader reader = XmlReader.Create(filePath))
            {
                participants = (List<Student>) ser.Deserialize(reader);
            }
            return participants;
        }
    }
}