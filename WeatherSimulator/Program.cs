using System;

namespace MyApp


{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter the number of days to simulate");
            int days = int.Parse(Console.ReadLine());

            double[] temprature = new double[days];
            string[] weatherCondition = new string[days];
            string [] conditions = {"sunny","rainy","cloudy","snowy"};

            Random random = new Random();


            for (int i  = 0; i  < days; i ++)
            {

             temprature[i] = random.Next(-10,40);
             weatherCondition[i] = conditions[random.Next(conditions.Length)];

            }

            Program.CalculateAverage(temprature);
            Program.FindMostCommonCondition(weatherCondition);
            Console.ReadKey();
        }


        static double CalculateAverage(double[] temprature){
            double sumAverage = 0;
             foreach (var item in temprature)
            {
                sumAverage+= item;
            }
            sumAverage = sumAverage/temprature.Length;

            System.Console.WriteLine("average temprature is " + sumAverage);
            System.Console.WriteLine("max temprature is " + temprature.Max());
            System.Console.WriteLine("Min temprature is " + temprature.Min());
            Program.findLowest(temprature);
           
            return sumAverage;
        }


        static void FindMostCommonCondition(string[] conditions) 
        {
            Dictionary<string, int> conditionsCount = new Dictionary<string, int>();

            foreach (var condition in conditions)
            {
                if (conditionsCount.ContainsKey(condition))
                {
                    conditionsCount[condition]++;
                }
                else
                {
                    conditionsCount[condition] = 1; // Initialize count for new condition
                }
            }

            // Print the dictionary
            foreach (var condition in conditionsCount)
            {
                Console.WriteLine(condition.Key + ": " + condition.Value);
            }

    
            var mostCommon = conditionsCount.OrderByDescending(x => x.Value).First();
            Console.WriteLine($"Most Common Condition: {mostCommon.Key} ({mostCommon.Value} times)");
}

        static void findLowest(double[] temprature){
                double lowest = temprature[0];

            foreach (var item in temprature)
            {   
                if (item < lowest){
                    lowest = item;
                }
            }

            System.Console.WriteLine("Min temprature from custom method is " + lowest);
        }
    }
}