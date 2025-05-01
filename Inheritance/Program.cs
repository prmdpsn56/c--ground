using System;

namespace MyApp
{
        internal class Program
        {
        
            static void Main(string[] args)
            {
                // Dog animal = new Dog();
                // animal.Bark();

    //Using the method Hiding technique
    Console.WriteLine("--------Method Hiding---------");

                BaseClass baseClass = new BaseClass();
                baseClass.ShowMessage();  //Message from BaseClass
                
                DerivedClass derivedClass = new DerivedClass();
                derivedClass.ShowMessage();  //Message from DerivedClass
                
                BaseClass derivedButStoredInbase = new DerivedClass();
                derivedButStoredInbase.ShowMessage();  //Message from BaseClass

    //Using the override method
            Console.WriteLine("--------override method---------");

                BaseClass2 baseClass2 = new BaseClass2();
                baseClass2.ShowMessage2();  //Message from BaseClass
                
                DerivedClass2 derivedClass2 = new DerivedClass2();
                derivedClass2.ShowMessage2();  //Message from DerivedClass
                
                BaseClass2 derivedButStoredInbase2 = new DerivedClass2();
                derivedButStoredInbase2.ShowMessage2();  //Message from BaseClass


                //Constructor Inheritance
                Console.WriteLine("--------Constructor Inheritance---------");
                Employee employee = new Employee("John Doe", "30", "E12345");
                employee.DisplayInfo(); // Output: Name: John Doe, Age: 30, Employee ID: E12345

            }
        }

        class Animal {
            
            public void Eat(){
                Console.WriteLine("Eating...!!");
            }
        }


        class Dog: Animal {
            public void Bark() {
                Console.WriteLine("Barking...!!");
            }
        }

        class BaseClass
            {
                public void ShowMessage()
                {
                    Console.WriteLine("Message from BaseClass");
                }
            }
            
        class DerivedClass : BaseClass
            {
                public new void ShowMessage()
                {
                    Console.WriteLine("Message from DerivedClass");
                }
            }

        class BaseClass2
        {
         public virtual void  ShowMessage2()
            {
                Console.WriteLine("Message from BaseClass2");
            }
        }

        class DerivedClass2 : BaseClass2
            {
                public override void ShowMessage2()
                {
                    var info = new List<string> ();
                    info = ["DerivedClass2", "DerivedClass2"];
                    Console.WriteLine("Message from DerivedClass2");
                }
            }

        //constructor Inheritance

        class Person
        { 
            public string Name { get; private set; }
            public string Age { get; private set; }
            public Person(string name, string age)
            {
                Name = name;
                Age = age;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age} from parent class");
            }
        }

        class Employee : Person
        {
            public string EmployeeId { get; private set; }
            public Employee(string name, string age, string employeeId) : base(name, age)
            {
                EmployeeId = employeeId;
            }

            public new void DisplayInfo()
            {   
                base.DisplayInfo(); // Call the base class method
                Console.WriteLine($"Name: {Name}, Age: {Age}, Employee ID: {EmployeeId} from child class");
            }
        }


}