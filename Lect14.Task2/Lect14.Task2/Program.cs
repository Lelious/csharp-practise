using System.Collections.Generic;

namespace Lect14.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            NeighborsRepository repo = new NeighborsRepository();

            repo.CreateNeighbor("Peter", 1, 3752545612358);
            repo.CreateNeighbor("Mary", 2, 375257469536);
            repo.CreateNeighbor("John", 3, 375259741235);

            repo.GetNeighbor(2);
        }
    }
}
