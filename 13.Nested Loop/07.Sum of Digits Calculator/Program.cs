//Write a program that:

//· Continuously read integers until "End" is entered from the console

//o Print the sum of digits for each integer, use the following format:

//"Sum of digits = {sum}"

//· Finally, print "Goodbye

string input = "";
while ((input = Console.ReadLine()) != "End")
{
    int n = int.Parse(input);
    int sum = 0;
    while (n > 0)
    {
        int lastDigit = n % 10;
        sum += lastDigit;
        n /= 10;
    }
    Console.WriteLine($"Sum of digits={sum}");
}
Console.WriteLine("Goodbay");