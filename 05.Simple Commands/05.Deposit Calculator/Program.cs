//amount = deposited amount + term of deposit * (deposited amount * annual interest rate) / 12
//1. Deposited amount – real number in the range [100.00 ... 10000.00]
//2.Term of the deposit (in months) – an integer in the range [1... 12]
//3.Annual interest rate – real number in the range [0.00 ... 100.00]

//INPUT

decimal depositedAmount = decimal.Parse(Console.ReadLine());
int depositTerm = int.Parse(Console.ReadLine());
decimal interestRate = decimal.Parse(Console.ReadLine());

//ACT

decimal annualInterest = depositedAmount * interestRate / 100;
decimal montlyInterest = annualInterest / 12;
decimal amount = depositedAmount + (depositTerm * montlyInterest);

//OUTPUT

Console.WriteLine(amount);