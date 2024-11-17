namespace examinationSystem
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            QuestionList l = new QuestionList();
            FinalExam f = new FinalExam(DateTime.Now, l.numOfQuestion);
            f.showExam(l);




        }
    }
}
