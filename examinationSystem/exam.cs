using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public abstract class exam
    {
        public DateTime? DateTimeExam ;
        public int? NumOfQuestion;
        public int? Grade;
        public int? MarkOfExam;
        public exam(DateTime? dt,int? numOfQuestion)
        {
            Grade = 0;
            MarkOfExam = 0;
            DateTimeExam = dt;
            NumOfQuestion = numOfQuestion;
            
        }
        public abstract void showExam(QuestionList questionList);
    }
}
