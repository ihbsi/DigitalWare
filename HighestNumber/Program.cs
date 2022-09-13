using System;

namespace HighestNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var myArray = new int[5];
            for (int i = 0; i < myArray.Length; i++)
            {
                AddNumberIntoArray(myArray, i);
            }

            var highestNumber = GetHighestNumber(myArray);
            Console.WriteLine($"\nEl número mayor es: {highestNumber}");
        }

        private static void AddNumberIntoArray(int[] myArray, int i)
        {
            try
            {
                Console.WriteLine($"Ingresa un número para la posición {i + 1}:");
                var num = Convert.ToInt32(Console.ReadLine());
                if (!IsNumberValid(num))
                {
                    AddNumberIntoArray(myArray, i);
                    return;
                }
                myArray[i] = num;
            }
            catch (Exception)
            {
                Console.WriteLine("Debe digitar un número.");
                AddNumberIntoArray(myArray, i);
            }
        }

        private static int GetHighestNumber(int[] myArray)
        {
            var highestNumber = myArray[0];
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i] < myArray[i + 1])
                {
                    highestNumber = myArray[i + 1];
                }
            }
            return highestNumber;
        }

        private static bool IsNumberValid(int num)
        {
            if (num < 1 || num > 100)
            {
                Console.WriteLine("El número digitado debe estar entre 1 y 100.");
                return false;
            }
            return true;
        }
    }
}