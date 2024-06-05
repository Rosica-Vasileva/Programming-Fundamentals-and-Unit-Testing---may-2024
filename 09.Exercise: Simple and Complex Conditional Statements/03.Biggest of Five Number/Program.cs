//Write a program to find the biggest among 5 numbers:
//Reads 5 integer numbers from the console
//Print the biggest number from the given five

//INPUT

int one = int.Parse(Console.ReadLine());
int two = int.Parse(Console.ReadLine());
int three = int.Parse(Console.ReadLine());
int foure = int.Parse(Console.ReadLine());
int five = int.Parse(Console.ReadLine());

//CALCULATE

if (one > two && one >three && one >foure && one > five)
{
    Console.WriteLine($"{one}");
}

else if (one < two && two >three && two >foure && two > five)
{
    Console.WriteLine($"{two}");
}
else if (one < three && two < three && three > foure && three > five)
{
    Console.WriteLine($"{three}");
}
else if (one < foure && two < foure && three < foure && foure > five)
{
    Console.WriteLine($"{foure}");
}
else if (one < five && two < five && five > foure && three < five)
{
    Console.WriteLine($"{five}");
}

