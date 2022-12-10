using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Palindrome
    {
       public static void numPalindrome()
        {
            int num, rev = 0;
            Console.WriteLine("Enter the number for palindrome check : ");
            num = Convert.ToInt32(Console.ReadLine());
            int mun = num;

            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }

            if (mun == rev)
            {
                Console.WriteLine("Number is palindrome.");
            }
            else
            {
                Console.WriteLine("Number is not palindrome.");
            }
            
        }

        public static void StringPalindrome()
        {
            Console.WriteLine("Enter the String to check if palindrome");
            String S = Console.ReadLine();
            char[] s = S.ToCharArray();
            String rev = "";
            for(int i=0;i<s.Length;i++)
            {
                rev = s[i] + rev;
            }
            if (rev == S)
            {
                Console.WriteLine("String is a Palindrome");
            }
            else
            {
                Console.WriteLine("String is not a Palindrome");
            }
        }
    }
}
