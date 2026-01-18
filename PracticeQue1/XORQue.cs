using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class XORQue
    {
        public static void Run()
        {
            int[] nums = { 4, 1, 2, 1, 2 };

            int result = 0;

            foreach (int num in nums)
            {
                result ^= num;   
            }

            Console.WriteLine(result); 
        }
    }
}
