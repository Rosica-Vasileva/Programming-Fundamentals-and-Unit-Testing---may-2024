//Input Output
//5
//10    5.00 + 10.00 = 15.00
//      5.00 - 10.00 = -5.00
//      5.00 * 10.00 = 50.00
//      5.00 / 10.00 = 0.50
//15
//2.2   15.00 + 2.20 = 17.20
//      15.00 - 2.20 = 12.80
//      15.00 * 2.20 = 33
//      15.00 / 2.20 = 6.82

//INPUT 
double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

//ACT
double additionResult = firstNumber + secondNumber;
double subtractionResult = firstNumber - secondNumber;
double multiplicationResult = firstNumber * secondNumber;
double divisonResult = firstNumber / secondNumber;

//OUTPUT
Console.WriteLine($"{firstNumber} + {secondNumber} = {additionResult:F2}");

Console.WriteLine($"{firstNumber} - {secondNumber} = {subtractionResult:F2}");

Console.WriteLine($"{firstNumber} * {secondNumber} = {multiplicationResult:F2} ");

Console.WriteLine($"{firstNumber} / {secondNumber} = {divisonResult:F2}");
