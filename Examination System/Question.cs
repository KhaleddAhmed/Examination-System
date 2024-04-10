using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
     abstract class Question
    {
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }

        public Answer[] AnswerLists { get; set; }

        public int RightAnswer { get; set; }
   protected Question(string header,string body,int mark,Answer[] list,int rightAnswer) 
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerLists = list;
            RightAnswer = rightAnswer;

        }

        public abstract void DisplayQuestion();
       



    }
}
