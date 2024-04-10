using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Practical_Exam : Exam
    {
        public MCQquestions MCQquestions { get; set; }

        public Practical_Exam(int time, int number, Subject subject) : base(time, number, subject)
        {

        }

        public override void ShowExam()
        {
            Console.WriteLine($"Practical Exam:\nTime: {TimeOfExam} min\nQuestions: {NumberOfQuestions} Questions");

            int totalMarks = 0;
           

            for (int i = 0; i < QuestionList.Length; i++)
            {
                QuestionList[i].DisplayQuestion();

              
                Console.Write("Enter Answer Please: ");
                int userAnswerText = int.Parse(Console.ReadLine());
                Console.Clear();

             
                if (QuestionList[i] is MCQquestions)
                {
                    MCQquestions mcqQuestion = (MCQquestions)QuestionList[i];

                    
                    if (userAnswerText == mcqQuestion.RightAnswer)
                    {
                        //Console.WriteLine("Correct!");
                        totalMarks += mcqQuestion.Mark;
                       // Console.WriteLine("-------------------------------");
                    }
                    else
                    {
                        //Console.WriteLine($"Incorrect! Correct Answer: {mcqQuestion.RightAnswer}");
                        //Console.WriteLine("-------------------------------");
                    }
                }
            }
            for (int i = 0; i < QuestionList.Length; i++)
            {
                Console.WriteLine($"Q.{i + 1}:{QuestionList[i].Header}-{QuestionList[i].Body}");
                Console.WriteLine($"The Correct answer :{QuestionList[i].AnswerLists[QuestionList[i].RightAnswer - 1].AnswerText} ");
                Console.WriteLine($"Marks:{QuestionList[i].Mark}");
                Console.WriteLine();
            }

            Console.WriteLine($"Total Grade: {totalMarks}");

        }
    }
}
