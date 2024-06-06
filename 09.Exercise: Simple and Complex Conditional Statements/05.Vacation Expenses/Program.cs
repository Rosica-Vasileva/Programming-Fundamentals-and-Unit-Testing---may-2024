
//Write a program, which calculates vacation expenses:

//From the console read: season(string), accommodation type(string) and count of the days (integer)

//Season will be one of the following: "Spring", "Summer", "Autumn" and "Winter"

//Accommodation type will be one of the following: "Hotel" and "Camping

//Based on the table below, you have to calculate expenses for the vacation with the given accommodation type, season and count of the days.

//For the calculation: use price per night (extracted from the table below) multiplied by count of the days.

//Print the total expenses, formatted to the second digit after the decimal point

//INPUT

// Input
string season = Console.ReadLine();
string accommodationType = Console.ReadLine();
int countOfTheDays = int.Parse(Console.ReadLine());
double pricePerNight = 0; 
double discount = 0;

// Act
if (season == "Spring")
{
    if (accommodationType == "Hotel")
    {
        pricePerNight = 30;
    }
    else if (accommodationType == "Camping")
    {
        pricePerNight = 10;
    }
    discount = 0.20;
}
else if (season == "Summer")
{
    if (accommodationType == "Hotel")
    {
        pricePerNight = 50;
    }
    else if (accommodationType == "Camping")
    {
        pricePerNight = 30;
    }
}
else if (season == "Autumn")
{
    if (accommodationType == "Hotel")
    {
        pricePerNight = 20;
    }
    else if (accommodationType == "Camping")
    {
        pricePerNight = 15;
    }
    discount = 0.30;
}
else if (season == "Winter")
{
    if (accommodationType == "Hotel")
    {
        pricePerNight = 40;
    }
    else if (accommodationType == "Camping")
    {
        pricePerNight = 10;
    }
    discount = 0.10;
}

double finalPriceWithoutDiscount = countOfTheDays * pricePerNight;
double discountAmount = finalPriceWithoutDiscount * discount;
double finalPrice = finalPriceWithoutDiscount - discountAmount;

// Output
Console.WriteLine($"{finalPrice:F2}");
