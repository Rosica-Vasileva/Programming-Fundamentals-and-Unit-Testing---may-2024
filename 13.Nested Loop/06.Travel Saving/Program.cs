//Write a program that calculate the money collection for multiple travel destinations:
//· Read a destination (string) and needed budget (floating-point number) for the destination
//· Read many times amounts of collected money, until they are enough for the destination (starting from 0)
//o Print:
//"Collected: {sum}" where sum is formatted to 2nd digit
//or
//"Going to {destination}!"
//· Read another destination and budget and collect money again
//· A destination "End" ends the program


string destination = "";
while((destination=Console.ReadLine()) != "End")
{
    double moneyNeeded = double.Parse(Console.ReadLine());
    double sum = 0;
    while (moneyNeeded > sum)
    {
        double currentAmount = double.Parse(Console.ReadLine());
        sum += currentAmount;
        Console.WriteLine($"Collected:{sum:F2}");
    }
    Console.WriteLine($"Going to {destination}!");
}