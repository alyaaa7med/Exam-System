using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class QuestionList : List<Question>, IDisposable
    {
        StreamWriter st;
        public QuestionList(string file_name)
        {
            st = new StreamWriter(@"D:\ITI 3 months\c#_advanced\Examination System\" + file_name + ".txt", true);
        }
        public void Add(Question q)  //i only add the question not its answer 
        {
            base.Add(q);
            st.WriteLine(q.ToString());
        }

        bool is_destructor_called = false;
        public void Dispose()
        {
            st.Dispose();
            if (is_destructor_called == false)
            {
                GC.SuppressFinalize(this);
            }
        }//should be called in the main 
        ~QuestionList()
        {
            is_destructor_called = true;
            Dispose();
        }
    }
}
