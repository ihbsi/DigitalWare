using System;

namespace SumArrayValues
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var myArray = new int[] { 1, 8, 6, 7, 2, 5 };
            ValidateSum(myArray);
        }

        private static bool IsNumbersFound(int firstValue, int secondValue)
        {
            var sum = firstValue + secondValue;
            if (sum.Equals(10))
            {
                Console.WriteLine($"{firstValue} {secondValue}");
                return true;
            }
            return false;
        }

        private static void ValidateSum(int[] myArray)
        {
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    if (IsNumbersFound(myArray[i], myArray[j]))
                    {
                        return;
                    }
                }
            }
            Console.WriteLine("No se encontraron números válidos.");
        }
    }
}