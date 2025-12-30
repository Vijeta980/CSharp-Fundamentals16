using System;

namespace CSharpFundamentals._10_ClassesAndObjects
{
    public class Customer
    {
        public string Name;
        public int id;
        
        public Customer(int id, string name)
        {
            this.id = id;
            this.Name = name;
        }
        public void ShowDetails()
        {
            Console.writeLine($"Customer ID: {id}, Customer Name: {Name}");
        }

    }
}