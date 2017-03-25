using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private static string input = "nil";
        private static Int32 number;
        private static Int32 output;

        static void Main(string[] args)
        {
            while (true)
            {
                Input_Number();
                if (Int32.TryParse(input, out number))
                {
                    for (Int32 i = number; i > 0; i--)
                    {
                        output =sumupto(number);

                    }
                    Console.WriteLine("the result number is " + output);
                }
                else
                {
                    Console.WriteLine("you didn't give a valid number");
                }
                input = "nil";
                output = 0;
            }
        }
        static int sumupto(int number)
        {
            int result;
            if (number > 0)
            {
                
                result=sumupto(number-1)+number;
            }
            else result = 0;
            return result;
                }
        static void Input_Number()
        {
            Console.WriteLine("Please input your number, or'quit' to quit >");
            input = Console.ReadLine();
            if (input == "quit")
                Environment.Exit(0);
        }
    }
}
