using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class ReverseString
    {
        public static void Run()
        {
            string s = "  hello   world  ";
            StringBuilder result = new StringBuilder();

            int i = s.Length - 1;

            while (i >= 0)
            {
                while (i >= 0 && s[i] == ' ')
                    i--;

                if (i < 0) break;

                int j = i;

                while (i >= 0 && s[i] != ' ')
                    i--;

                for (int k = i + 1; k <= j; k++)
                    result.Append(s[k]);

                result.Append(' ');
            }

            if (result.Length > 0)
                result.Length--;

            Console.WriteLine(result.ToString());
        }
    }
}
