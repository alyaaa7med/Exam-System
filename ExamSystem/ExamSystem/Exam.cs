using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal abstract class Exam
    {
        //int time_in_hours;
        //int quest_count;
        Subject subj;
       
        protected Dictionary<Question, AnswerList> ques_exam;

        protected Exam(int t, int qc, Subject sb)
        {
            time_in_hours = t;
            quest_count = qc;
            subj = sb;
            ques_exam = new Dictionary<Question, AnswerList>();//to add only unique questions
                                                               //along the exam 
                                                               //AnswerList here :does not matter

            //i must override Equals and GetHashCode inside the key’s class,
        }
        public abstract void ShowExam();


    }
}
