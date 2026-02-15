using System;
using System.Collections.Generic;

namespace CSharpFundamentals.PracticeQue1
{
    public class SpiralMatrix
    {
        public static void Run()
        {
            int[,] matrix = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            var result = SpiralOrder(matrix);

            foreach (var num in result)
            {
                Console.Write(num + " ");
            }
        }

        public static List<int> SpiralOrder(int[,] matrix)
        {
            List<int> result = new List<int>();

            int top = 0;
            int bottom = matrix.GetLength(0) - 1;
            int left = 0;
            int right = matrix.GetLength(1) - 1;

            while (top <= bottom && left <= right)
            {
                // 1. Left → Right
                for (int i = left; i <= right; i++)
                    result.Add(matrix[top, i]);
                top++;

                // 2. Top → Bottom
                for (int i = top; i <= bottom; i++)
                    result.Add(matrix[i, right]);
                right--;

                // 3. Right → Left
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                        result.Add(matrix[bottom, i]);
                    bottom--;
                }

                // 4. Bottom → Top
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                        result.Add(matrix[i, left]);
                    left++;
                }
            }

            return result;
        }
    }
}
