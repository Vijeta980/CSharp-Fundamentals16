using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals._02_PrimitiveTypes
{
    class Variables
    {
        public static void ShowVariables()
        {
            int age = 21;
            double salary = 50000.50;
            char grade = 'O';
            bool isStudent = true;
            string name = "Vijeta";

            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Salary: "+salary);
            Console.WriteLine("Is Student: "+isStudent);
            Console.WriteLine("Grade: "+grade);
        }
    }
}
