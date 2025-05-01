using System;
using Interface.models;

namespace Interface.services;

public class PaymentService
{
    private readonly IPaymentProcessor _paymentProcessor; // Dependency on IPaymentProcessor

    public PaymentService(IPaymentProcessor paymentProcessor) // Constructor injection
    {
        _paymentProcessor = paymentProcessor;
    }

}
