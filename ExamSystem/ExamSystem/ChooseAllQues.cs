using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class ChooseAllQues : Question, IComparable<ChooseAllQues>,ICloneable<ChooseAllQues>
    {
        //e.g: OOP , what are principles of OOP  (2marks)
        //     polymorphism - threading - abstraction -  virtualization  

        string header;
        string body;
        List<string> correct_answers;
        int mark;
        AnswerList anList;

        public ChooseAllQues(string h, string b, List<string> cas, int m, AnswerList anl)
        {
            header = h;
            body = b;
            correct_answers = cas;
            mark = m;
            anList = anl;
        }
        public List<string> Correct_answer
        {
            get { return correct_answer; }
            set { correct_answer = value; }
        }

        public AnswerList AnsList
        {
            get { return anList; }
            set { anList = value; }
        }
        public int CompareTo(ChooseAllQues other)
        {
            //Console.WriteLine("i");
            if (other == null) return 1;
            return header.CompareTo(other.header) && body.CompareTo(other.body);

        }
        public ChooseAllQues Clone()
        {
            return (ChooseAllQues)this.MemberwiseClone();
        }
        public override string ToString()
        {
            return $"(ChooseAll){header}: {body}. ({mark})";
        }

        public override int GetHashCode()
        {

            int hash1 = header.GetHashCode();
            int hash2 = body.GetHashCode();

            return hash1 ^ hash2;
        }

        public override bool Equals(object? obj)
        {
            if (obj is ChooseAllQues other)
            {
                return this.header == other.header && this.body == other.body;

            }
            return false;
        }
    }
}
