//Write a program that:

//· Reads an integer number N from the console

//· Find all 3-digit magic numbers

//Note: A magic number is a three-digit number where the product of its digits equals the value of N.
//    If you have a three-digit number abc, where a, b and c are its digits,
//    it is considered a magic number of order N, if a * b * c = N.


int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    for(int j = 1; j <= n; j++)
    {
        for (int k = 1; k <= n; k++)
        {
            if (i >= 10 || j>=10 || k >= 10)
            {
                continue;
            }

            int product = i * j * k;

            if (product == n)
            {
                Console.Write($"{i}{j}{k} ");
            }
        }
    }
}