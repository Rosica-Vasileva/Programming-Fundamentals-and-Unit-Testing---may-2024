//Write a program to find the biggest among given n numbers:

//· Read an integer number n (the amount of input numbers) and n integer numbers from the console

//· Find and print the biggest number

int n = int.Parse(Console.ReadLine());
int biggestNumber = int.MinValue;

for (int i = 0; i < n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());
    if (currentNum > biggestNumber)
    {
        biggestNumber = currentNum;

    }
}

Console.WriteLine(biggestNumber);