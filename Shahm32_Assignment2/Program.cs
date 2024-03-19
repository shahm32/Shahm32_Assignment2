using System;

class Program
{
    static void Main()
    {
        // Initialize variables to store sums of even and odd numbers
        int sumEven = 0;
        int sumOdd = 0;

        // Loop through numbers 0-9
        for (int num = 0; num < 10; num++)
        {
            // Check if the number is even or odd
            bool isEven = num % 2 == 0;

            if (isEven)
            {
                Console.WriteLine($"{num} is an even number");
                // Add even number to the sumEven variable
                sumEven += num;
            }
            else
            {
                Console.WriteLine($"{num} is an odd number");
                // Add odd number to the sumOdd variable
                sumOdd += num;
            }
        }

        // Output the sum of even and odd numbers
        Console.WriteLine($"Total of even numbers: {sumEven}");
        Console.WriteLine($"Total of odd numbers: {sumOdd}");
    }
}