
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Read the initial list of integers
        List<int> numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToList();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            // Split the command and process accordingly
            string[] commandParts = command.Split();
            string action = commandParts[0];

            switch (action)
            {
                case "Contains":
                    int numberToFind = int.Parse(commandParts[1]);
                    if (numbers.Contains(numberToFind))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;

                case "PrintEven":
                    List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
                    Console.WriteLine(string.Join(" ", evenNumbers));
                    break;

                case "PrintOdd":
                    List<int> oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
                    Console.WriteLine(string.Join(" ", oddNumbers));
                    break;

                case "GetSum":
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                    break;

                case "Filter":
                    string condition = commandParts[1];
                    int conditionNumber = int.Parse(commandParts[2]);
                    List<int> filteredNumbers = numbers.Where(n =>
                    {
                        switch (condition)
                        {
                            case "<":
                                return n < conditionNumber;
                            case ">":
                                return n > conditionNumber;
                            case "<=":
                                return n <= conditionNumber;
                            case ">=":
                                return n >= conditionNumber;
                            default:
                                return false;
                        }
                    }).ToList();
                    numbers = filteredNumbers;
                    break;
            }
        }

        // Print the final state of the list
        Console.WriteLine(string.Join(" ", numbers));
    }
}



