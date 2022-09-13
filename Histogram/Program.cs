using System;
using System.Collections.Generic;
using System.Linq;

namespace Histogram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var myArray = new int[] { 1, 2, 1, 3, 3, 1, 2, 1, 5, 1 };
            var histogram = GetHistogram(myArray);
            PrintHistogram(histogram);
        }

        private static List<int> GetHistogram(int[] myArray)
        {
            var histogram = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                histogram.Add(myArray.Where(x => x.Equals(i)).Count());
            }

            return histogram;
        }

        private static void PrintHistogram(List<int> histogram)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}: {new string('*', histogram[i - 1])}");
            }
        }
    }
}