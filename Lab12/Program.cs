/*
 * Student ID : 1690704711
 * Name       : ปรมัตถ์ รักศรี
 * Section    : 129D
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 3, 40, 8, 15, 22 };

            int sum;
            float average;
            int maximum;
            int minimum;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number " + (i + 1) + ": " + numbers[i]);
            }

            sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            average = (float)sum / numbers.Length;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);

            maximum = numbers[0];
            minimum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }

            Console.WriteLine("Maximum: " + maximum);
            Console.WriteLine("Minimum: " + minimum);

  
            Array.Sort(numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine("Sorted: " + n);
            }
        }
    }
}