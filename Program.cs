using CSharp_Fundamentals._01_Introduction;
using CSharp_Fundamentals._02_PrimitiveTypes;
using CSharp_Fundamentals._03_NonPrimitiveTypes;
using CSharp_Fundamentals._04_ConditionalStatements;
using CSharp_Fundamentals._05_Loops;
//using CSharp_Fundamentals._06_ArraysAndLists;
//using CSharp_Fundamentals._07_StringsBasic;
using CSharp_Fundamentals.PracticeQue1;
using CSharpFundamentals._07_StringsBasic;
using System;
using CSharpFundamentals._08_DateTime;

namespace CSharp_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //WhileLoop.loop3();
            //StringBasic.Run();
            //Datetime.Run();
            //Timespan.Run();

            //Person object

            Person person = new Person();
            person.Name = "Vijeta";
            person.Age = 22;
            person.Introduce();

            //Calculator object
            Calculator calc=new Calculator();
            Console.WriteLine("Addition: " + calc.Add(10, 5));

            //Customer object
            Customer customer=new Customer(1, "Eshita");
            customer.ShowDetails();

            Console.ReadLine();
        }
    }
}
