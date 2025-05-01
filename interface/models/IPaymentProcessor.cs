using System;

namespace Interface.models;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount); // Method to process payment
    void RefundPayment(decimal amount); // Method to refund payment

}
