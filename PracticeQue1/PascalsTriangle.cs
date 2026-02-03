using System;
using System.Collections.Generic;

namespace CSharpFundamentals.PracticeQue1
{
    public class PascalsTriangle
    {
        public static void Run()
        {
            int numRows = 5;

            List<List<int>> triangle = Generate(numRows);

            foreach (var row in triangle)
            {
                foreach (var val in row)
                {
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
        }

        public static List<List<int>> Generate(int numRows)
        {
            List<List<int>> triangle = new List<List<int>>();

            for (int i = 0; i < numRows; i++)
            {
                List<int> row = new List<int>();

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        int value = triangle[i - 1][j - 1] + triangle[i - 1][j];
                        row.Add(value);
                    }
                }

                triangle.Add(row);
            }

            return triangle;
        }
    }
}
