using System;

namespace MyApp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dog animal = new Dog();
            animal.Bark();
        }
    }

    class Animal {

        public string _publicField;
        public string PublicFields { get; set; }
        private string PrivateFields { get; set; }
        protected string ProtectedFields { get; set; }
        
        public void Eat(){
            Console.WriteLine("Eating...!!");
        }
    }


    class Dog: Animal {
        public void Bark() {
            Console.WriteLine("Barking...!!");
            PublicFields = "Woff!!";
            _publicField = "woff again!!";
            Console.Write(PublicFields+_publicField);

        }
    }
}