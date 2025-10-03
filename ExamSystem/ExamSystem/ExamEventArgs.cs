namespace ExamSystem
{
    public class ExamEventArgs : EventArgs
    {
        string mode;
        Subject subj;

        public ExamEventArgs(string m, Subject s)
        {
            mode = m;
            subj = s;
        }

        public override string ToString()
        {
            return $"exam for subject {subj.NM} is {mode}.";
        }
    }
}