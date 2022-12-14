using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ReverseProgram
    {
        public static void ReverseNumber()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;

            while(num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine(rev);
        }

        public static void ReverseString() {
            String word = Console.ReadLine();
            char[] chars = word.ToCharArray();
            String rev = "";
            for(int i=0;i<chars.Length;i++)
            {
                rev = chars[i] + rev;
            }
            Console.WriteLine(rev);
        }
    }
}
