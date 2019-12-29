using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    public class MyGenericClass<T>
    { 
        //Generic variables 
        private T d1; 
        private T d2; 
        private T d3;
        public MyGenericClass() 
        {
            
        }

        //Generic non-default constructor 
        public MyGenericClass(T a1, T a2, T a3) 
        { 
            d1 = a1; 
            d2 = a2; 
            d3 = a3; 
        }

        //Generic properties 
        public T D1 
        {
            get { return d1; } 
            set { d1 = value; } 
        }
        public T D2 
        { 
            get { return d2; } 
            set { d2 = value; } 
        }
        public T D3 
        { 
            get { return d3; } 
            set { d3 = value; } 
        }

        public void Print()
        {
            Console.WriteLine($"D1={d1}, D2={d2}, D3={d3}");
        }
        public void ResetValues()
        {
            d1 = default(T);
            d2 = default(T);
            d3 = default(T);
        }
    }
}
