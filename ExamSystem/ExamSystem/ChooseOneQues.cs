using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class ChooseOneQues : Question, IComparable<ChooseOneQues>
    {
        //e.g: OOP , which key word is used to stop overriden.  (2marks)
        //     virtual - new - override - callback 
        string header;
        string body;
        string correct_answer;
        int mark;
        AnswerList anList;
        public ChooseOneQues(string h, string b, string ca, int m, AnswerList anl)
        {
            header = h;
            body = b;
            correct_answer = ca;
            mark = m;
            anList = anl;
        }
        public string Correct_answer
        {
            get { return correct_answer; }
            set { correct_answer = value; }
        }
        public AnswerList AnsList
        {
            get { return anList; }
            set { anList = value; }
        }
        public int CompareTo(ChooseOneQues other)
        {
            //Console.WriteLine("i");
            if (other == null) return 1;
            return header.CompareTo(other.header) && body.CompareTo(other.body);

        }
        public override string ToString()
        {
            return $"(ChooseOne){header}: {body}. ({mark}) ";
        }
        public override int GetHashCode()
        {

            int hash1 = header.GetHashCode();
            int hash2 = body.GetHashCode();

            return hash1 ^ hash2;
        }

        public override bool Equals(object? obj)
        {
            if (obj is ChooseOneQues other)
            {
                return this.header == other.header && this.body == other.body;

            }
            return false;
        }
    }
}
