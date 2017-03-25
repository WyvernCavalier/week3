using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        private static DateTime DoB;
        private static Int32 SID;
        private static Int32 Y, M, D;
        private static string input="nil";
        static string value_names; 
        static void Main(string[] args)
        {
            while (true)
            {
                value_names = "student ID";
                Input();
                while (!Int32.TryParse(input, out SID) || (input.Length > 9 || input.Length < 8))
                {
                    Console.WriteLine("invalid input for " + value_names);
                    Input();
                }
                input = "nil";

                value_names = "Year";
                Input();
                while (!Int32.TryParse(input, out Y) || (Y > DateTime.Now.Year - 17 || Y < DateTime.Now.Year - 100))
                {
                    Console.WriteLine("invalid input for " + value_names);
                    Input();
                }
                input = "nil";

                value_names = "Month";
                Input();
                while (!Int32.TryParse(input, out M) || (M > 12 || Y < 1))
                {
                    Console.WriteLine("invalid input for " + value_names);
                    Input();
                }
                input = "nil";

                value_names = "Day";
                Input();
                while (!Int32.TryParse(input, out D) || (D > DateTime.DaysInMonth(Y, M) || D < 1))
                {
                    Console.WriteLine("invalid input for " + value_names);
                    Input();
                }
                input = "nil";

                Console.WriteLine("\t Student ID:\t"+SID);
                Console.WriteLine("\t DoB:\t" +D+"/"+M+"/"+Y);
            }
        }


        static void Input()
        {
            Console.WriteLine("Please input  "+value_names +", or'quit' to quit >");
            input = Console.ReadLine();
            if (input == "quit")
                Environment.Exit(0);
        }
       

    }


}
