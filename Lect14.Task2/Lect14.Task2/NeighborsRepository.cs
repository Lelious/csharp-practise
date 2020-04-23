using System;
using System.Collections.Generic;
using System.Text;

namespace Lect14.Task2
{
    class NeighborsRepository : INeighbor
    {
        List<Neighbor> floorneighbors = new List<Neighbor>();
        public void CreateNeighbor(string name, int fullname, long number)
        {
            Neighbor item = new Neighbor(name, fullname, number);

            floorneighbors.Add(item);
        }

        public void GetNeighbor(int number)
        {
            Neighbor item = floorneighbors.Find(item => item.FullNumber.Equals(number));

            if (item == null)
            {
                Console.WriteLine("Cant find neighbor!");
            }

            else
            {
                Console.Write(item.FullName + " ");
                Console.Write(item.FullNumber + " ");
                Console.Write(item.PhoneNumber + " ");
            }
        }
    }
}
