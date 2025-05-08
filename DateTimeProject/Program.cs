using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2025,07,22);
            DateTime dateTime2 = new DateTime(1995, 07, 22);

            Console.WriteLine("My Birthday is {0}", dateTime2);

            
            System.Console.WriteLine(DateTime.Now);
            System.Console.WriteLine(DateTime.Today);
            System.Console.WriteLine(GetTomorrow());
            System.Console.WriteLine(DateTime.Today.DayOfWeek);

            var days = new DateTime(2025, 07, 22).Subtract(new DateTime(1995, 07, 22));
            Console.WriteLine($"Days lived:{days.Days}" );


            GetFirstDayOfYear(2026);
            TimeSpan dateLived = dateTime - dateTime2;
            Console.WriteLine("Original DateTime: " + dateLived);


            var timeSpan = getTimeSpan();
            Console.WriteLine("Time Span: " + timeSpan.Days);
        }   



        static DateTime GetFirstDayOfYear(int year)
        {      

            // System.Console.WriteLine(new DateTime(year, 1, 1).DayOfWeek);
            return new DateTime(year, 1, 1);
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }


        static TimeSpan getTimeSpan(){
            System.Console.WriteLine("Enter a time in the format yyyy:mm:dd");
            var userInput =  Console.ReadLine();
            var timeEntered = DateTime.TryParse(userInput, out DateTime dateTime);
            return DateTime.Now - dateTime;
        }
    }
}