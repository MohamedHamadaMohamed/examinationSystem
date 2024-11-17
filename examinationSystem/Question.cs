using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class Question
    {
        public  string? QLevel { set; get; }
        public QType? QHeader { set; get; }
        public string? QBody { set; get; }
        public int? Qmarks { set; get; }

        public Question(string? qlevel, QType? qHeader, string? qBody, int? qmarks)
        {
            QLevel = qlevel;
            QHeader = qHeader;
            QBody = qBody;
            Qmarks = qmarks;
        }

        public Question()
        {
        }
    }
}
