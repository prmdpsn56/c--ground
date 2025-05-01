using System;
using Interface.models;

namespace Interface.classes;

public class PaypalProcessor:IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        System.Console.WriteLine("PaypalProcessor Processing credit card payment of " + amount);
    }

    public void RefundPayment(decimal amount)
    {
        System.Console.WriteLine("PaypalProcessor Refunding credit card payment of " + amount);
    }
}
