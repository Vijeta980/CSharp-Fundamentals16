using System;

namespace CSharpFundamentals.PracticeQue1
{
    public class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                int minHeight = Math.Min(height[left], height[right]);
                int width = right - left;
                int currentArea = minHeight * width;

                maxArea = Math.Max(maxArea, currentArea);

                // Move pointer with smaller height
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }

        public static void Run()
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int result = MaxArea(height);

            Console.WriteLine("Maximum Water: " + result);
        }
    }
}