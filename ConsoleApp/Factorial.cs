using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp
{
    internal class Factorial
    {
        public static void Fact()
        {
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int Fact = 1;
            

            for(int i=1; i<=n; i++) { 
                Fact = Fact* i;

            }
            Console.Write(Fact);
        }
    }
}
