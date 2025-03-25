namespace Coding.Exercise
{
   public class Program
    {
        public static void CalculateAverage()
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int average = (num1 + num2 + num3) / 3;
            Console.WriteLine("The average is: \n " + average);
            System.Console.WriteLine("Hello \n \t world");
        }

        public static void Main()
        {
            CalculateAverage(); // Directly calling without an instance
        }
    }
}
