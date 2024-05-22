//Input Output
//37    98.60
//100   212.00

//INPUT
double degreesCelsius = double.Parse(Console.ReadLine());

//ACT
double degreesFahrenheit = degreesCelsius * 1.8 + 32;

//OUTPUT
Console.WriteLine($"{degreesFahrenheit:F2}");
