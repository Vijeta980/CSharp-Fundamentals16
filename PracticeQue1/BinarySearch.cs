using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CSharpFundamentals.PracticeQue1
{
    public class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        public static void Run()
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            Console.WriteLine(Search(nums, 9)); 
            Console.WriteLine(Search(nums, 2)); 
        }
    }
}
