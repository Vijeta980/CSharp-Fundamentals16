using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class FirstOccurrence
    {
        public static void Run()
        {
            string haystack= "hello";
            string needle = "llo";

            int index = FindFirstOccurrence(haystack, needle);
            Console.WriteLine(index);

        }

        public static int FindFirstOccurrence(string haystack, string needle)
        {
            if (needle.Length == 0)
                return 0;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                int j = 0;

                while (j < needle.Length && haystack[i + j] == needle[j])
                {
                    j++;
                }

                if (j == needle.Length)
                    return i;
            }

            return -1;

        }
    }
}
