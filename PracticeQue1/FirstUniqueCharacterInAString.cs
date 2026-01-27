using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class FirstUniqueCharacterInAString
    {
        public static void Run()
        {
             string s = "loveleetcode";
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(-1); 

        }
    }
}
