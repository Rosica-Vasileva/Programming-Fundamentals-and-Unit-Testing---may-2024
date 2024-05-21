//Input Output
//15
//2     7.50
//15
//2.2   6.82

//INPUT
double distance = double.Parse(Console.ReadLine());
double time = double.Parse(Console.ReadLine());

//ACT
double speed = distance / time;

//OUTPUT
Console.WriteLine($"{speed:F2}");
