using System;
using System.Collections.Generic;

namespace CSharpFundamentals.PracticeQue1
{
    public class LargestRectangleHistogram
    {
        public static void Run()
        {
            int[] heights = { 2, 1, 5, 6, 2, 3 };
            Console.WriteLine(LargestRectangleArea(heights));
        }

        public static int LargestRectangleArea(int[] heights)
        {
            Stack<int> stack = new Stack<int>();
            int maxArea = 0;

            for (int i = 0; i <= heights.Length; i++)
            {
                int currentHeight = (i == heights.Length) ? 0 : heights[i];

                while (stack.Count > 0 && currentHeight < heights[stack.Peek()])
                {
                    int height = heights[stack.Pop()];
                    int width = (stack.Count == 0) ? i : i - stack.Peek() - 1;
                    int area = height * width;

                    maxArea = Math.Max(maxArea, area);
                }

                stack.Push(i);
            }

            return maxArea;
        }
    }
}