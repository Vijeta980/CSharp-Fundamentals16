using System;

namespace CSharpFundamentals._10_ClassesAndObjects
{
    public class Person
    {
        public string Name;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}