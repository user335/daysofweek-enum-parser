using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumApp
{
    class Program
    {
        public enum daysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static public daysOfTheWeek usersFavDay;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to days of the week confirmer");
            Console.WriteLine("Please tell me what is your favorite day of the week");
            Console.WriteLine("Please take this seriously. It is very important");

            bool goodInput = false;
            while (!goodInput)
            {
                try
                {
                    string input = Console.ReadLine().ToLower();
                    input = input.First().ToString().ToUpper() + input.Substring(1);
                    if (Enum.IsDefined(typeof(daysOfTheWeek), input))
                    {
                        if (Enum.TryParse<daysOfTheWeek>(input, out usersFavDay))
                        {
                            Console.WriteLine("Got it, your favorite day is " + usersFavDay);
                            goodInput = true;
                        }
                        else
                        {
                            Console.WriteLine(input + " not found. Please enter an actual day of the week. Remember, this is important");
                        }
                    }
                    Console.WriteLine(input + " not found. Please enter an actual day of the week. Remember, this is important");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception message = " + ex.Message);
                    Console.WriteLine("Please enter an actual day of the week. Remember, this is important");
                }
            }
            Console.WriteLine("This was very important! Goodbye");
            Console.Read();
        }
    }
}
