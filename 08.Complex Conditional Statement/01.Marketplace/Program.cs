

//INPUT 
//product and day , print the price 

string product = Console.ReadLine();
string day = Console.ReadLine();
decimal price = 0;

if (product == "Banana")
{
    if (day == "Weekday")
    {
        Console.WriteLine($"{2.50:F2}");
    }
    else if (day == "Weekend")
    {
        Console.WriteLine($"{2.70:F2}");
    }
}

else if (product == "Apple")
{
    if (day == "Weekday")
    {
        Console.WriteLine($"{1.30:F2}");
    }
    else if (day == "Weekend")
    {
        Console.WriteLine($"{1.60:F2}");
    }

}
else if (product == "Kiwi")
{
    if (day == "Weekday")
    {
        Console.WriteLine($"{2.20:F2}");
    }
    else if (day == "Weekend")
    {
        Console.WriteLine($"{3.30:F2}");
    }
}
