
//Write a program that prints numbers in given range over 3:
//· Reads an integer number n – end of the range
//· Prints all numbers from 1 to n, over 3 (inclusively)

//INPUT 

int n = int.Parse(Console.ReadLine());
//ACT
for(int i = 1; i < n; i += 3)
{    //OUTPUT
    Console.WriteLine(i);
}