using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class TrueOrFalseQuestion : Question
    {
        public QAnswer qAnswer;

        public TrueOrFalseQuestion(string? qlevel, QType? qHeader, string? qBody, int? qmarks, QAnswer qanswer) : base(qlevel, qHeader, qBody, qmarks)
        {
            this.qAnswer = qanswer;
        }
        public override string ToString()
        {
            return $"{QBody}";
        }
        public string ToQuestion()
        {
            return $"{QHeader}\n{QLevel}\n{Qmarks}\n {QBody}";
        }
    }
}
