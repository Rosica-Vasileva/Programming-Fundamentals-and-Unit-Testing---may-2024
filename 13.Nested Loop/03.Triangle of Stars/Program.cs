//Write a program to print a triangle of stars like shown in the examples:

//· Read the size (integer number) of a triangle from the console

//· Print a triangle of stars


int size = int.Parse(Console.ReadLine());

for (int row = 1; row <= size; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

