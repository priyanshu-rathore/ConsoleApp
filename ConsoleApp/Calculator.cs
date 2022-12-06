using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
     class Calculator
    {
        public void Sum(int a,int b)
        {
            int sum = a + b;

            Console.WriteLine("Sum : " + sum);
        }

        public void Sub(int a, int b)
        {
            int sub = a - b;

            Console.WriteLine("Diff : " + sub);
        }

        public void mul(int a,int b)
        {
            int mul = a * b;
            Console.WriteLine("Product : " + mul);
        }

        public void div(int a , int b)
        {
            int div = a / b;
            Console.WriteLine("Quotient : " + div);
        }

    }
}
