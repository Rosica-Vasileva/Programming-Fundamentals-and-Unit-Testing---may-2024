

string figureArea = Console.ReadLine();

if (figureArea == "square")
{
    double side = double.Parse(Console.ReadLine());
    double area = side * side;
    Console.WriteLine($"{area:F2}");
}

else if (figureArea == "rectangle")
{
    double length = double.Parse(Console.ReadLine());
    double width = double.Parse(Console.ReadLine());
    double area = length * width;
    Console.WriteLine($"{area:F2}");
}

else if (figureArea == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    double area = Math.PI * radius * radius; 
    Console.WriteLine($"{area:F2}"); 
}