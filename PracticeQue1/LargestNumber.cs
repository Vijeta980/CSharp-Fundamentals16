using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class LargestNumber
    {
        public static void Run()
        {
                       int[] num = { 5, 2, 9, 1, 5, 6 };
            int max = num[0];
            int min = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
                if (num[i] > max)
                {
                    max = num[i];
                }
            }
            Console.WriteLine("Largest number: " + max);
            Console.WriteLine("Smallest number: " + min);

        }
    }
}
