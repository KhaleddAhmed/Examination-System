using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Final_Exam : Exam
    {
        public MCQquestions MCQquestions { get; set; }

        public TrueOrFalseQuestions TrueOrFalseQuestions { get; set; }

        


        public Final_Exam(int time,int number,Subject subject):base(time,number,subject)
        {
           
        }
        public override void ShowExam()
        {
           
            int totalMarks = 0;
            Console.WriteLine($"Final Exam:\nTime Of Exam:{TimeOfExam} Min\nQuestions : {NumberOfQuestions} Questions");
            Console.WriteLine("-------------------------------");
            for (int i=0;i<QuestionList.Length;i++)
            {
                QuestionList[i].DisplayQuestion();
                Console.Write("Enter The Answer Pease: ");
                int  YourAnswer = int.Parse(Console.ReadLine());
                Console.Clear();


                if (QuestionList[i] is MCQquestions)
                {
                    MCQquestions mCQquestions = (MCQquestions)QuestionList[i];
                   
                    if (YourAnswer==mCQquestions.RightAnswer)
                    {
                        totalMarks += mCQquestions.Mark;
                 
                    }
                    


                    


                }
          else if (QuestionList[i] is TrueOrFalseQuestions)
                {
                    TrueOrFalseQuestions trueFalseQuestion = (TrueOrFalseQuestions)QuestionList[i];
                    if (YourAnswer == trueFalseQuestion.RightAnswer)
                    {
                        
                        totalMarks += trueFalseQuestion.Mark;

                        
                    }
                    else
                    {
                       
                    }
                }

               
              
            }

            for(int i=0; i<QuestionList.Length;i++)
            {
                Console.WriteLine($"Q.{i + 1}:{QuestionList[i].Header}-{QuestionList[i].Body}");
                Console.WriteLine($"The Correct answer :{QuestionList[i].AnswerLists[QuestionList[i].RightAnswer-1].AnswerText} ");
                Console.WriteLine($"Marks:{QuestionList[i].Mark}");
                Console.WriteLine();
            }

         

            Console.WriteLine($"Total Grade: {totalMarks}");

        }
        }
        
    }

