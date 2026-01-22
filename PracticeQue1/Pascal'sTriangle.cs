using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class Pascal_sTriangle
    {
        public static void Run(string[] args)
        {
            int numRows = 5; 
            List<List<int>> triangle = Generate(numRows);
            foreach (var row in triangle)
            {
                Console.WriteLine(string.Join(" ", row));
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
                        row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
                    }
                }
                triangle.Add(row);
            }
            return triangle;
        }
    }
}
