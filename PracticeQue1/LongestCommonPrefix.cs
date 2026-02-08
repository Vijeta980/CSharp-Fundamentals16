using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class LongestCommonPrefix
    {
        public static void Run()
        {
                       string[] strs = { "flower", "flow", "flight" };
            var result = LongestCommonPrefixMethod(strs);
            Console.WriteLine(result);

        }

        public static string LongestCommonPrefixMethod(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return string.Empty;
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix))
                        return string.Empty;
                }
            }
            return prefix;
        }
    }
}
