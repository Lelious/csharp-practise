using System;
using System.Collections.Generic;
using System.Text;

namespace Lect14.Task2
{
    public class Neighbor
    {
        public string FullName { get; set; }
        public int FullNumber { get; set; }
        public long PhoneNumber { get; set; }
        public Neighbor(string fullname, int fullnumber, long phonenumber)
        {
            FullName = fullname;
            FullNumber = fullnumber;
            PhoneNumber = phonenumber;
        }
    }
}
