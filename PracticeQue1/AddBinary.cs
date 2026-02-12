using System;
using System.Text;

namespace CSharpFundamentals.PracticeQue1
{
    public class AddBinary
    {
        public static void Run()
        {
            string a = "1010";
            string b = "1011";

            string result = AddBinaryMethod(a, b);
            Console.WriteLine(result);   
        }

        public static string AddBinaryMethod(string a, string b)
        {
            StringBuilder sb = new StringBuilder();

            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;

                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;
                }

                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }

                sb.Append(sum % 2);   
                carry = sum / 2;      
            }

            char[] arr = sb.ToString().ToCharArray();
            Array.Reverse(arr);

            return new string(arr);
        }
    }
}
