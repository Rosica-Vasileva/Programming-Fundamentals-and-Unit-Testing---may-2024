//Write a program to check if given number is special:

//· Special numbers are divisible by all of their digits without remainder

//· Reads an integer number and check whether it is a special number

//· If the number IS special print: "{num} is special"

//· If the number is NOT special print: "{num} is not special"

//Note: There will not be numbers with digit 0 in them.

int n = int.Parse(Console.ReadLine());
int tempNum = n;
bool isSpecial = true;

while (tempNum > 0)
{
    int divisor = tempNum % 10;
    if (n % divisor != 0)
    {
        isSpecial = false;
        break;

    }
    tempNum /= 10;
}
if(isSpecial)
{
    Console.WriteLine($" {n} is special.");
}

else
{
    Console.WriteLine($" {n} is not special.");
}