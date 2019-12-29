using System;
using System.Collections;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //contains int values 
            MyGenericClass<int> c1 = new MyGenericClass<int>(5, 10, 15);

            //retrieve value for D!
            Console.WriteLine(c1.D1);

            //display the contents of c1
            c1.Print();

            //reset values to 0 ()default for int) 
            c1.ResetValues();

            //display the contents of c1
            c1.Print();

            //contains string values 
            MyGenericClass<string> c2 = new MyGenericClass<string>("a", "b", "c");

            //display the contents of c2 
            c2.Print();

            //reset values to null (default for strings)
            c2.ResetValues();

            //display the contents of c2
            c2.Print();
        }
    }
}
