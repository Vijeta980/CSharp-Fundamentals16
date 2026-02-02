using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class MovesZeroesAtEnd
    {
        public static void Run()
        {
                       int[] nums = { 0, 1, 0, 3, 12 };
            int lastNonZeroFoundAt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[lastNonZeroFoundAt] = nums[i];
                    lastNonZeroFoundAt++;
                }
            }
            for (int i = lastNonZeroFoundAt; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
            Console.WriteLine(string.Join(", ", nums));

        }
    }
}
