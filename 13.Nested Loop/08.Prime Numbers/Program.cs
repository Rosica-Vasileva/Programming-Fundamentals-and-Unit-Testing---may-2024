//Write a program that:

//· Reads two integer numbers: start of the range and end of the range

//· Print all prime numbers in given range

//Hint: A prime number is a positive integer greater than 1 that has exactly two distinct positive divisors: 1 and itself.



        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());

        for (int number = startNumber; number <= endNumber; number++)
        {
            if (IsPrime(number))
            {
                Console.Write(number + " ");
            }
        }
  

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false; // Числата по-малки или равни на 1 не са прости
        }
        if (number == 2 || number == 3)
        {
            return true; // 2 и 3 са прости числа
        }
        if (number % 2 == 0 || number % 3 == 0)
        {
            return false; // Проверка за делимост на 2 и 3
        }

        // Проверка на числа от вида 6k ± 1 до квадратния корен на числото
        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }




