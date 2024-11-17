using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class ChoiseOneQuestion : Question
    {
        public int? Answer { set; get; }
        public string[] Choices { set; get; }

        public ChoiseOneQuestion(string? qlevel, QType? qHeader, string? qBody, int? qmarks, int? answer, string[] choices) :base( qlevel,  qHeader,  qBody,  qmarks)
        {
            this.Answer = Answer;
            this.Choices = choices;
        }

        public string ToQuestion()
        {
            return $"{QHeader}\n{QLevel}\n{Qmarks}\n {QBody}\n 1.{Choices[0]}\n2.{Choices[1]}\n3.{Choices[2]}";
        }
    }
}
