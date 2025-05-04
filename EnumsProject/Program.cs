using System;
using EnumsProject.enums;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sunday); // Output: Sunday
            Console.WriteLine((int)Days.Sunday); // Output: 1
        }
    }
}