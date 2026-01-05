using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class RevString
    {
        public static void Run() {
            Console.WriteLine("Enter a String:");
            string input= Console.ReadLine();

            char[] revArray=new char[input.Length];

            for(int i=0;i<input.Length;i++)
            {
                revArray[i] = input[input.Length - 1 - i];
            }

            string rev=new string (revArray);
            Console.WriteLine("Reversed string:"+rev);

        }
        

    }
}
