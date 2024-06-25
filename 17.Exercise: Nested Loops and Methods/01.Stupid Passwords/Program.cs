//Write a program that:

//· Reads an integer number N from the console

//· Generates all possible passwords consisting of the following 3 parts:

//o The first part is an even number in the range [2…N]

//o The second digit is an odd number in the range [1…N]

//o The third is the product of the first two

//· The output holds all possible passwords


int n = int.Parse(Console.ReadLine());

for (int i = 2; i <= n; i += 2)
{
     for(int j = 1; j <= n; j += 2)
    {
        int t = i * j;
        Console.Write($"{i}{j}{t} ");
    }
}