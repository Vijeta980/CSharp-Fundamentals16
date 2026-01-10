using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class checkDuplicate
    {
        public static void Run()
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();

            HashSet<char> chars = new HashSet<char>();
            foreach (char ch in input)
            {
                if (chars.Contains(ch))
                {
                    Console.WriteLine("Duplicate found: " + ch);
                    
                }
                else
                {
                    chars.Add(ch);
                }
            }

            //int[] num = { 1, 2, 2, 3, 4, 5, 5, 6 };
            //HashSet<int> numbers = new HashSet<int>();

            //foreach(int n in num)
            //{
            //    if (numbers.Contains(n))
            //    {
            //        Console.WriteLine("Duplicate found:"+n);
            //    }
            //    else
            //    {
            //        numbers.Add(n);
            //    }
            //}
        }
        }
}
