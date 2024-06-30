using System.Collections.Generic;
using System.Globalization;

//Write a program that:

//· Reads a sequence with integer numbers from the console

//· Sums all numbers in a list in the following order:

//first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last – n

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        List<int> output = new List<int>();
        int iterations = numbers.Length / 2;

        for (int i = 0; i < iterations; i++)
        {
            int currentNum = numbers[i] + numbers[numbers.Length - 1 - i];
            output.Add(currentNum);
        }

        if (numbers.Length % 2 != 0)
        {
            int index = numbers.Length / 2;
            output.Add(numbers[index]);
        }

        Console.WriteLine(string.Join(" ", output));
    }
}
