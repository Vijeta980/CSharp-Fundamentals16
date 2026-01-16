namespace CSharpFundamentals.PracticeQue1
{
    public class ValidParenthesis
    {
        public static void Run()
        {
            var obj = new ValidParenthesis();

            string input = "({[]})";
            bool result = obj.IsValid(input);

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Is Valid: {result}");
        }

        public bool IsValid(string s)
        {
            var pairs = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            var stack = new Stack<char>();

            foreach (char ch in s)
            {
                if (pairs.ContainsValue(ch))
                {
                    stack.Push(ch);
                }
                else if (pairs.ContainsKey(ch))
                {
                    if (stack.Count == 0 || stack.Pop() != pairs[ch])
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
