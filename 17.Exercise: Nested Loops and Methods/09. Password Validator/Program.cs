//Write a program that checks if a given password is valid.

//The password validation rules are:

//· It should contain 6 – 10 characters (inclusive)

//· It should contain only letters and digits

//· It should contain at least 2 digits

//If it is not valid, for any unfulfilled rule print the corresponding message:

//· "Password must be between 6 and 10 characters"

//· "Password must consist only of letters and digits"

//· "Password must have at least 2 digits

using System;

class Program
{
    static void Main()
    {
        // Четене на паролата от конзолата
        string password = Console.ReadLine();

        // Проверка за валидност на паролата
        ValidatePassword(password);
    }

    static void ValidatePassword(string password)
    {
        bool isValid = true;

        // Проверка на дължината на паролата
        if (password.Length < 6 || password.Length > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            isValid = false;
        }

        // Проверка дали паролата съдържа само букви и цифри
        foreach (char c in password)
        {
            if (!char.IsLetterOrDigit(c))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
                break;
            }
        }

        // Проверка дали паролата съдържа поне 2 цифри
        int digitCount = 0;
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                digitCount++;
            }
        }

        if (digitCount < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
            isValid = false;
        }

        // Ако паролата е валидна, отпечатва "Password is valid"
        if (isValid)
        {
            Console.WriteLine("Password is valid");
        }
    }
}
