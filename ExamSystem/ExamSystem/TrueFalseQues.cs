using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class TrueFalseQues : Question
    {
        //e.g: OOP , to define an abstract class we use keyword interface.  (2marks)
        //     true  - false 
        string header;
        string body;
        string correct_answer; //even if it is true or false its is treated as string
        int mark;
        AnswerList anList;
        public TrueFalseQues(string h, string b, string ca, int m, AnswerList anl)
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
        public AnswerList  AnsList
        {
            get { return anList; }
            set { anList = value; }
        }
        public override string ToString()
        {
            return $"(T/F){header}: {body}. ({mark}) ";
        }
        public override int GetHashCode()
        {
            //return ToString().GetHashCode(); not efficient as it may be change later and change the hasing logic 
            //it relys on the values it self 
            int hash1 = header.GetHashCode();
            int hash2 = body.GetHashCode();

            return hash1 ^ hash2;//the index of the bucket 
        }

        public override bool Equals(object? obj)
        {
            if (obj is TrueFalseQues other) //is checks null/not Question => returns false
            {
                //return true : other same as obj but casted 
                return this.header == other.header && this.body == other.body;

            }
            return false;
        }
    }
}
