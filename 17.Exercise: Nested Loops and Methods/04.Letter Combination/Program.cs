//Write a program to generate 3-letter combinations under certain conditions:

//· Read a start letter s, end letter e and excluded letter x

//· Generate all combinations of 3 letters in the range [s…e], excluding x

//· Print all combinations on the first line

//· Print combinations count on the second line

using System;

class Program
{
    static void Main()
    {
        char startLetter = char.Parse(Console.ReadLine());
        char endLetter = char.Parse(Console.ReadLine());
        char excludedLetter = char.Parse(Console.ReadLine());

        int count = 0;

        for (char i = startLetter; i <= endLetter; i++)
        {
            if (i == excludedLetter)
                continue;

            for (char j = startLetter; j <= endLetter; j++)
            {
                if (j == excludedLetter)
                    continue;

                for (char k = startLetter; k <= endLetter; k++)
                {
                    if (k == excludedLetter)
                        continue;

                    Console.Write($"{i}{j}{k} ");
                    count++;
                }
            }
        }

        Console.WriteLine(); // Нов ред след комбинациите
        Console.WriteLine(count); // Извеждане на броя на комбинациите
    }
}


