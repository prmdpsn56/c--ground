using System;
using System.Net.WebSockets;

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A5","Audi",true);
            // audi.Brand = Console.ReadLine();
            // System.Console.WriteLine("you have entered " + audi.Brand);
            // Car bmw = new Car ("3 series","BMW");
            System.Console.WriteLine(audi.Brand);


            //custom class logic and working

            Customer customer = new Customer("Paramdeep", "delta","90909090909");
            customer.getDetails();

            Customer customer1 = new Customer("FrankTheTank");
            customer1.getDetails();


            Customer customer2  = new Customer();
            System.Console.WriteLine("Please enter a name for this unknown customer");
            //updating the custom first time
            customer2.Name = Console.ReadLine();
            customer2.Password = "saini";
            customer2.getDetails();

            //updating the custom second time
            // customer2.UpdateDetails("Paramdeep Singh Saini","Delta","7788391634");
            // customer2.getDetails();



            // calling static methods
            // System.Console.WriteLine(AddNumber(40,10));
            // System.Console.WriteLine(AddNumber(firstNumber:50,secondNumber:20));
            // System.Console.WriteLine(Car.NumberOfCars);

        }

        static int AddNumber(int firstNumber,int secondNumber){
            return firstNumber + secondNumber;
        }
    }
}