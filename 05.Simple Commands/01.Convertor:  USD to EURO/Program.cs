
//Input Output
//17    14.96
//87.2   76.74

//INPUT 
decimal usd = decimal.Parse(Console.ReadLine());
//ACT
decimal usdEuroRate = 0.88m;
decimal euro = usd* usdEuroRate;
//OUTPUT
Console.WriteLine($"{euro:F2}");