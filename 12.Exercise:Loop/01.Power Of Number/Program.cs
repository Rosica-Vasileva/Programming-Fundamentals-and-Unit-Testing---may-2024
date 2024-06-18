//Write a program to calculate number raising to a certain power:

//· Reads an integer number n from the console

//· Reads an integer number p which represents power from the console

//· Print the result of n to the power of p


int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int sum = 1;

for(int i = 0; i < p; i++)
{
    sum = sum * n;
}

Console.WriteLine(sum);