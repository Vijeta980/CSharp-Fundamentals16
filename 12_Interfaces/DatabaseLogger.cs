using System;

namespace CSharpFundamentals._12_Interfaces
{
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging to database: " + message);
        }
    }
}
