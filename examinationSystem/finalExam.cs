using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class FinalExam : exam
    {
        public FinalExam(DateTime? dt, int? numOfQuestion) :base(dt,numOfQuestion)
        {

        }
        public override void showExam(QuestionList questionList)
        {
            Grade = questionList.totalMark;
            Console.WriteLine("\n--------------------------------------\n");
            Console.WriteLine($"the exam constists of {NumOfQuestion} questions");
            Console.WriteLine($"the total mark of the exam {Grade}");
            Console.WriteLine($"the is starting now {DateTimeExam}");
            

            int count = 1;
            foreach(var current in questionList.trueOrFalseQuestions)
            {
                QAnswer ans = new QAnswer();
                Console.WriteLine($"question {count++}");
                Console.WriteLine(current.ToQuestion());
                if(Console.ReadLine()=="True")
                {
                    ans = QAnswer.True;
                }
                else
                {
                    ans = QAnswer.False;
                }

                if(ans == current.qAnswer)
                {
                    MarkOfExam += current.Qmarks;
                }
            }

            foreach (var current in questionList.choiseOneQuestions)
            {
                
                Console.WriteLine($"question {count++}");
                Console.WriteLine(current.ToQuestion());
                int ans = int.Parse(Console.ReadLine());

                if (ans == current.Answer)
                {
                    MarkOfExam += current.Qmarks;
                }
            }
            foreach (var current in questionList.multipleChoiseQuestions)
            {

                Console.WriteLine($"question {count++}");
                Console.WriteLine(current.ToQuestion());
                string[] Sans = Console.ReadLine().Split();
                List<int> ans = new List<int>();
                for (int i =0;i<Sans.Length;i++)
                {
                    ans.Add(int.Parse(Sans[i]));
                }
                bool correct = false;
                if(ans.Count == current.Answers.Length)
                {
                    for(int i=0;i<ans.Count;i++)
                    {
                        if (ans[i] != current.Answers[i])
                        {
                            correct = true;
                        }
                    }
                    if( correct == false)
                    {
                        MarkOfExam += current.Qmarks;
                    }
                }
                
            }
            Console.WriteLine("the exam finished ...");
            Console.WriteLine($"you took {DateTime.Now - DateTimeExam}");
            Console.WriteLine($"your mark is {MarkOfExam} of {Grade} ....");

        }
    }
}
