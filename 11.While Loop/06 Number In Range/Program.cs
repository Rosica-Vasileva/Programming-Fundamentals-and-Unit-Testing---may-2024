//Write a program to read a number in the range [1 … 100]:

//· Read an integer number from the console

//· Check if the number is in the range [1 … 100]

//o No(number is NOT in the range) à read a new number

//o Yes(number is IN the range) à print the number and the program stops

int num = int.Parse(Console.ReadLine());

while (num <= 1 || num >= 100)
{
    num = int.Parse(Console.ReadLine());
}

Console.WriteLine(num);