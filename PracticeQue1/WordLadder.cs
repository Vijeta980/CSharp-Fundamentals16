using System;
using System.Collections.Generic;

namespace CSharpFundamentals.PracticeQue1
{
    public class WordLadder
    {
        public static void Run()
        {
            string beginWord = "hit";
            string endWord = "cog";
            List<string> wordList = new List<string>
            { "hot","dot","dog","lot","log","cog" };

            Console.WriteLine(LadderLength(beginWord, endWord, wordList));
        }

        public static int LadderLength(string beginWord, string endWord, List<string> wordList)
        {
            HashSet<string> set = new HashSet<string>(wordList);
            if (!set.Contains(endWord)) return 0;

            Queue<string> queue = new Queue<string>();
            queue.Enqueue(beginWord);
            int level = 1;

            while (queue.Count > 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    string word = queue.Dequeue();
                    char[] arr = word.ToCharArray();

                    for (int j = 0; j < arr.Length; j++)
                    {
                        char original = arr[j];

                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            arr[j] = c;
                            string newWord = new string(arr);

                            if (newWord == endWord)
                                return level + 1;

                            if (set.Contains(newWord))
                            {
                                queue.Enqueue(newWord);
                                set.Remove(newWord);
                            }
                        }

                        arr[j] = original;
                    }
                }

                level++;
            }

            return 0;
        }
    }
}