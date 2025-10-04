namespace ExamSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a subject 
            Subject oop = new Subject("OOP");

            //answer list to be in each question
            AnswerList tfAnswers = new AnswerList();
            tfAnswers.Add(new Answer("true"));
            tfAnswers.Add(new Answer("false"));

            AnswerList chooseOneAnswers = new AnswerList();
            chooseOneAnswers.Add(new Answer("virtual"));
            chooseOneAnswers.Add(new Answer("new"));
            chooseOneAnswers.Add(new Answer("override"));
            chooseOneAnswers.Add(new Answer("callback"));

            AnswerList chooseAllAnswers = new AnswerList();
            chooseAllAnswers.Add(new Answer("polymorphism"));
            chooseAllAnswers.Add(new Answer("threading"));
            chooseAllAnswers.Add(new Answer("abstraction"));
            chooseAllAnswers.Add(new Answer("virtualization"));

            //create questions
            TrueFalseQues tfQ = new TrueFalseQues(
                "Q1",
                "OOP, to define an abstract class we use keyword interface.",
                "false",
                2,
                tfAnswers
            );

            ChooseOneQues chooseOneQ = new ChooseOneQues(
                "Q2",
                "OOP, which keyword is used to stop overriding?",
                "sealed",
                2,
                chooseOneAnswers
            );

            List<string> correctMultiple = new List<string> { "polymorphism", "abstraction" };
            ChooseAllQues chooseAllQ = new ChooseAllQues(
                "Q3",
                "OOP, what are principles of OOP?",
                correctMultiple,
                3,
                chooseAllAnswers
            );

            //create exam
            FinalExam finalExam = new FinalExam(2, 3, oop);

            //add questions
            finalExam.AddQuesToExam(tfQ, tfAnswers);
            finalExam.AddQuesToExam(chooseOneQ, chooseOneAnswers);
            finalExam.AddQuesToExam(chooseAllQ, chooseAllAnswers);

            //create student
            List<Subject> studentSubjects = new List<Subject> { oop };
            Student st1 = new Student(1, "Alyaa", studentSubjects, 1);

            //fire the delegate 
            //finalExam.Ex_mode = "starting";  
            //finalExam.Ex_mode = "finished";

            //run exam
            Console.WriteLine("=== Final Exam Started ===");
            finalExam.ShowExam();
            Console.WriteLine("=== Final Exam Finished ===");

            Console.ReadLine();
        }
    }
}
