//Write a program to enter an odd number:

//· Read numbers from the console until an odd number is entered

//· Print the odd number as output

int n = int.Parse(Console.ReadLine());

while (n % 2 == 0)
{
    n = int.Parse(Console.ReadLine());
}

Console.WriteLine(n);


