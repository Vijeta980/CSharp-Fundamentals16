using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals._14_Polymorphism
{
    public class PayPalPayment:PaymentMethod
    {
        public override void  ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing {amount} via PayPal");
        }
    }
}
