
//Write a program that:

//· Reads two integer numbers from the console: width and length

//· Create a method which returns rectangle area with given width and length

//Hint: Rectangle area can be calculated when you multiply width and length of the rectangle.

using System;

class Program
{
    static void Main()
    {
        // Прочитане на ширината от конзолата
        int width = int.Parse(Console.ReadLine());

        // Прочитане на дължината от конзолата
        int length = int.Parse(Console.ReadLine());

        // Изчисляване на площта на правоъгълника
        int area = CalculateRectangleArea(width, length);

        // Печатане само на резултата
        Console.WriteLine(area);
    }

    // Метод за изчисляване на площта на правоъгълника
    static int CalculateRectangleArea(int width, int length)
    {
        return width * length;
    }
}

