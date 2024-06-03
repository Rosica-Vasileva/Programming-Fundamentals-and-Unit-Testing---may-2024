

string product = Console.ReadLine();

if(product=="curry" || product=="noodles" || product=="bread" || product=="sushi" || product == "spaghetti")
{
    Console.WriteLine("Food");
}
else if (product=="tea" || product=="coffee" || product=="water" || product == "juice")
{
    Console.WriteLine("Drink");
}
else
{
    Console.WriteLine("unknown");
}