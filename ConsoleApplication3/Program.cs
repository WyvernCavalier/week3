using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        //private static double[] listed = new double[50];
        private static List<double> stored = new List<double>();
        private static double number;
        private static string input = "nil";
        private static double output;

        static void Main(string[] args)
        {
            while (true)
            {
                Input_Number();
                if (double.TryParse(input, out number))
                {
                    stored.Add(number);
                    output = StdDev(stored);
                    if (stored.Count() > 1)
                        Console.WriteLine("curent SV is " + output);
                }
                else
                {
                    Console.WriteLine("invalid input, no number is added into the list");
                    if(stored.Count()>1)
                    Console.WriteLine("curent SV is " + output);
                    if(stored.Count()>0)
                    Console.WriteLine("as recorded, the numbers recorded in the list are:");
                    for (int i = 0; i < stored.Count(); i++)
                    { Console.WriteLine("[\t"+i + "\t] \t" + stored[i]); }
                }



            }
            input = "nil";
            
        }
        private static double StdDev(IEnumerable<double> values)
        {
            double ret = 0;
            if (values.Count() > 0)
            {
                //Compute the Average      
                double avg = values.Average();
                //Perform the Sum of (value-avg)_2_2      
                double sum = values.Sum(d => Math.Pow(d - avg, 2));
                //Put it all together      
                ret = Math.Sqrt((sum) / (values.Count() - 1));
                //ref:http://stackoverflow.com/questions/3141692/standard-deviation-of-generic-list
            }
            return ret;
        }

        static void Input_Number()
        {
            Console.WriteLine("Please input your number, or'quit' to quit as 'clear' to clear the float sequence, and put something else or just hit enter to check currently stored data >");
            input = Console.ReadLine();
            if (input == "clear")
                stored.Clear();
            if (input == "quit")
                Environment.Exit(0);
        }
    }
}
