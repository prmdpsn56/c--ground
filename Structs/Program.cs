using System;
using Structs.classes;
using Structs.structures;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InitialClass initialClass = new InitialClass();
            initialClass.Name = "John Doe from class";

            initialClass._nickName = "Johnny from class";
            Console.WriteLine($"Name: {initialClass.Name}, Nickname: {initialClass._nickName}");


            InitialClass initialClass2 = initialClass;
            initialClass2.Name = "Jane Smith from class";


            System.Console.WriteLine("------After Changing the name -------");

            System.Console.WriteLine($"Name: {initialClass.Name}, Nickname: {initialClass._nickName}");


            System.Console.WriteLine($"Name: {initialClass2.Name}, Nickname: {initialClass2._nickName}");

            bool isEqual = initialClass == initialClass2;
            System.Console.WriteLine($"Are the two classes equal? {isEqual}");

            System.Console.WriteLine("------Structures expalained below-------");


            Structures structures = new Structures();
            structures.Name = "John Doe";
            structures._nickName = "Janey";
            Console.WriteLine($"Name: {structures.Name}, Nickname: {structures._nickName}");

            Structures structures2 = structures;
            structures2.Name = "Jane Smith";

            Console.WriteLine("------After Changing the name -------");

            Console.WriteLine($"Name: {structures2.Name}, Nickname: {structures2._nickName}");


            Console.WriteLine("-------------");
            
            Console.WriteLine($"Name: {structures.Name}, Nickname: {structures._nickName}");

        }
    }
}