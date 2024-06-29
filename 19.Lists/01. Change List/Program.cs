//Write a program that:

//· Reads a list of integers from the console and receives commands to manipulate the list

//· Then until you receive "end", you will receive different commands:

//o "Delete {element}" – delete all elements in the list, which are equal to the given element

//o "Insert {element} {position}" – insert the element at the given position

//· When you receive the "end" command, print the final state of the list (separated by spaces)



    static void Main()
    {
        // Четене на списъка от цели числа от конзолата
        List<int> numbers = Console.ReadLine()
                                  .Split(' ')
                                  .Select(int.Parse)
                                  .ToList();

        while (true)
        {
            // Четене на командата от конзолата
            string input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            // Разделяне на командата и параметрите
            string[] commandParts = input.Split(' ');

            // Изпълнение на командата
            if (commandParts[0] == "Delete")
            {
                int element = int.Parse(commandParts[1]);
                numbers.RemoveAll(e => e == element);
            }
            else if (commandParts[0] == "Insert")
            {
                int element = int.Parse(commandParts[1]);
                int position = int.Parse(commandParts[2]);
                if (position >= 0 && position <= numbers.Count)
                {
                    numbers.Insert(position, element);
                }
            }
        }

        // Отпечатване на крайното състояние на списъка
        Console.WriteLine(string.Join(" ", numbers));
    }

