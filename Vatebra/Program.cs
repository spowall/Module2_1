using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatebra
{
    class Program
    {
        public static void Main()
        {
            /*
            * What is your First Name
            * How old are you
            * What is your Surname
            */
            string question1 = "What is your First Name";
            var answer1 = AskQuestion(question1);


            string question2 = "How old are you";
            string answer2 = AskQuestion(question2);

            int age = int.Parse(answer2);


            string question3 = "What is your Surname";

            string answer3 = AskQuestion(question3);

            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("                              Result                          ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Your first Name is: " + answer1);
            Console.WriteLine("You are " + answer2 + " years old");

            if (age > 50)
            {
                Console.WriteLine("You are Old");
            }
            else if (age < 50)
            {
                Console.WriteLine("You are ");
            }
            else
            {
                Console.WriteLine("You are a Child");
            }
            Console.WriteLine("Your surname is " + answer3);
        }

        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            return answer;
        }
    }
}
