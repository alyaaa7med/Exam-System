using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Subject :IComparable<Subject> , ICloneable<Subject>
    {
        string nm;
        //List<Student> students;
        public Subject(string n)//, List<Student> std
        {
            nm = n;
            //students = std;
        }

        public string NM { get; set; }

        public int CompareTo(Subject other)
        {
            //Console.WriteLine("i");
            if (other == null) return 1;
            return NM.CompareTo(Subject.NM) ;

        }
        public Subject Clone()
        {
            return (Subject)this.MemberwiseClone();
        }

    }
}
