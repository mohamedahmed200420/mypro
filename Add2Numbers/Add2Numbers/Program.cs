using System;

namespace Add2Numbers
{
    class Program
    {
        int UserId = 1;
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            //string UserName = "";
            //Console.WriteLine(UserName);
            //UserName = "ali";
            //Console.WriteLine(UserName);
            //UserName = "ahmed";
            //Console.WriteLine(UserName);

            //// numbers
            //short number1 = 256;
            //int number2 = 0;
            //double number3 = 0;
            //decimal number4 = 0;
            //int UserIdForApplication = 0;

            //// string
            //string name2 = "";
            //// characters
            //char myChar = 'a';

            //// logic
            //bool isChecked = true;

            //var x = 'f';
            //object y = 5;
            //y = "";
            //number2 = Convert.ToInt32(number4);
            ////number2 = int.Parse(name2);
            ////number2 = (int)number3;
            //UserName = number2.ToString();

            try
            {
                // welcome user to my application
                Console.WriteLine("welcome to add numbers application");
                // ask user to enter the first number
                Console.WriteLine("please enter first number");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                // ask user to enter the second number
                Console.WriteLine("please enter second number");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                // add 2 numbers
                int result = firstNumber + secondNumber;
                // display output
                Console.WriteLine("the result is :" + result);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void Execute()
        {
            char myChar = 'a';
        }
    }
}
