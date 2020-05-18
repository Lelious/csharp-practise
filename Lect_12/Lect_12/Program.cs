using System;

namespace Lect_12
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueItem item1 = new UniqueItem();

            Console.WriteLine(item1._id);

            UniqueItem item2 = new UniqueItem();

            Console.WriteLine(item2._id);

            UniqueItem.Id = 50;

            UniqueItem item3 = new UniqueItem();

            Console.WriteLine(item3._id);

            UniqueItem item4 = new UniqueItem();

            Console.WriteLine(item4._id);

        }
    }
}
