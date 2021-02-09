using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    class Calculator
    {
        public void Add(int n1 , int n2)
        {
            int total = n1 + n2;
            Console.WriteLine("toplamları : " + total + "dır.");

        }

        public void Substraction(int n1, int n2)
        {
            int substraction = n1 - n2;
            Console.WriteLine(substraction);
        }



    }
}
