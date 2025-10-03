using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class FinalExam : Exam , IComparable<FinalExam>,ICloneable<FinalExam>
    {
        DateTime examStart, examEnd;
        int durationMinutes = 150;
        public event EventHandler<ExamEventArgs>? ExamState;

        string ex_mode;

        public string Ex_mode
        {
            get
            {
                return ex_mode;
            }
            set
            {
                ex_mode = value; //Starting  , Finished
                CheckTime();
                ExamState?.Invoke(this, new ExamEventArgs(ex_mode, sb));

            }

        }

        public FinalExam(int t, int qc, Subject sb ) : base(t, qc, sb)
        {
            ex_mode = "started";
            examStart = DateTime.Now;

            ExamState?.Invoke(this, new ExamEventArgs(ex_mode, sb));


        }
        public int CompareTo(PracitceExam other)
        {
            //Console.WriteLine("i");
            if (other == null) return 1;
            return examStart.CompareTo(other.examStart);

        }
        public FinalExam Clone()
        {
            return (FinalExam)this.MemberwiseClone();
        }

        public void AddQuesToExam(Question q, AnswerList al)
        {
            //default Add() 
            //will be unique at the reference value level no matter what inside the question object 

            //my customize Add() function
            //will be unique for the question data , so override both equals , gethashcode 

            ques_exam.Add(q, al);


        }

        private void CheckTime()
        {
            examEnd = DateTime.Now;
            TimeSpan elapsed = examEnd - examStart;

            if (elapsed.TotalMinutes >= durationMinutes)
            {
                ex_mode = "finished";
            }
        }


        public override void ShowExam()
        {
            //show questions 
            foreach (var pair in ques_exam)
            {
                Question q = pair.Key;

                if (q is TrueFalseQues tf)
                {
                    Console.WriteLine(tf.ToString());
                    foreach (Answer ans in tf.AnsList)
                    {
                        Console.Write(ans.val + " ");
                    }
                    Console.WriteLine("enter answer");
                    string val = Console.ReadLine();
                }
                if (q is ChooseOneQues cone)
                {
                    Console.WriteLine(cone.ToString());
                    foreach (Answer ans in cone.AnsList)
                    {
                        Console.Write(ans.val + " ");
                    }
                    Console.WriteLine("enter answer");
                    string val = Console.ReadLine();
                }

                if (q is ChooseAllQues call)
                {
                    Console.WriteLine(call.ToString());
                    foreach (Answer ans in call.AnsList)
                    {
                        Console.Write(ans.val + " ");
                    }
                    Console.WriteLine("enter mutiple answers , number of them , answers");
                    int size = int.Parse(Console.ReadLine());
                    AnswerList answers = new AnswerList();
                    string s;
                    for (int i = 0; i < size; i++)
                    {
                        s = Console.ReadLine();
                        answers.Add(s);
                    }
                }


            }


        }
    }
}
