using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

namespace CSharpFundamentals.PracticeQue1
{
    public class TwoSum
    {
        public static void Run()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSumMethod(nums, target);

            Console.WriteLine(result[0] + ", " + result[1]);
        }

        public static int[] TwoSumMethod(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }

            return new int[] { };
        }
    }
}
