using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class Kadane
    {
        public static void Run()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            int maxSub = nums[0];
            int currentSum = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                maxSub=Math.Max(maxSub, currentSum);
            }
            Console.WriteLine(maxSub);
            }
    }
}
