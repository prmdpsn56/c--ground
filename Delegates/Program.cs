using System;

namespace MyApp
{

    public delegate void LogHandler(string message);

    public class Logger
    {
        // Declare a delegate that takes a string and returns void
        public delegate void LogDelegate(string message);

        // Method to log to console
        public void LogToConsole(string message)
        {
            Console.WriteLine($"Console Log: {message}");
        }

        // Method to log to file (simulated here)
        public void LogToFile(string message)
        {
            Console.WriteLine($"File Log: {message}");
        }
    }


    internal class Program
    {   

        //Declaration
        // Define a delegate that takes a string and returns void   
        // and another delegate that takes an int and returns an int
        public delegate void Notify(string message);


        static void Main(string[] args)
        {

        //Initialize
        Notify notifyDelegate = NotifyUser;
        //Invocation
        notifyDelegate("Hello from the delegate!");


        Logger logger = new Logger();
        // Create instances of the delegate
        LogHandler consoleLog = logger.LogToConsole;
        LogHandler fileLog = logger.LogToFile;

        consoleLog("This is a message to the console.");
        fileLog("This is a message to the file.");

      
        }

        static void NotifyUser(string message)
        {
            Console.WriteLine(message);
        }
    }
}