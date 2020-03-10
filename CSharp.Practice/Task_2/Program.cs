using System;
using System.Collections;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {           
            ArrayList arraylist = new ArrayList();

            //Принимает параметр типа "System.Object" с проверкой на null, если не null то принимает значение.

            arraylist.Add(45);          //true, boxing
            arraylist.Add(true);        //true, boxing
            arraylist.Add("Hello!");    //false
            arraylist.Add(23.45);       //true, boxing

        }
    }
}
