using System;

namespace Practice_07
{
    class Program
    {
        static void Main(string[] args)
        {           
            Task_01(); // Array creation must have array size.
            Task_02();
            Task_03();
        }

        static void Task_01()
        {
            int[] array1 = new int[5];
        }
        static void Task_02()
        {
            object[] array2 = new object[3] {32, 'A', "Hello"};

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(array2[i]);
            }

            int intBuffer = Convert.ToInt32(array2[0]);
            intBuffer += 10;
            array2[0] = intBuffer;
            string stringBuffer = Convert.ToString(array2[2]);
            stringBuffer += " guys!";
            array2[2] = stringBuffer;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }
        static void Task_03()
        {
            Random rnd = new Random();
            int array3Buffer = 0;

            int[] array3 = new int[13];

            for (int i = 0; i < array3.Length - 1; i++)
            {
                array3[i] = rnd.Next(0, 50);
            }

            for (int i = 0; i < array3.Length - 1; i++)
            {
                if (array3[i] > array3Buffer)
                {
                    array3Buffer = array3[i];
                }
            }

            for (int i = 0; i < array3.Length - 1; i++)
            {
                Console.WriteLine(array3[i]);
            }
            Console.WriteLine($"Max array value is: {array3Buffer}");
        }
    }
}
