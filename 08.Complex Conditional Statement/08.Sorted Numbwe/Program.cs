

//Write a program, which checks for sorted 3 numbers:
//Reads 3 integer numbers from the console
//Based on the order of the numbers, print:
//"Ascending" – if the numbers are in ascending order (from the smallest to the largest number)
//"Descending" – if the numbers are in descending order (from the largest to the smallest number)
//"Not sorted" – in any other case

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

bool isAsending = a < b && b < c;
bool isDesending = a > b && b > c;

if (isAsending)
{
    Console.WriteLine("Ascending");
}
else if (isDesending)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}