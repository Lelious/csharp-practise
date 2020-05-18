using System;
using System.Collections.Generic;
using System.Text;

namespace Lect_12
{
    public class UniqueItem
    {
        public int _id;
        public static int Id { get; set; }       
        public UniqueItem()
        {           
            _id = Id;
            Id += 1;
        }
    }
}
