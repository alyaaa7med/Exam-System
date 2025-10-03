using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class Student: IComparable <Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Subject> subjList { get; set; }

        public Student(int i, string n, List<Subject> l , int num)
        {
            Id = i;
            Name = n;
            subjList = l;
            if (num == 1)
            {
                FinalExam fexam = new FinalExam();
                fexam.ExamState += OnExamStateChanged;

            }
            else if (num == 2)
            {
                PracitceExam pexam = new FinalExam();
                pexam.ExamState += OnExamStateChanged;
            }

        }
        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return Id.CompareTo(other.Id) && Name.CompareTo(other.Name);

        }
        private void OnExamStateChanged(object? sender, ExamEventArgs e)
        {
            Console.WriteLine($"Student {Name}  notified: {e}");
        }

    }
}
