using System;
using System.Collections.Generic;
using System.Text;


//abstract ensures child classes must implement the method.

namespace CSharpFundamentals._14_Polymorphism
{
    public abstract class PaymentMethod
        {
            public abstract void ProcessPayment(double amount);
        }
    
}
