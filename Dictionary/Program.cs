using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(1,"Param");
            employees.Add(2,"John");
            employees.Add(3,"Mohn");
            employees.Add(4,"Ram");

//get
            string name = employees[1];
            // System.Console.WriteLine(name);

//set       
            employees[2] = "Singh";
            // System.Console.WriteLine(name);

//remove    
            employees.Remove(1);

//for loop
            foreach (KeyValuePair<int,string> item in employees)
            {
                System.Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }
    }
}