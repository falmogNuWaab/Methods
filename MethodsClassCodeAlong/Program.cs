using System;

namespace MethodsClassCodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are testing some methods today!");

            string uName = GetInput("What is your name?");
            Console.WriteLine(uName);

        }
        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();

            return output;

        }

        public static bool Continue()
        {
            string answer = GetInput("Would you like to continue? (Y/N)? ");
            answer = answer.ToLower();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand");
                Console.WriteLine("Let's try again.");

                return Continue();
            }
        }

        public static double GetArea(double width, double length)
        {
            double area = width * length;
            return area;
        }

        public static bool RangeCheck(int min, int max, int num)
        {
            if(num > min && num < max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
