using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Subject
    {
        string nm;
        //List<Student> students;
        public Subject(string n)//, List<Student> std
        {
            nm = n;
            //students = std;
        }

        public string NM { get; set; }

    }
}
