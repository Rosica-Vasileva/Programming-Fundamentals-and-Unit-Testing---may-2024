//Write a program that:

//· Reads an integer number N from the console

//· Prints the numbers from N to 1, each on separate line

int n = int.Parse(Console.ReadLine());


while (n >= 1)
{
    Console.WriteLine(n);
    --n;
}
