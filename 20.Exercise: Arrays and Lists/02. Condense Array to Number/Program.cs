//Write a program that:

//· Read a sequence of integer numbers from the console

//· Condense them by summing adjacent couples of elements until a single integer is obtained

//Example: If we have 3 elements {2, 10, 3}. We sum the first two and the second two elements and obtain

//{2+10, 10+3} = { 12, 13}. Then we sum again all adjacent elements and obtain {12+13} = { 25}.

int[]numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

while (numbers.Length > 1)
{
    int[] condensedArray = new int[numbers.Length - 1];

    for(int i = 0; i < numbers.Length - 1; i++)
    {
        int sumNum = numbers[i] + numbers[i + 1];
        condensedArray[i] = sumNum;
    }
    numbers = condensedArray;
}
Console.WriteLine(numbers[0]);
