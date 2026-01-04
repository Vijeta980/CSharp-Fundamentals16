//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CSharpFundamentals._13_ExceptionHandling
//{
//    internal class ExceptionHandling
//    {

//       public static void Run()
//        {
//            try
//            {
//                Console.WriteLine( "Enter a number:");
//                int number = Convert.ToInt32(Console.ReadLine());

//                int result = 100 / number;
//                Console.WriteLine($"100/{number}={result}");
//            }
//            catch(DivideByZeroException ex) {
//                Console.WriteLine("Error:Cannot divide by zero.");
//                Console.WriteLine(ex.Message);

//            }
//            catch(FormatException ex)
//            {
//                Console.WriteLine("Error:Invalid input.Please enter a valid integer.");
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("Execution completed.");
//            }
//            Console.WriteLine("Program continues.");
//        }
//    }
//}
