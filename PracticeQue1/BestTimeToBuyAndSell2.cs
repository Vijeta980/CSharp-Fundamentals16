using System;

namespace CSharpFundamentals.PracticeQue1
{
    public class BestTimeToBuyAndSell2
    {
        public static void Run()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }

            Console.WriteLine("Maximum Profit: " + profit);
        }
    }
}
