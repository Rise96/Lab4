using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = {18,2,7,9,3,5,8,2,3 };
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write($"{arrayOfNumbers[i]} ");
            }
            Console.WriteLine(" ");
            ProcessingOfTheMassive processor = new ProcessingOfTheMassive();
            int[] arrayOfNumbers2 = processor.FindSumClosestToMaxNumber(arrayOfNumbers);
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write($"{arrayOfNumbers2[i]} ");
            }
            Console.ReadLine();
        }
    }
}
