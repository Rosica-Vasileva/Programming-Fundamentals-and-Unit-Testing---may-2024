
using System;

class Program
{
    static void Main()
    {
        // Четене на текстов низ от конзолата
        Console.Write("");
        string text = Console.ReadLine();

        // Четене на броя повторения от конзолата
        Console.Write("");
        int repeatCount = int.Parse(Console.ReadLine());

        // Извикване на метода за повторение на низа
        string repeatedString = RepeatString(text, repeatCount);

        // Печатане само на резултата, без допълнителен текст и нов ред
        Console.Write(repeatedString);
    }

    // Метод за повторение на текстов низ
    static string RepeatString(string text, int repeatCount)
    {
        // Инициализираме празен низ
        string result = "";

        // Повтаряме текстовия низ repeatCount пъти
        for (int i = 0; i < repeatCount; i++)
        {
            result += text; // Добавяме текстовия низ към резултата
        }

        return result; // Връщаме сглобеният резултат
    }
}
