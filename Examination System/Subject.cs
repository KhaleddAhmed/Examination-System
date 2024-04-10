using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examination_System
{
     class Subject
    {
        public int SubjectId { get; set; }
        public string ?SubjectName { get; set; }

        public Exam Exam { get; set; }

        public Subject(int subjectId,string subName) 
        {
            SubjectId = subjectId;
            SubjectName = subName;
        }


        public void createExam()
        {
            Console.Write("Please Enter the type of Exam You want (1 for Final , 2 For Practical):");
            int choice = int.Parse(Console.ReadLine());
            ExamType examType;

           



            if (choice == 1)
            {
                Console.WriteLine("Then You Have 2 options of Question MCQ and T/f");
                examType = ExamType.Final;

                Console.Write("Enter the time of the exam in Minutes: ");
                int timeOfExam = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of questions: ");
                int numberOfQuestions = int.Parse(Console.ReadLine());
                Exam = new Final_Exam(timeOfExam, numberOfQuestions, this);

                Exam.QuestionList = new Question[numberOfQuestions];
                Console.Clear();



                //  Exam.QuestionList=new Question[numberOfQuestions];


                

                for (int i = 0; i < numberOfQuestions; i++)
                {

                    Console.Write($"Please Enter The Type Of Question.{i + 1}:(1 for MCQ and 2 For T/F) : ");
                    int answer = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (answer == 1)
                    {
                        Console.WriteLine("MCQ");
                        Console.Write("Enter The Body Of Question : ");
                        string body = Console.ReadLine();
                        Console.Write("Please Enter The Mark Of Question : ");
                        int marks = int.Parse(Console.ReadLine());
                        Console.WriteLine("The Choices of The Question:");
                        Answer[] answers = new Answer[3];
                        for (int j = 0; j < answers.Length; j++)
                        {
                            Console.Write($"Please Enter Choice.{j + 1}:");
                            string answerChoices = Console.ReadLine();

                            answers[j] = new Answer(j, answerChoices);


                        }
                        Console.Write("Please Specify The Right Choice :");
                        int RightChoice = int.Parse(Console.ReadLine());

                       // Answer rightAnswer = new Answer(RightChoice - 1, answers[RightChoice - 1].AnswerText);

                        MCQquestions mCQquestions=new MCQquestions("MCQ",body,marks,answers,RightChoice);
                        Exam.QuestionList[i] = mCQquestions;

            
                        Console.Clear();





                    }
                    if (answer == 2)
                    {
                        Console.WriteLine("True Or False");
                        Console.Write("Enter The Body Of Question : ");
                        string body = Console.ReadLine();
                        Console.Write("Please Enter The Mark Of Question : ");
                        int marks = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please Enter The Right Answer Of The Question : (1 for true and 2 for false)");
                        int rightAnswer = int.Parse(Console.ReadLine());

                        Answer[] answers = new Answer[2]
                        {
                            new Answer(i,"true"),
                            new Answer(i+1,"false"),
                        };
                       // Answer RightAnswer = new Answer(rightAnswer - 1, answers[rightAnswer - 1].AnswerText);
                        TrueOrFalseQuestions trueOrFalseQuestions = new TrueOrFalseQuestions("True|False", body, marks, answers,rightAnswer);
                        Exam.QuestionList[i] = trueOrFalseQuestions;
                        Console.Clear();
                    }

                }


            }

            else if (choice == 2)
            {
                Console.WriteLine("Then You Have One Option only MCQ");
                examType = ExamType.Practical;
                Console.Write("Enter the time of the exam in Minutes: ");
                int timeOfExam = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of questions: ");
                int numberOfQuestions = int.Parse(Console.ReadLine());
                Exam = new Practical_Exam(timeOfExam, numberOfQuestions, this);
                Exam.QuestionList = new Question[numberOfQuestions];
                Console.Clear();

            
                for (int i = 0; i < numberOfQuestions; i++)
                {

                    Console.Write($"Please Enter The Type Of Question.{i + 1}:(1 for MCQ and 2 For T/F) : ");
                    int answer = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (answer == 1)
                    {
                        Console.WriteLine("ChooseOne Answer Question");
                        Console.Write("Enter The Body Of Question : ");
                        string body = Console.ReadLine();
                        Console.Write("Please Enter The Mark Of Question : ");
                        int marks = int.Parse(Console.ReadLine());
                        Console.WriteLine("The Choices of The Question:");
                        Answer[] answers = new Answer[3];
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write($"Please Enter Choice.{j + 1}:");
                            string answerChoices = Console.ReadLine();

                            answers[j] = new Answer(j, answerChoices);


                        }
                        Console.Write("Please Specify The Right Choice :");
                        int RightChoice = int.Parse(Console.ReadLine());
                        Console.Clear();
                        //Answer rightAnswer = new Answer(RightChoice-1, answers[RightChoice - 1].AnswerText);
                        MCQquestions mCQquestions = new MCQquestions("MCQ", body, marks, answers,RightChoice);
                        Exam.QuestionList[i] = mCQquestions;


                      }



                    else
                    {
                        Console.WriteLine("Please Enter a valid Type Of Question You Are Allowed By MCQ Only");
                        i = -1;

                    }

                }
            }
        }

        public override string ToString()
        {
            return $"Subject Id = {SubjectId}, Subject Name = {SubjectName}";
        }


    }


    }

