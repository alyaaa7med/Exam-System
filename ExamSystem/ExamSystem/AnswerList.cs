using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class AnswerList : List<Answer>
    {

        public void Add(Answer ans)
        {
            base.Add(ans);
        }

    }
}
