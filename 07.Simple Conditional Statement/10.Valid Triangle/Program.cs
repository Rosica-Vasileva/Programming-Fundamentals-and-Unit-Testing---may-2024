

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a >= b + c)
{
    Console.WriteLine("Invalid Traingle");
}

else if (b>=a+c)
{
    Console.WriteLine("Invalid Tringle");
}       

else if (c>=a+b)
{
    Console.WriteLine("Invalid Tringle");
}

else
{
    Console.WriteLine("Valid Tringle");
}