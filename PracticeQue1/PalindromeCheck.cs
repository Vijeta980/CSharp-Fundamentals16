using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class PalindromeCheck
    {
        public static void Run()
        {
            Console.WriteLine("Enter a string:");
            string input=Console.ReadLine();


            int left = 0;
            int right=input.Length - 1;

            bool isPalindrome = true;
            while (left < right)
            {
                char lc=input[left];
                char rc=input[right];

                if(lc>='A' && lc<='Z')
                    lc=(char)(lc+32);

                if (rc >= 'A' && rc <= 'Z')
                    rc = (char)(lc + 32);

                if (lc!=rc)
                {
                    isPalindrome = false;
                    break;
                }
                left++;
                right--;
            }
            if(isPalindrome)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }
    }
}
