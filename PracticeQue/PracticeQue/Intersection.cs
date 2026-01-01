//using System;
//using System.Collections.Generic;

//namespace PracticeQue
//{
//    internal class Intersection
//    {
//        public static void Run()
//        {
//            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
//            int[] arr2 = { 1, 2, 3 };

//            HashSet<int> set = new HashSet<int>();

//            for (int i = 0; i < arr1.Length; i++)
//            {
//                for (int j = 0; j < arr2.Length; j++)
//                {
//                    if (arr1[i] == arr2[j])
//                    {
//                        set.Add(arr1[i]);
//                    }
//                }
//            }

//            Console.WriteLine("Intersection:");
//            foreach (int val in set)
//            {
//                Console.Write(val + " ");
//            }
//        }
//    }
//}
