//Write a program to process a sequence of commands:

//· Read an initial number from the input

//· Read an execute a sequence of the following commands:

//o "Inc" – add 1 to the number (increment)

//o "Dec" – subtract 1 from the number (decrement)

//o "End" – print the number and stop the program

int number = int.Parse(Console.ReadLine());
string command = "";
while ((command = Console.ReadLine()) != "End")
{
    number = command == "Inc" ? number + 1 : number - 1;
}

Console.WriteLine(number);