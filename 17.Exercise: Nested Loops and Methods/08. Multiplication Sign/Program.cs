//Write a program that:

//· Reads three integer numbers (num1, num2 and num3) from the console

//· Finds if num1 * num2 * num3 (the product) is negative, positive or zero

//· Print:

//o negative - if the product is smaller than 0

//o positive - if the product is bigger than 0

//o zero - if the product is equals to 0

//Note: Try to do this WITHOUT multiplying the three numbers.

using System;


        // Четене на трите цели числа от конзолата
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        // Проверка дали някое от числата е 0
        if (num1 == 0 || num2 == 0 || num3 == 0)
        {
            Console.WriteLine("zero");
        }
        else
        {
            // Броене на отрицателните числа
            int negativeCount = 0;

            if (num1 < 0) negativeCount++;
            if (num2 < 0) negativeCount++;
            if (num3 < 0) negativeCount++;

            // Проверка на броя на отрицателните числа
            if (negativeCount == 1 || negativeCount == 3)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
