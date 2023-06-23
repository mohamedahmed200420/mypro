using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome user
            Console.WriteLine("Welcome to calculator application");

            char cEbdProgram = 'a';
            while (cEbdProgram !='e')
            {
                // ask user to enter first number
                Console.WriteLine("please enter first number");
                double nFirstNumber = 0;
                // check if user enter valid number
                bool bIsValidNumber = double.TryParse(Console.ReadLine(), out nFirstNumber);
                if (!bIsValidNumber)
                {
                    Console.WriteLine("please enter a valid number");
                    return;
                }
                // ask user to enter second number
                Console.WriteLine("please enter second number");
                double nSecondNumber = 0;
                // check if user enter valid number
                bIsValidNumber = double.TryParse(Console.ReadLine(), out nSecondNumber);
                if (!bIsValidNumber)
                {
                    Console.WriteLine("please enter a valid number");
                    return;
                }
                // ask user to enter operator
                Console.WriteLine("please enter operator");
                char nOperator = '+';
                nOperator = Convert.ToChar(Console.ReadLine());
                //bIsValidNumber = int.TryParse(Console.ReadLine(), out nOperator);
                //if (!bIsValidNumber)
                //{
                //    Console.WriteLine("please enter a valid number");
                //    return;
                //}
                double nResult = 0;
                // check operator
                switch (nOperator)
                {
                    case '+':
                        nResult = nFirstNumber + nSecondNumber;
                        break;
                    case '-':
                        nResult = nFirstNumber - nSecondNumber;
                        break;
                    case '*':
                        nResult = nFirstNumber * nSecondNumber;
                        break;
                    case '/':
                        nResult = nFirstNumber / nSecondNumber;
                        break;
                }
                // perform operation
                Console.WriteLine("Result is " + nResult);

                Console.WriteLine("for exit press e else press any key");
                cEbdProgram = Convert.ToChar(Console.ReadLine());
            }
            // print result
        }
    }
}
