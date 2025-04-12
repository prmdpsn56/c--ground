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
                    Console.WriteLine("Message from DerivedClass2");
                }
            }
}