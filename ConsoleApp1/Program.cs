using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{    internal class Program
    {

        int result;
        static void Main()
        {

           int myResult;
           int myResult2;

        
            myResult = AddTwoValues(1,1);


            double myresult = 10.0/8;
            System.Console.WriteLine(myresult);

        }

        static int AddTwoValues(int numb1, int numb2){
            return numb1 + numb2;
        }


        static int subtractTwoValues(int num1, int num2){
            return num1 = num2;

        }

       
    }
}