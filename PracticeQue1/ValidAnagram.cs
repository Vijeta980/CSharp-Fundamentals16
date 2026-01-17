using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class ValidAnagram
    {
        public static void Run()
        {
            string a= "anagram";
            string b= "nagaram";

            if(a.Length!= b.Length)
            {
                Console.WriteLine("Not an Anagram");
                return;
            }
            var charCount = new Dictionary<char, int>();
            foreach (var ch in a)
            {
                if (charCount.ContainsKey(ch))
                    charCount[ch]++;
                else
                    charCount[ch] = 1;
            }
            foreach (var ch in b)
            {
                if (charCount.ContainsKey(ch))
                {
                    charCount[ch]--;
                    if (charCount[ch] < 0)
                    {
                        Console.WriteLine("Not an Anagram");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Not an Anagram");
                    return;
                }
            }

            Console.WriteLine("Anagram");

        }
    }
}
