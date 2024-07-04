using System;

public class Program
{
    public static void Main()
    {
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            int factorialSum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                number /= 10;
                if (currentDigit % 2 == 0)
                {
                    factorialSum += Factorial(currentDigit);
                }
            }
            
            Console.WriteLine(factorialSum);
        }
        
       
    }

    // Factorial method does not need to be public, private is sufficient
    private static int Factorial(int n)
    {
        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
