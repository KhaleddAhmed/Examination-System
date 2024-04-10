using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class MCQquestions:Question
    {
        public MCQquestions(string header,string body,int mark, Answer[]list ,int rightAnswer):base(header,body,mark,list,rightAnswer)
        {

        }


        public override void DisplayQuestion()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Choose The Correct Answer: {Header}");
            Console.WriteLine($"Q: {Body}");
            Console.WriteLine($"Mark: {Mark}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("choices:");
            
            for (int i=0;i<AnswerLists.Length;i++)
            {
                Console.WriteLine($"{i+1}.{AnswerLists[i].AnswerText}");
            }
            Console.WriteLine("---------------------------------");        }






    }
}
