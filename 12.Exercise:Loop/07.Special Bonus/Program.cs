
//Write a program to apply a 20% bonus for certain number:

//· Reads an integer number from the console: the "stop number"

//· Keep reading integers until it finds the stop number

//· When the stop number is found, increase the value of the previous number before it with 20% and print it

int stopNumber = int.Parse(Console.ReadLine());
int lastNum = int.Parse(Console.ReadLine()); // Въвеждаме първото число

while (true)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if (currentNumber == stopNumber)
    {
        double output = lastNum * 1.2;
        Console.WriteLine(output);
        break;
    }
    lastNum = currentNumber;
}