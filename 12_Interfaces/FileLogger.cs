using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals._12_Interfaces
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging to file:" + message);
        }
    }
}
