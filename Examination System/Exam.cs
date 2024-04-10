using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    enum ExamType
    {
        Final,Practical
    }
    abstract class Exam
    {
        public int TimeOfExam { get; set; }

        public int NumberOfQuestions { get; set; }

        public Subject Subject { get; set; }

        public ExamType Type { get; set; }

        public Question[] QuestionList;

        

        protected Exam(int time,int numberofquestions,Subject subject) 
        {
            TimeOfExam = time;
            NumberOfQuestions = numberofquestions;
            Subject = subject;
            
        }



        public abstract void ShowExam();
        


        
    }
}
