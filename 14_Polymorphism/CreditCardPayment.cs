using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals._14_Polymorphism
{
    public class CreditCardPayment:PaymentMethod
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing {amount} via Credit Card");
        }
    }
}
