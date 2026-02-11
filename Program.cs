// See https://aka.ms/new-console-template for more information
//1.find max and min
//int[] num = { 5, 2, 3, 4, 0 };

//int min = num[0];
//int max = num[0];

//for(int i = 1; i < num.Length; i++)
//{
//    if (num[i] < min)
//    {
//        min = num[i];
//    }
//    if (num[i] > max)
//    {
//        max = num[i];
//    }
//}
//Console.WriteLine(max);
//Console.WriteLine(min);

// 2.rev an array without using an extra array.

//int[] arr = { 1, 6, 5, 4, 3, 2 };

//int left = 0;
//int right = arr.Length - 1;

//while (left < right)
//{
//    int temp = arr[left];
//    arr[left] = arr[right];
//    arr[right] = temp;
//    left++;
//    right--;
//}
//foreach(var n in arr)
//{
//    Console.WriteLine(n);
//}

//3.rotate an array to the right by k positions.

//int[] arr = { 1, 2, 3, 4, 5 };
//int k = 3;

//int n=arr.Length;
//k = k % n;
//int[] temp=new int[n];

//for(int i = 0; i < k; i++)
//{
//    temp[i] = arr[n - k + i];
//}

//for(int i = 0; i < n - k; i++)
//{
//    temp[k + i] = arr[i];
//}

//foreach(var x in temp)
//{
//    Console.WriteLine(x+" ");
//}

//3.rotate an array to the right by k positions.

//using System;

//class MainClass
//{
//    static void Reverse(int[] arr, int start, int end)
//    {
//        while (start < end)
//        {
//            int temp = arr[start];
//            arr[start] = arr[end];
//            arr[end] = temp;
//            start++;
//            end--;
//        }
//    }

//    static void RightRotate(int[] arr, int k)
//    {
//        int n = arr.Length;
//        k = k % n;

//        Reverse(arr, 0, n - 1);
//        Reverse(arr, 0, k - 1);
//        Reverse(arr, k, n - 1);
//    }

//    static void Main()
//    {
//        int[] arr = { 1, 2, 3, 4, 5 };
//        int k = 2;

//        RightRotate(arr, k);

//        foreach (int x in arr)
//        {
//            Console.Write(x + " ");
//        }
//    }
//}

//4.count even n odds
//int[] arr = { 1, 2, 3, 4, 5 };
//int countE = 0;
//int countO = 0;

//for(int i=0; i<arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        countE=countE+1; 
//    }
//    else
//    {
//        countO = countO + 1 ;
//    }
//}
//Console.WriteLine(countE);
//Console.WriteLine(countO);

//5.sec largest distinct element in array

//int[] arr = { 1, 2, 3, 4, 5,5, 4, 6 };
//int max = int.MinValue;
//int secondMax = int.MinValue;

//HashSet<int> set = new HashSet<int>(arr);

//foreach(int n in set)
//{
//    if (n > max)
//    {
//        secondMax = max;
//        max = n;
//    }
//    else if (n > secondMax)
//    {
//        secondMax = n;
//    }
//}
//Console.WriteLine(secondMax);

//6.Intersection
//using System.Collections.Generic;
//using System.Numerics;

//int[] arr1 = { 1, 2, 3, 4, 5, 6 };
//int[] arr2 = { 1, 2, 3 };

//HashSet<int> set = new HashSet<int>();
//for(int i = 0; i < arr1.Length; i++)
//{
//    for(int j = 0; j < arr2.Length; j++)
//    {
//        if (arr1[i] == arr2[j])
//        {
//            set.Add(arr1[i]);
//        }
//    }
//}
//Console.WriteLine("Set:");
//foreach(int val in set)
//{
//    Console.WriteLine(val+" ");
//}
//using PracticeQue;

//Intersection.Run();

//using CSharpFundamentals.Inheritance;

//Developer dev = new Developer();
//dev.Name = "Rahul";
//dev.Salary = 60000;
//dev.Technology = "C#";

//dev.ShowEmployee();
//dev.ShowDeveloper();

//Console.WriteLine();

//Manager mgr = new Manager();
//mgr.Name = "Anita";
//mgr.Salary = 90000;
//mgr.TeamSize = 8;

//mgr.ShowEmployee();
//mgr.ShowManager();

//using CSharpFundamentals._12_Interfaces;

//LooseCoupling.Run();
//using CSharpFundamentals._13_ExceptionHandling;

//ExceptionHandling.Run();

//using CSharpFundamentals._14_Polymorphism;
//PaymentDemo.Run();


//using CSharpFundamentals.PracticeQue1;
//RevString.Run();

using CSharpFundamentals;
using CSharpFundamentals.PracticeQue1;
//PalindromeCheck.Run();
//CountVowels.Run();
//RemoveDuplicates.Run();
//MovesZeroes.Run();
//twoSum.Run();
//checkDuplicate.Run();
//BestTimeToBuyAndSell.Run();
//Kadane.Run();
//ExcelSheet.Run();
//ValidParenthesis.Run();
//ValidAnagram.Run();
//XORQue.Run();
//BinarySearch.Run();
//FirstUniqueChar.Run();
//Pascal_sTriangle.Run(args);
//MissingNumber.Run();
//BestTimeToBuyAndSell2.Run();
//MajorityElement.Run();
//ReverseString.Run();
//FirstUniqueCharacterInAString.Run();
//MaxAverageSum.Run();
//QueueMaxSlidingWindow.Run();
//RotateArray.Run();
//MajorityElement_Voting_.Run();
//MovesZeroesAtEnd.Run();
//DiamondPattern.Run();
//PivotIndex.Run();
//FirstOccurrence.Run();
//LongestCommonPrefix.Run();
//LengthofLastWord.Run();
//LargestNumber.Run();
SingleElementInSortedArray.Run();
//using CSharpFundamentals.PracticeQue.PracticeQue;
//CapgQ.Run();