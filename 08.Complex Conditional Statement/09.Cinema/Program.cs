//Write a program, that calculates the price for all the tickets for a cinema movie:
//Reads the type of the movie (string), the count of the rows (an integer number) and count of the seats per row (an integer number) in the cinema
//Type of the movie will be one of the following: "Premiere", "Normal" and "Discount"
//Prints the total price for all seats formatted to the 2nd digit after the decimal point, based on the table below:

//Normal
//12
//9


string movieType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());
int totalSeats = rows * seats;
decimal price = 0.00m;

if (movieType == "Premier")
{
    price = 12.00m;
}
else if (movieType == "Normal")
{
    price = 7.50m;
}
else
{
    price = 5.00m;
}

decimal totalPrice = totalSeats * price;
Console.WriteLine($"{totalPrice:F2}");