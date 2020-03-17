using System;

namespace Lect5.Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataValue = DateTime.Now;
            int hour = dataValue.Hour;

            if (hour >= 9 && hour <= 12)
            {
                Console.WriteLine("Good Morning!");
            }
            if (hour >= 12 && hour <= 15)
            {
                Console.WriteLine("Good Day!");
            }
            if (hour >= 15 && hour <= 21)
            {
                Console.WriteLine("Good Evening!");
            }
            else
            {
                Console.WriteLine("Something!");
            }


        }
    }
}
