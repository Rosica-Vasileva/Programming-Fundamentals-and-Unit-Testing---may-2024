
//Input  Output 
//3.3
//2.2
//0.25
//0.75    43

//INPUT 

double bathH=double.Parse(Console.ReadLine());
double bathW = double.Parse(Console.ReadLine());

double tileH=double.Parse(Console.ReadLine());
double tileW = double.Parse(Console.ReadLine());

//the area of the bathroom and the tiles

double bathArea = bathW * bathH * 1.10; // add 10% surplus
double tileArea = tileH * tileW;

//we find how many tiles
double tilesNeeded = bathArea / tileArea;

Console.WriteLine($"{tilesNeeded:F0}");
