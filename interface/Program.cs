using System;
using Interface.classes;
using Interface.models;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Eat(); // Output: Cat is eating.
            cat.Sleep(); // Output: Cat is sleeping.    
            cat.Speak(); // Output: Cat says meow.

            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            creditCardProcessor.ProcessPayment(100.00m); // Output: Processing credit card payment of 100.00

            IPaymentProcessor paypalProcessor = new PaypalProcessor();
            paypalProcessor.ProcessPayment(200.00m); // Output: Processing credit card payment of 200.00


            string path = @"/paramdeepsingh/Documents/file.txt";
            string filePath = System.IO.Path.Combine(path, "file.txt");

            File.AppendAllText(filePath, "Log entry at ");
            Console.ReadKey();
            
        }
    }

}