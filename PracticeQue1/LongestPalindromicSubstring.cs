using System;

namespace CSharpFundamentals.PracticeQue1
{
    public class LongestPalindromicSubstring
    {
        public static void Run()
        {
            string s = "babad";
            Console.WriteLine(LongestPalindrome(s));
        }

        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";

            int start = 0, maxLength = 1;

            for (int i = 0; i < s.Length; i++)
            {
                // Odd length palindrome
                ExpandFromCenter(s, i, i, ref start, ref maxLength);

                // Even length palindrome
                ExpandFromCenter(s, i, i + 1, ref start, ref maxLength);
            }

            return s.Substring(start, maxLength);
        }

        private static void ExpandFromCenter(string s, int left, int right, ref int start, ref int maxLength)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                int length = right - left + 1;

                if (length > maxLength)
                {
                    maxLength = length;
                    start = left;
                }

                left--;
                right++;
            }
        }
    }
}
