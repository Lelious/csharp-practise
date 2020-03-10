using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            short valShort = 5;
            object obj = valShort;
            System.SByte valSbyte = (sbyte)(short)obj;
            Console.WriteLine(valSbyte);
            Console.WriteLine(valSbyte.GetType());
            Console.ReadKey();
        }
    }
}
