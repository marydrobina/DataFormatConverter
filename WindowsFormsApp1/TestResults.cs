using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TestResults
    {
        private List<Student> participants;
        
        public TestResults ()
        {
            participants = new List<Student>();
        }

        public TestResults (List<Student> participants)
        {
            this.participants = participants;
        }

        public List<Student> getParticipants()
        {
            return participants;
        }

        public void setParticipants(List <Student> participants)
        {
            this.participants = participants;
        }

        public void addParticipant(Student student)
        {
            this.participants.Add(student);
        }
        
        public int getAmountOfParticipants()
        {
            return this.participants.Count;
        }
    }
}
