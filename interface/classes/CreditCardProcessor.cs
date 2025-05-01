using System;
using Interface.models;

namespace Interface.classes;

public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        System.Console.WriteLine("CreditCardProcessor Processing credit card payment of " + amount);
    }

    public void RefundPayment(decimal amount)
    {
        System.Console.WriteLine("CreditCardProcessor Refunding credit card payment of " + amount);
    }

}
