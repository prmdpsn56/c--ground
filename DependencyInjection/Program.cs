using System;
using DependencyInjection.classes;
using DependencyInjection.Classes;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            // The followind is using the constructor injection method
            // Builder builder = new Builder(hammer);


// The followind is using the setter inejection method
            Builder2 builder2 = new Builder2();
            builder2.Tool = hammer; // Property injection
            builder2.useTheGiven();

            Console.ReadLine();
        }
    }
}