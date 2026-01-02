using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals._12_Interfaces
{
    internal class LooseCoupling
    {
        public static void Run()
        {
            //Bad(tight coupling:

            //var logger = new FileLogger();

            ILogger logger = new FileLogger();
            logger.Log("Application started.");

        }

    }
}
