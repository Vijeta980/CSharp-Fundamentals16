using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class PivotIndex
    {
        public static void Run()
        {
            int[] nums = { 1, 7, 3, 6, 5, 6 };

            int pivot = FindPivotIndex(nums);
            Console.WriteLine("Pivot Index: " + pivot);
        }

        public static int FindPivotIndex(int[] nums)
        {
            int totalSum = 0;

            foreach (int num in nums)
            {
                totalSum += num;
            }

            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int rightSum = totalSum - leftSum - nums[i];

                if (leftSum == rightSum)
                {
                    return i;
                }

                leftSum += nums[i];
            }

            return -1;
        }
    }
}
