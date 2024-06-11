//Write a program that prints numbers ending in 7 in given range:
//Reads an integer number n – end of the range
//Prints all numbers from 7 to n, ending in 7

//INPUT
int n = int.Parse(Console.ReadLine());
//ACT
for (int i = 7; i <= n; i += 10)
{   //OUTPUT
    Console.WriteLine(i);
}
