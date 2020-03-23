using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte charACount;
            Console.WriteLine("Enter a message:");
            string str = Console.ReadLine();
            foreach (char chValue in str)
            {
                if (chValue == 'a')
                {
                    charACount++;
                }      
            }
           
            Console.WriteLine($"Count of char A = " + charACount);
        }
    }
}
