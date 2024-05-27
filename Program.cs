using System;
using System.IO;

namespace Lab_0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter the low number
            Console.Write("Enter the LOW NUMBER:");
            int lowNumber = int.Parse(Console.ReadLine());

            // Prompt user to enter the high number
            Console.Write("Enter the high number:");
            int highNumber = int.Parse(Console.ReadLine());

            //Calculate and print the difference
            int difference = highNumber - lowNumber;
            Console.WriteLine($"The difference between {highNumber} and {lowNumber} is {difference}.");
            
            // Loop until user enters a positvie low number
            do
            {
                Console.Write("Enter the positive low number: ");
                lowNumber = int.Parse(Console.ReadLine());
            } while (lowNumber <= 0);

            // Loop until user enters a high number greater than the low number
            do
            {
                Console.Write("Enter a high number greater than the low number: ");
                highNumber = int.Parse(Console.ReadLine());
            } while(highNumber <= lowNumber);

            // Create an array that holds every number between low and high
            int[] numbers = new int[highNumber - lowNumber + 1];
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = lowNumber + i;
            }

            // Write numbers to "numbers.txt" in reverse order
            using (StreamWriter writer = new StreamWriter("numbers.txt"))
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine(numbers[i]);
                }
            }
        }
    }
}
