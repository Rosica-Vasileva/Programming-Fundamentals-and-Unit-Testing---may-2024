//Input   Output
//1852.4  1.85
//798.3   0.80

//INPUT
using System.Diagnostics.Metrics;

double meters = double.Parse(Console.ReadLine());

//ACT
double kilometers = meters/ 1000;

//OUTPUT
Console.WriteLine($"{kilometers:F2}");