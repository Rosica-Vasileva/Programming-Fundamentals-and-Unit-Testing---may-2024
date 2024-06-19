
//Write a program to sum N vowels, according to the table below:

//· Read an integer number N: the count of characters

//· Read N characters and for each vowel character adds its value from the table to the result

int n= int.Parse(Console.ReadLine());
int sum = 0;

for(int i = 0; i < n; i++)
{
    char letter = char.Parse(Console.ReadLine());
    switch (letter)
    {
        case 'a':
            sum += 1;
            break;
            case 'e':
            sum += 2;
            break;
            case 'i':
            sum += 3;
            break;
            case 'o':
            sum += 4;
            break;
            case 'u':
            sum += 5;
            break;

    }
}
Console.WriteLine(sum);