using System;
using System.Linq;

namespace Hwork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // n1
            /* Console.Write("Enter the size of the array: ");
             int arraysize = int.Parse(Console.ReadLine());

             int[] arr = new int[arraysize];
             Console.WriteLine("enter the numbers: ");
             for (int i = 0; i < arraysize; i++)
             {
                 arr[i] = int.Parse(Console.ReadLine());
             }
             int[] oddArr = new int[arraysize];
             int oddCount = 0;

             int[] evenArr = new int[arraysize];
             int evenCount = 0;
             for (int i = 0; i < arraysize; i++)
             {
                 if (arr[i] % 2 == 0)
                 {
                     evenArr[evenCount] = arr[i];
                     evenCount++;
                 }
                 else
                 {
                     oddArr[oddCount] = arr[i];
                     oddCount++;
                 }
             }
                 Console.WriteLine("evens: ");
                 for ( int j = 0; j < evenCount; j++)
                 {
                     Console.WriteLine(evenArr[j]);
                 }
                 Console.WriteLine("odds: ");
                 for ( int k = 0; k < oddCount; k++)
                 {
                     Console.WriteLine(oddArr[k]);
                 }
            */
            // n2

            /*
            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] elements = new int[n];
            Console.Write("Enter the elements of the array, separated by spaces: ");
            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                elements[i] = int.Parse(input[i]);
            }

            var elementCounts = elements.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            int sum = elementCounts.Values.Sum();

            Console.WriteLine("Element Counts:");
            foreach (var kvp in elementCounts)
            {
                Console.WriteLine($"{kvp.Key} appears {kvp.Value} time(s) sum {kvp.Key * kvp.Value}");
            }

            Console.WriteLine($"Total sum: {sum}");

            */

            // n3
            /*
            Console.Write("Enter the list of scores, separated by spaces: ");
            int[] scores = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.Write("Enter the number of top participants to display: ");
            int n = int.Parse(Console.ReadLine());

            var topParticipants = scores.OrderByDescending(x => x).Take(n);

            Console.WriteLine("Top Participants:");
            foreach (int score in topParticipants)
            {
                Console.Write(score + " ");

            }
            */

        }

    }
}
