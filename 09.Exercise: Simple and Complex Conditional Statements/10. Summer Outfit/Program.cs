//Summer weather can be quite unpredictable, and Victor needs your assistance. Write a program that, based on the time of day and the temperature, recommends to Victor what clothes to wear. Your friend has different plans for each stage of the day that require varied clothing, as indicated in the table.
//Two lines are read from the console:
//Temperature - an integer in the range [10... 42]
//Text, time of day - with possibilities - "Morning", "Afternoon", "Evening"
//Print on the console on a single line: "It's {temperature} degrees, get your {clothing} and {shoes}."

int temperature = int.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();

string outfit = string.Empty;
string shoes = string.Empty;


if(temperature >=10 && temperature <= 18)
{
 switch (timeOfDay)
    {
        case "Morning":
            outfit = "Sweatshirt";
            shoes = "Sneakers";
            break;
        case "Afternoon":
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;

    }

}
else if (temperature >18 && temperature <= 24)
{
    switch (timeOfDay)
    {
        case "Morning":
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
        case "Afternoon":
        
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;

    }
}

else if (temperature >= 25)
{
    switch (timeOfDay)
    {
        case "Morning":
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;
        case "Afternoon":

            outfit = "Swim Suit";  
            shoes = "Barefoot";
            break;
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;

    }
}

Console.WriteLine($"It's {temperature} temperature, get your {outfit} and {shoes}.");
