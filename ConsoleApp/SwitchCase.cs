using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp
{
    internal class SwitchCase
    {
        public static void switchCase()
        {

            Console.WriteLine("Enter a number ");
            Console.WriteLine("1. Factorial  2. Fibonacci  3. Palindrome");
            Console.WriteLine("4. ReverseProgram  5. Sum of N numbers");
            int n = Convert.ToInt32(Console.ReadLine());

            switch(n){
                    case 1:
                    Factorial.Fact();
                    break;
                    case 2:
                    Fibonacci.fib();
                    break;  
                    case 3:
                    Console.WriteLine("1. Number Palindrome  2. String Palindrome");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if(a == 1)
                    {
                        Palindrome.numPalindrome();
                    }
                    if(a == 2)
                    {
                        Palindrome.StringPalindrome();
                    }
                    break;
                    case 4:
                    Console.WriteLine("1. Reverse number  2. Reverse String");
                    int b = Convert.ToInt32(Console.ReadLine());
                    if(b==1)
                    {
                        ReverseProgram.ReverseNumber();
                    }
                    if (b == 2)
                    {
                        ReverseProgram.ReverseString();
                    }
                    break;
                    case 5:
                    SumOfNnum.sum();
                    break;
            }
        }
    }
}
