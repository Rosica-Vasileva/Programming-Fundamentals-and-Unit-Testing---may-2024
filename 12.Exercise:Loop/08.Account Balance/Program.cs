//Write a program to calculate an account balance:

//· Read a sequence of incomes / expenses, until "End" is read

//· Add the money to the balance (starting form 0)

//· Print "Increase: {money}" or "Decrease: {money}", where value is formatted to the second decimal digit

//· Finally, print the account balance, formatted to the second 
//decimal digit in the following format: "Balance: {account balance}"
        
    
    double balance = 0.0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            double amount;
            if (double.TryParse(input, out amount))
            {
                if (amount > 0)
                {
                    Console.WriteLine($"Increase: {amount:F2}");
                    balance += amount;
                }
                else
                {
                    Console.WriteLine($"Decrease: {Math.Abs(amount):F2}");
                    balance += amount; // Adding a negative amount
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number or 'End' to finish.");
            }
        }

        Console.WriteLine($"Balance: {balance:F2}");

