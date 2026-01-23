using System;

namespace CSharpFundamentals.PracticeQue1
{
    public class MissingNumber
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 4, 6, 3, 7, 8 };
            int missingNumber = FindMissingNumber(numbers);

            Console.WriteLine($"The missing number is: {missingNumber}");
        }

        public static int FindMissingNumber(int[] numbers)
        {
            int n = numbers.Length + 1;
            int expectedSum = n * (n + 1) / 2;

            int actualSum = 0;
            foreach (int num in numbers)
            {
                actualSum += num;
            }

            return expectedSum - actualSum;
        }
    }
}
