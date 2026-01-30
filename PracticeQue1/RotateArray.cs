using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class RotateArray
    {
        public static void Run()
        {
                       int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            k = k % nums.Length;
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
            Console.WriteLine(string.Join(", ", nums));

            static void Reverse(int[] arr, int start, int end)
            {
                while (start < end)
                {
                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                    start++;
                    end--;
                }
            }
        }
    }
}
