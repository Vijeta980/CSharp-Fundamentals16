using System;

namespace CSharpFundamentals.PracticeQue1
{
    public class FirstUniqueChar
    {
        public static void Run()
        {
            string s = "leetcode";
            int[] count = new int[26];

            foreach (char c in s)
            {
                count[c - 'a']++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (count[s[i] - 'a'] == 1)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}
