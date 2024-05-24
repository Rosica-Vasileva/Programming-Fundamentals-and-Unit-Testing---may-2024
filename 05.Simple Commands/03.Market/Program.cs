

//Input   Output 
//42.50   249.69 
//3.30
//60.80
//1.80 

//INPUT
decimal tomatoPrice = decimal.Parse(Console.ReadLine());
decimal tomato = decimal.Parse(Console.ReadLine());
decimal cucumberPrice = decimal.Parse(Console.ReadLine());
decimal cucumber = decimal.Parse(Console.ReadLine());

//ACT
decimal tomatoCost = tomatoPrice * tomato;
decimal cucumberCost = cucumberPrice * cucumber;

decimal totalCost = tomatoCost + cucumberCost;
Console.WriteLine($"{totalCost:F2}");
