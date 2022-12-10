using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class SumOfNnum
    {
        public static void sum() {
            Console.Write("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for(int i = 0; i <= n; i++)
            {
                sum = sum + i;
                
            }

            Console.Write(sum);
            

        }
    }
}
