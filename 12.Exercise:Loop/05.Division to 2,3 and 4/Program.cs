//Write a program to find statistics about division to 2, 3 and 4:

//· Read an integer number N and N integers from the console

//· Find in percentages how many of these integers can divide without a remainder to numbers 2, 3 and 4

//· Print the percentages, formatted to the second decimal digit:

//o On the first line print percent of the numbers that are divisible by 2

//o On the first line print percent of the numbers that are divisible by 3

//o On the first line print percent of the numbers that are divisible by 4

int n = int.Parse(Console.ReadLine());
int divideBy2 = 0;
int divideBy3 = 0;
int divideBy4 = 0;

for (int i = 0; i < n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());
    if (currentNum % 2 == 0)
    {
        divideBy2++;
    }
    if (currentNum % 3 == 0)
    {
        divideBy3++;
    }
    if (currentNum % 4 == 0)
    {
        divideBy4++;
    }
}

double percentBy2 = (double)divideBy2 / n * 100;
double percentBy3 = (double)divideBy3 / n * 100;
double percentBy4 = (double)divideBy4 / n * 100;

Console.WriteLine($"{percentBy2:F2}%");
Console.WriteLine($"{percentBy3:F2}%");
Console.WriteLine($"{percentBy4:F2}%");