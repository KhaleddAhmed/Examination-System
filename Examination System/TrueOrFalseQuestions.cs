using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class TrueOrFalseQuestions : Question
    {

        public TrueOrFalseQuestions(string header, string body, int mark, Answer[] list,int rightAnswer) : base(header, body, mark, list, rightAnswer)
        {

        }
       public override void DisplayQuestion()
        {

        
        
            Console.WriteLine($"True/False Question: {Header}");
            Console.WriteLine($"Question: {Body}");
            Console.WriteLine($"Mark: {Mark}");
            Console.WriteLine($"Options: {1}.True-{2}.False");
            Console.WriteLine("---------------------------------");
        }
    }

        

    }

