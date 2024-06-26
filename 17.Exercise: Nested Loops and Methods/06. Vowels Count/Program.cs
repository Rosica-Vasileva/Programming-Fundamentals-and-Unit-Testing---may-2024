//Write a program that:

//· Read a text (string) from the console

//· Create a method that receives a text

//· Find the count of the vowels contained in the text

//· Print the count of the vowels in the text


    static void Main(string[] args)
    {
        // Чете текст от конзолата
        string input = Console.ReadLine();

        // Извиква метода за броене на гласни
        PrintVowelsCountInText(input);
    }

    static void PrintVowelsCountInText(string text)
    {
        int counter = 0;

        // Цикъл за обхождане на текста
        for (int i = 0; i < text.Length; i++)
        {
            char currentLetter = text[i];

            // Проверка за гласна буква
            switch (currentLetter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                case 'Y':
                    counter++;
                    break;
            }
        }

        // Извежда броя на гласните
        Console.WriteLine(counter);
    }


