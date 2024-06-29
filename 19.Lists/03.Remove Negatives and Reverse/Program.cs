//Write a program that:

//· Read a list of integers

//· Remove all negative numbers from it

//· Print the remaining elements in reversed order

//· If there are no elements left in the list, print "empty"







class Program
{
    static void Main()
    {
        // Четене на списъка от цели числа от конзолата
        List<int> numbers = Console.ReadLine()
                                  .Split(' ')
                                  .Select(int.Parse)
                                  .ToList();

        // Създаване на нов списък за положителните числа
        List<int> positiveNumbers = new List<int>();

        // Добавяне на положителните числа в новия списък
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                positiveNumbers.Add(number);
            }
        }

        // Проверка дали списъкът е празен и печат на резултата
        if (positiveNumbers.Count != 0)
        {
            positiveNumbers.Reverse();
            Console.WriteLine(string.Join(" ", positiveNumbers));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}
