using System.Diagnostics;

namespace Examination_System
{
     class Program
    {
        static void Main()
        {
            Subject s01 = new Subject(10, "c#");
            s01.createExam();
            Console.Clear();
            Console.WriteLine("Do You Want TO start The Exam :Y|N");

            if(char.Parse(Console.ReadLine())=='Y')
            {
                Stopwatch sw=new Stopwatch();
                sw.Start();
                s01.Exam.ShowExam();
                Console.WriteLine($"The Time Taken of Exam = {sw.Elapsed}");


            }
        }
    }
}
