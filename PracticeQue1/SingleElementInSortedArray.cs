using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class SingleElementInSortedArray
    {
        public static void Run()
        {
            int[] nums = { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
            Console.WriteLine(SingleNonDuplicate(nums));
        }

        public static int SingleNonDuplicate(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (mid % 2 == 0)
                {
                    if (nums[mid] == nums[mid + 1])
                    {
                        left = mid + 2; 
                    }
                    else
                    {
                        right = mid; 
                    }
                }
                else
                {
                    if (nums[mid] == nums[mid - 1])
                    {
                        left = mid + 1; 
                    }
                    else
                    {
                        right = mid - 1; 
                    }
                }
            }
            return nums[left]; 
        }
    }
}
