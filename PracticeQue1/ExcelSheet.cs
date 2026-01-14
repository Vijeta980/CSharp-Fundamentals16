using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class ExcelSheet
    {
        public static void Run()
        {
            string columnTitle = "AB";
            int result = TitleToNumber(columnTitle);

            Console.WriteLine($"The column number for '{columnTitle}' is: {result}");

        }
        static int TitleToNumber(string columnTitle)
        {
            int result = 0;
            foreach (char c in columnTitle)
            {
                
                result = result * 26 + (c-'A'+1);
            }
            return result;
        }
    }
}
