//Input  Output     Input  Output     Input  Output
//2      positive   -1     negative   0      zero

int number = int.Parse(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("negative");
}

else if (number > 0)
{
    Console.WriteLine("positive");   
}

else //(number=0)
{
    Console.WriteLine("zero");
}