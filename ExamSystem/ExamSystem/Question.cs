using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{

    //different types of questions i do not know
    internal abstract class Question
    {

        protected Question()
        {

        }
        public override string ToString()
        {
            return $"will be overriden :D ";
        }

    }
}
