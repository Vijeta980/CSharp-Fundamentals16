using System;
using System.Collections.Generic;

namespace CSharpFundamentals.PracticeQue1
{
    public class NextGreaterElement
    {
        public static void Run()
        {
            int[] nums = { 2, 1, 2, 4, 3 };
            int[] result = NextGreater(nums);

            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
        }

        public static int[] NextGreater(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>();

            for (int i = n - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek() <= nums[i])
                {
                    stack.Pop();
                }

                result[i] = stack.Count == 0 ? -1 : stack.Peek();
                stack.Push(nums[i]);
            }

            return result;
        }
    }
}