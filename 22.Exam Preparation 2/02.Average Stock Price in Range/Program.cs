using System;
namespace StockePriceInRange
{
    public class Program
{
    public static void Main()
    {
        int[] stockPrices = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

        int startIndex = int.Parse(Console.ReadLine());
        int endIndex = int.Parse(Console.ReadLine());

        if (startIndex < 0 || endIndex >= stockPrices.Length || startIndex > endIndex)
        {
            Console.WriteLine("Invalid index range.");
            return;
        }

        double sum = 0;
        int count = 0;
        for (int i = startIndex; i <= endIndex; i++)
        {
            sum += stockPrices[i];
            count++;
        }


        if (count == 0)
        {
            Console.WriteLine("No elements in the selected range.");
            return;
        }

        double average = sum / count;


        Console.WriteLine(average.ToString("F2"));

    }
}
}

