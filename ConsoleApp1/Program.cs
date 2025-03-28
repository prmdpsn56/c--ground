using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{    internal class Program
    {
        static void Main()
        {

           int myResult;
           int myResult2;

            Program programClassInstance = new Program();
            myResult2 = programClassInstance.subtractTwoValues(20,10);
            myResult = AddTwoValues(1,1);

             System.Console.WriteLine(myResult);
             System.Console.WriteLine(myResult2);
          
        }

        static int AddTwoValues(int numb1, int numb2){
            return numb1 + numb2;
        }


        public int subtractTwoValues(int num1, int num2){
            return num1 = num2;

        }
    }
}