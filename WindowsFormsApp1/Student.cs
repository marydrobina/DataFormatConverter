using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student
    {
        public String name { get; set; }
        public int score { get; set; }

        public Student() { }
        public Student(String name, int score)
        {
            this.name = name;
            this.score = score;
        }



    }
}
