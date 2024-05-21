//Input   Output
//7        Area = 153.94 
//         Perimeter = 43.98

//INPUT
double radiusOfaCircle = double.Parse(Console.ReadLine());

//ACT
double area = radiusOfaCircle * radiusOfaCircle * Math.PI;
double perimeter = 2 * Math.PI * radiusOfaCircle;

//OUTPUT
Console.WriteLine($"{area:F2}");
Console.WriteLine($"{perimeter:F2}");