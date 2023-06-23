using System;

namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome user
            Console.WriteLine("Welcome to student grade application");

            // ask user to write grade
            Console.WriteLine("please enter user grade");
            double nUserGrade = 0;
            // check if user enter a valid number
            bool bIsNumber = double.TryParse(Console.ReadLine(), out nUserGrade);
            if (!bIsNumber)
            {
                Console.WriteLine("please enter a valid number");
                return;
            }

            //if((nUserGrade > 50 && bIsNumber || true) || (false && true))
            //{

            //}
            // check if number not less than zro or grdeter than 100
            if(nUserGrade < 0 || nUserGrade > 100)
            {
                Console.WriteLine("number must be between 0 and 100");
                return;
            }
            // check if grade is faill
            if(nUserGrade<50)
            {
                Console.WriteLine("Failed");
            }
            // check if grade is fair
            else if(nUserGrade>=50 && nUserGrade<65)
            {
                Console.WriteLine("Fair");
            }
            // check if grade is good
            else if (nUserGrade >= 65 && nUserGrade < 75)
            {
                Console.WriteLine("good");
            }
            // check if grade is very good
            else if (nUserGrade >= 75 && nUserGrade < 85)
            {
                Console.WriteLine("very good");
            }
            // check if grade is excellent
            else
            {
                Console.WriteLine("excellent");
            }
            Console.ReadKey();
        }
    }
}
