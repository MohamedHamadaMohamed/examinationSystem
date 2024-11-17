using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class QuestionList
    {
        public List<TrueOrFalseQuestion> trueOrFalseQuestions;
        public List<ChoiseOneQuestion> choiseOneQuestions;
        public List<MultipleChoiseQuestion> multipleChoiseQuestions;
        public int? numOfQuestion { get; set; }
        public int? totalMark { get; }
        public QuestionList() 
        {
            trueOrFalseQuestions = new List<TrueOrFalseQuestion>();
            choiseOneQuestions = new List<ChoiseOneQuestion>();
            multipleChoiseQuestions = new List<MultipleChoiseQuestion>();
            int numofquestion = 0;
            totalMark = 0;
            do
            {
                Console.Write("How many questions you want ?");

            } while (!int.TryParse(Console.ReadLine(), out numofquestion));
            this.numOfQuestion = numofquestion;
            for (int i = 0; i < numOfQuestion; i++)
            {
                Console.WriteLine($"Question {i + 1}");

                Console.WriteLine("type of question you want ?");
                Console.WriteLine("1. true or false question");
                Console.WriteLine("2. choise one question");
                Console.WriteLine("3. multipleChoise question");
                Console.WriteLine("choise 1 or 2 or 3");

                int? type = int.Parse(Console.ReadLine());

                Console.WriteLine("enter the question level (easy - meduim - hard): ");
                string? level = Console.ReadLine();

                Console.WriteLine("enter the question : ");
                string? body = Console.ReadLine();
                Console.WriteLine("enter the question mark : ");
                int? mark = int.Parse(Console.ReadLine());
                this.totalMark += mark;

                if (type == 1)
                {
                    
                    Console.WriteLine("enter the question answer (True / False): ");
                    QAnswer ans = new QAnswer();
                    if (Console.ReadLine() == "True")
                    {
                        ans = QAnswer.True;
                    }
                    else
                    {
                        ans = QAnswer.False;
                    }

                    TrueOrFalseQuestion ques = new TrueOrFalseQuestion(level, QType.TrueOrFalse, body, mark, ans);
                    trueOrFalseQuestions.Add(ques);


                }
                else if (type == 2)
                {
                    

                    string[] answers = new string[3];
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"enter the choise {j + 1} : ");
                        answers[j] = Console.ReadLine();
                    }
                    Console.WriteLine("enter the question answer (1 or 2 or 3): ");
                    int correctAnswer = int.Parse(Console.ReadLine());

                    ChoiseOneQuestion ques = new ChoiseOneQuestion(level, QType.ChoiseOne, body, mark, correctAnswer, answers);
                    choiseOneQuestions.Add(ques); 
                }
                else
                {
                   
                    string[] answers = new string[3];
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"enter the choise {j + 1} : ");
                        answers[j] = Console.ReadLine();
                    }
                    Console.WriteLine("enter the question answers (all answers in one line): ");
                    string[] Scorrect = Console.ReadLine().Split(' ');
                    int[] answer = new int[Scorrect.Length];
                    for (int j = 0; j < Scorrect.Length; j++)
                    {
                        answer[j] = int.Parse(Scorrect[j]);
                    }
                    MultipleChoiseQuestion ques = new MultipleChoiseQuestion(level, QType.MulipleChoise, body, mark, answer, answers);
                    multipleChoiseQuestions.Add(ques);
                }
            }
        }


    }
}
