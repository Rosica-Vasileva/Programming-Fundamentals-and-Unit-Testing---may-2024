

//Write a program that:

//· Reads a list of integers

//· Then until you receive "end", you will receive different commands:

//o "Add {number}": add a number to the end of the list

//o "Remove {number}": remove a number from the list

//o "RemoveAt {index}": remove a number at a given index

//o "Insert {number} {index}": insert a number at a given index

//· When you receive the "end" command, print the final state of the list (separated by spaces)

//Note: All the indices will be valid!


    static void Main()
    {
        // Четене на списъка от цели числа от конзолата
        List<int> numbers = Console.ReadLine()
                                  .Split(' ')
                                  .Select(int.Parse)
                                  .ToList();

        string line;
        while ((line = Console.ReadLine()) != "end")
        {
            string[] tokens = line.Split(' ');
            string command = tokens[0];

            if (command == "Add")
            {
                int item = int.Parse(tokens[1]);
                numbers.Add(item);
            }
            else if (command == "Remove")
            {
                int item = int.Parse(tokens[1]);
                numbers.Remove(item);
            }
            else if (command == "RemoveAt")
            {
                int index = int.Parse(tokens[1]);
                numbers.RemoveAt(index);
            }
            else if (command == "Insert")
            {
                int item = int.Parse(tokens[1]);
                int index = int.Parse(tokens[2]);
                numbers.Insert(index, item);
            }
        }

        // Отпечатване на крайното състояние на списъка
        Console.WriteLine(string.Join(" ", numbers));
    }

