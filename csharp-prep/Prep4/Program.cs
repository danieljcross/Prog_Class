using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Declare variables
        int num = -1;
        List<int> nums = [];

        // Opening line
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        // Input numbers loop
        while (num != 0){
        Console.Write("Enter number: ");
        num = int.Parse(Console.ReadLine());
        if (num != 0){
        nums.Add(num);
        };
        }

        // Calculations
        int total = 0;
        int largest = 0;
        foreach (int number in nums){
            total += number;
            if (number > largest){
                largest = number;
            }
        }
        float avg = total / nums.Count;

        // Display answers
        Console.WriteLine($"Total: {total}\nAverage: {Math.Round(avg,2)}\nLargest: {largest}");

    }
}