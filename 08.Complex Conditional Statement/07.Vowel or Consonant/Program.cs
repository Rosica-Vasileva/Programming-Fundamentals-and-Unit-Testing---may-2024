
//Write a program to check a letter for vowel or consonant:
//Reads a character (letter, part of the English alphabet) from the console
//Based on the value of the character, print:
//If the character is vowel letter print "Vowel"
//Hint: Vowels letters are: A, a, E, e, I, i, O, o, U, u
//If the character is consonant letter print "Consonant"

char @char = char.Parse(Console.ReadLine());

switch (@char)
{
    case 'A':
    case 'a':
    case 'E':
    case 'e':
    case 'I':
    case 'i':
    case 'O':
    case 'o':
    case 'U':
    case 'u':
        Console.WriteLine("Vowel");
        break;
    default:
        Console.WriteLine("Constant");
        break;
}

