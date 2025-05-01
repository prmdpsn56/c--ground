using System;

namespace Interface.classes;

public class Cat: IAnimal
{
    public void Eat()
    {
        Console.WriteLine("Cat is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("Cat is sleeping.");
    }

    public void Speak()
    {
        Console.WriteLine("Cat says meow.");
    }
}
