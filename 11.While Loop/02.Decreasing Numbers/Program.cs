//Write a program that:
//· Reads an integer number N
//· Print the numbers from N down to 1 (inclusively), each on separate line
//Note: N will always be bigger than 1.

//int i =int.Parse(Console.ReadLine());
//for (int i = n; 1 >= 1; i--;){
//Console.WriteLine(i);}

int n = int.Parse(Console.ReadLine());
while (n >= 1)
{
    Console.WriteLine(n);
    n--;
}