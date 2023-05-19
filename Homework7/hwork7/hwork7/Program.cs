using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hwork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            // Calculate the side length of the large square
            double largeSquareSide = 2 * radius;

            // Calculate the area of the large square
            double largeSquareArea = largeSquareSide * largeSquareSide;

            // Calculate the side length of the small square
            double smallSquareSide = radius * Math.Sqrt(2);

            // Calculate the area of the small square
            double smallSquareArea = smallSquareSide * smallSquareSide;

            // Calculate the difference between the areas
            double difference = largeSquareArea - smallSquareArea;

            Console.WriteLine("Difference between the large square and the small square: " + difference);

            

            // n2

            Console.WriteLine("Enter the symbols separated by commas: ");
            string[] symbols = Console.ReadLine().Split(',');

            bool hasWonJackpot = symbols.All(s => s == symbols[0]);

            if (hasWonJackpot)
            {
                Console.WriteLine("Yes, you won the jackpot!");
            }
            else
            {
                Console.WriteLine("No, you did not win the jackpot.");
            }
            

            // n3
            Dictionary<string, int> footballteam = new Dictionary<string, int>();
            const int victorypoints = 3;
            const int drawpoints = 1;
            const int defeatpoints = 0;
            const string victory = "victory";
            const string draw = "draw";
            const string loss = "loss";
            footballteam.Add(victory, 2);
            footballteam.Add(draw, 1);
            footballteam.Add(loss, 0);

            var totalscore = (footballteam[victory] * victorypoints) + (footballteam[draw] * drawpoints) + (footballteam[loss] * defeatpoints);

            Console.WriteLine("total team score is: " + totalscore);
            
            // n5 
            
            Console.WriteLine("Enter the number of hours worked each day separated by commas: ");
            string[] hoursWorked = Console.ReadLine().Split(',');

            int[] dailyHours = Array.ConvertAll(hoursWorked, int.Parse);

            int hourlyRate = 10;
            int overtimeRate = 5;
            int weekendRate = 2;
            int totalIncome = 0;

            for (int i = 0; i < dailyHours.Length; i++)
            {
                int dailyIncome = 0;

                if (dailyHours[i] > 8)
                {
                    dailyIncome += 8 * hourlyRate + (dailyHours[i] - 8) * (hourlyRate + overtimeRate);
                }
                else
                {
                    dailyIncome += dailyHours[i] * hourlyRate;
                }

                if (i == 5 || i == 6)
                {
                    dailyIncome *= weekendRate;
                }

                totalIncome += dailyIncome;
            
            Console.WriteLine($"Income of employee 1 during the week: {totalIncome}");
            }
            
            
            //5
         
                int[] performance = { 5, 8, 8, 9, 10 };

                int numImprovements = performance.Zip(performance.Skip(1), (current, previous) => current > previous ? 1 : 0).Sum();

                Console.WriteLine($"George improved his performance on {numImprovements} days.");



                


                // n6

                string[] array = { "hello", "world", "programming", "communication", };

                Console.WriteLine("enter the length of the element: ");
                int length = int.Parse(Console.ReadLine());

                var matchingElements = array.Where(element => element.Length == length);

                if (matchingElements.Any())
                {
                    foreach ( string element in matchingElements )
                    {
                        Console.WriteLine(element);

                    }
                }
                else
                {
                    Console.WriteLine("no elements found");

                }
                */
            
        }


    }
        
    
}
