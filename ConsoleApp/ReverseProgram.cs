using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ReverseProgram
    {
        public static int ReverseNumber(int num)
        {
            int rev = 0;

            while(num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }

        public static String ReverseString(String word) {
            char[] chars = word.ToCharArray();
            String rev = "";
            for(int i=0;i<chars.Length;i++)
            {
                rev = chars[i] + rev;
            }
            return rev;
        }
    }
}
