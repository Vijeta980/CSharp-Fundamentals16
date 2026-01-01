using System;

namespace CSharpFundamentals.Inheritance
{
    // Base class
    public class Employee
    {
        public string Name;
        public int Salary;

        public void ShowEmployee()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }

    // Derived class 1
    public class Developer : Employee
    {
        public string Technology;

        public void ShowDeveloper()
        {
            Console.WriteLine($"Technology: {Technology}");
        }
    }

    // Derived class 2
    public class Manager : Employee
    {
        public int TeamSize;

        public void ShowManager()
        {
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }
}
