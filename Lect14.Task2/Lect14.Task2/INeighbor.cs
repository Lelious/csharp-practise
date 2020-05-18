using System;
using System.Collections.Generic;
using System.Text;

namespace Lect14.Task2
{
    interface INeighbor
    {
        public void CreateNeighbor(string name, int fullname, long number);
        public void GetNeighbor(int number);
    }
}
