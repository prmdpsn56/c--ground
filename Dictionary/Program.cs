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

//adding at an existing item.
            employees.Add(1,"John Doe");
            //we will get a runtime error when we try to add at the same place, we can just update based on if there is a value already or not.
            if(!employees.ContainsKey(1)){
                employees.Add(1,"John doe");
            }

            var counter = 101;
            while (!employees.ContainsKey(counter))
            {
                counter++;
            }
            employees.Add(counter,"Jesus christ");
            
//remove    
            // employees.Remove(1);

//for loop
            foreach (KeyValuePair<int,string> item in employees)
            {
                System.Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }
    }
}