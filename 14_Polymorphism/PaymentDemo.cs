using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals._14_Polymorphism
{
    public class PaymentDemo
    {
        public static void Run()
        {
            PaymentMethod payment;

            payment = new CreditCardPayment();
            payment.ProcessPayment(5000);

            payment = new UPIPayment();
            payment.ProcessPayment(3000);

            payment=new PayPalPayment();
            payment.ProcessPayment(4500);
        }
    }
}
