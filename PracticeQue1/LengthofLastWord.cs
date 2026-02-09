using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class LengthofLastWord
    {
        public static void Run()
        {
            string s = "Hello World   ";

            int length = 0;
            int i = s.Length - 1;

            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }

            Console.WriteLine(length); 
        }
    }
}
