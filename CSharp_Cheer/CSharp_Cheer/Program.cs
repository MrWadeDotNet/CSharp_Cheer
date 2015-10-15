using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World");

            // Step 1: Getting user's name and print it.
            System.Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Welcome, " + name);

            // Step 2: Cheer the user on.
            // If name is "Bob", output should be:
            // Give me a.. b
            // Give me an.. o
            // Give me a.. b
            // BOB is.. GRAND!

            string lower = name.ToLower();
            string vowels = "aeioumnxsfhlr";

            foreach (char letter in lower)
            {
                if (vowels.IndexOf(letter) != -1)
                {
                    Console.WriteLine("Give me an.. " + letter);
                }
                else
                {
                    Console.WriteLine("Give me a.. " + letter);
                }
            }
            string upper = name.ToUpper();
            Console.WriteLine(upper + " is... your name!");

            // Asks user for birthdate
            System.Console.WriteLine("When is your birthday? Use MM/DD");
            string birthdate = System.Console.ReadLine();
            DateTime today = DateTime.Now;
            string year = today.Year.ToString();
            var bd = DateTime.Parse(birthdate + "/" + year);
            TimeSpan timeDiff = bd - today;
            var daysTil = Convert.ToInt32(timeDiff.TotalDays);
            System.Console.WriteLine(daysTil);
            if (daysTil == 0)
            {
                System.Console.WriteLine("Happy Birthday!");
            }
            if (daysTil < 0)
            {
                daysTil = 365 - daysTil;
            }
            if (daysTil > 300)
            {
                System.Console.WriteLine("Sorry we missed it :/");
            }
            else
            {
                System.Console.WriteLine("Your birthday is in {0} days!!", daysTil);
            }
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}