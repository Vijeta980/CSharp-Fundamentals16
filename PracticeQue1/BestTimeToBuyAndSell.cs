using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class BestTimeToBuyAndSell
    {
        public static void Run()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };

            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else
                {
                    int profit = prices[i] - minPrice;
                    maxProfit = Math.Max(maxProfit, profit);
                }
            }

            Console.WriteLine("Maximum Profit: " + maxProfit);
        }
    }
}
