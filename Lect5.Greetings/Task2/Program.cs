using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a message:");
            string str = Console.ReadLine();
            int valueLength = str.Length;
            Console.WriteLine($"Count of numbers =" + valueLength);
        }
    }
}
