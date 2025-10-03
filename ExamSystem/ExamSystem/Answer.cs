using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class Answer : IComparable<Answer>,ICloneable<Answer>
    {
        public string val { get; set; }//true //false //abstraction 

        public int CompareTo(Answer other)
        {
            //Console.WriteLine("i");
            if (other == null) return 1;
            return val.CompareTo(other.val) ;

        }
        public Answer Clone()
        {
            return (Answer)this.MemberwiseClone()
        }
    }
}
