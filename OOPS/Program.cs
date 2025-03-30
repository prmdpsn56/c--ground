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

        }
    }
}