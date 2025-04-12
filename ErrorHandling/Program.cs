
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("Please enter a number");
            //     var num1 = 10;
            //     var num2 = int.Parse(Console.ReadLine());
            //     var result = num1/num2;
            //     System.Console.WriteLine(result);
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            //     Debug.WriteLine(ex.StackTrace);
            // }
            // finally {
            //     System.Console.WriteLine("this always executed");
            // }
            try
            {
                GetUserAge();
            }
            catch (System.Exception ex) 
            {
                System.Console.WriteLine(ex.Message);
                throw;
            }


        }

        public static void GetUserAge(){
            System.Console.WriteLine("Please enter your age.");
            var userEntry = Console.ReadLine();
            int response;
            var result = int.TryParse(userEntry,out response);
            System.Console.Write("response : ",response);
            if (!result)
            {
                throw new Exception("You did not enter the correct value");
            };

            if(response < 0 || response > 120){
                throw new Exception("your age must be betwenn 0 and 120");
            }
            System.Console.WriteLine(response);
        }
    }
}