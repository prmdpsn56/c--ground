using System;
using DependencyInjection.interfaces;

namespace DependencyInjection.classes;

public class Hammer:ITool
{


    public void useTool()
    {
        Console.WriteLine("Hammer is used.");
    }
  
}
