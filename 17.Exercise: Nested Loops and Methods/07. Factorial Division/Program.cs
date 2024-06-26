//Write a program that:

//· Read two integers numbers from the console in range [1…10] · Calculate the factorial of each number

//· Divide the first calculated factorial by the second calculated factorial (integer division)

//· Print the result of the division



    static void Main()
    {
        // Четене на първото цяло число от конзолата
        int firstNumber = int.Parse(Console.ReadLine());

        // Четене на второто цяло число от конзолата
        int secondNumber = int.Parse(Console.ReadLine());

        // Изчисляване на факториала на първото число
        int firstFactorial = 1;
        for (int i = 1; i <= firstNumber; i++)
        {
            firstFactorial *= i;
        }

           // Изчисляване на факториала на второто число
        int secondFactorial = 1;
        for (int i = 1; i <= secondNumber; i++)
        {
            secondFactorial *= i;
        }

          // Целочислено деление на първия факториал с втория
        int result = firstFactorial / secondFactorial;

        // Отпечатване на резултата
        Console.WriteLine(result);
    }


