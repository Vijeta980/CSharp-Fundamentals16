using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class CountVowels
    {
        public static void Run()
        {
            Console.WriteLine("Enter a String:");
            string input = Console.ReadLine();

            int vowelCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char ch = char.ToLower(input[i]);

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount);

        }
    }
}
