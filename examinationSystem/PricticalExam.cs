using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class PricticalExam : exam
    {
        PricticalExam(DateTime dt, int numOfQuestion) :base(dt, numOfQuestion)
        {

        }
        public override void showExam(QuestionList questionList)
        {
        }
    }
}
