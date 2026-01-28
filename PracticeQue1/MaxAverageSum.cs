using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class MaxAverageSum
    {
        public static void Run()
        {
            int[] nums = { 1, 12, -5, -6, 50, 3 };
            int k = 4;
            double maxSum = double.MinValue;
            double currentSum = 0;
            for (int i = 0; i < k; i++)
            {
                currentSum += nums[i];
            }
            maxSum = currentSum;
            for (int i = k; i < nums.Length; i++)
            {
                currentSum += nums[i] - nums[i - k];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            double maxAverage = maxSum / k;
            Console.WriteLine(maxAverage);
        }
    }
}
