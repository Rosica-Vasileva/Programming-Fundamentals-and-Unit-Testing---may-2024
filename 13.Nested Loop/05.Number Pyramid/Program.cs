//Write a program that:

//· Reads an integer number n from the console

//· Prints a pyramid of numbers as shown in the examples

int n = int.Parse(Console.ReadLine());
int currentNumber = 1;

for(int row = 1; currentNumber <= n; row++)
{
    for(int col=1;col<=row && currentNumber <= n; col++)
    {
        Console.Write($"{currentNumber} ");
        currentNumber++;
    }
    Console.WriteLine();
}