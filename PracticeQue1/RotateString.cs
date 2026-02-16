using System;

namespace CSharpFundamentals.PracticeQue1
{
    public class RotateString
    {
        public static void Run()
        {
            string s = "abcde";
            string goal = "cdeab";

            Console.WriteLine(IsRotate(s, goal));
        }

        public static bool IsRotate(string s, string goal)
        {
            if (s.Length != goal.Length)
                return false;

            string doubled = s + s;

            return doubled.Contains(goal);
        }
    }
}
