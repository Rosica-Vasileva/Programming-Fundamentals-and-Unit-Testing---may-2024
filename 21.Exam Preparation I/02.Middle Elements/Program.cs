

int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int middleIndex = numbers.Length / 2;
int firstNumber = numbers[middleIndex];
int secondNumber = numbers[middleIndex - 1];

int sum = firstNumber + secondNumber;
double result = sum / 2.0;
Console.WriteLine($"{result:F2}");