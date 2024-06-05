
//Write a program to evaluate operations, which:
//Reads 2 real numbers and math operator (string) from the console
//Possible given values for the math operator are: "+", "-", "*", "/"
//Apply the operator with given numbers
//Print output in the following format, where result is formatted to the second digit:
//"{N1} {operator} {N2} = {result}"

//INPUT 

double numOne = double.Parse(Console.ReadLine());
double numTwo = double.Parse(Console.ReadLine());
char operation=char.Parse(Console.ReadLine());

double result = 0;
//ACT
if (operation == '+')
{
    result = numOne + numTwo;
}
else if (operation == '-')
{
    result = numOne - numTwo;
}
else if (operation == '*')
{
    result = numOne * numTwo;
}
else if (operation == '/')
{
    result = numOne / numTwo;
}
//OUTPUT
Console.WriteLine($"{numOne} {operation} {numTwo} = {result:F2}");