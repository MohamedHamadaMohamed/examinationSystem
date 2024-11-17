using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class MultipleChoiseQuestion : Question
    {
        public int[]? Answers { set; get; }
        public string[]? Choices { set; get; }
        public MultipleChoiseQuestion(string? qlevel, QType? qHeader, string? qBody, int? qmarks, int[]? answers, string[]? choices) : base(qlevel, qHeader, qBody, qmarks)
        {
            Answers = answers;
            Choices = choices;
        }
        public string ToQuestion()
        {
            return $"{QHeader}\n{QLevel}\n{Qmarks}\n {QBody}\n1.{Choices[0]}\n2.{Choices[1]}\n3.{Choices[2]}";
        }
    }
}
