//Write a program to generate PIN codes following certain rules:

//· Read 3 integer digits: max1, max2, max3 (each is an upper limit)

//· Generate unique 3-digit PIN codes, matching the following:

//o Each digit is within the following range:

//ü First digit: [1 … max1]

//ü Second digit: [1 … max2]

//ü Third digit: [1 … max3]

//o The first and the third digit must be even

//o The second digit must be a prime number in the range [2…7]

//· Print the PIN codes, each on separate line


int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

for (int i = 1; i <= max1; i++)
{
    for (int j = 1; j <= max2; j++)
    {
        for (int k = 1; k <= max3; k++)
        {
            // Първата и третата цифра трябва да са четни
            if (i % 2 == 0 && k % 2 == 0)
            {
                // Втората цифра трябва да е просто число в диапазона [2…7]
                if (j == 2 || j == 3 || j == 5 || j == 7)
                {
                    Console.WriteLine($"{i}{j}{k}");
                }
            }
        }
    }
}
