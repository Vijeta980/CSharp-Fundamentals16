using System;

namespace CSharpFundamentals.PracticeQue.PracticeQue
{
    public class CapgQ
    {
        public static void Run()
        {
            Console.WriteLine("Enter the size of first array:");
            int size1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the size of second array:");
            int size2 = int.Parse(Console.ReadLine());

            if (size1 <= 0 || size2 <= 0)
            {
                Console.WriteLine("Invalid array size");
                return;
            }

            if (size1 != size2)
            {
                Console.WriteLine("Arrays are of different sizes");
                return;
            }

            int[] arr1 = new int[size1];
            int[] arr2 = new int[size2];

            Console.WriteLine("Enter the first array elements:");
            for (int i = 0; i < size1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                if (arr1[i] < 0)
                {
                    Console.WriteLine("Invalid array element");
                    return;
                }
            }

            Console.WriteLine("Enter the second array elements:");
            for (int i = 0; i < size2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
                if (arr2[i] < 0)
                {
                    Console.WriteLine("Invalid array element");
                    return;
                }
            }

            int[] combine = combineArr(arr1, arr2);
            int sumOfLastDigits = calculateSum(combine);

            bool prime = isPrime(sumOfLastDigits);

            if (prime)
                Console.WriteLine(sumOfLastDigits + " is a prime number");
            else
                Console.WriteLine(sumOfLastDigits + " is not a prime number");
        }

        static int[] combineArr(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length];

            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }
            return arr3;
        }

        static int calculateSum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i] % 10;
            }
            return sum;
        }

        static bool isPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
