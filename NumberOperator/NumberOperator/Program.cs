using System;

namespace NumberOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our number operator app");

            Console.WriteLine("please enter a valid number");

            double nUserName = double.Parse(Console.ReadLine());
            bool IsCheck = true;
            if (nUserName > 0)
            {
                nUserName = nUserName + 1;

                Console.WriteLine("increase value with 1  " + nUserName);

                nUserName = nUserName - 3;

                Console.WriteLine("dcrease  value with 3  " + nUserName);

                nUserName *= nUserName;

                Console.WriteLine("dvide  value by itself  " + nUserName);

                nUserName = nUserName / 2;

                Console.WriteLine("multiple  value with 2  " + nUserName);
            }
            else
            {
                Console.WriteLine("number must be postive");
                return;
            }
            Console.ReadKey();
            
        }
    }
}
