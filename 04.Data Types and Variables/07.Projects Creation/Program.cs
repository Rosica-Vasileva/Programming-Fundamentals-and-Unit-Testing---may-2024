
//George
//4 
//OUTPUT The architect George will need 12 hours to complete 4 project/s.
//Sanya
//9 
//OUTPUT The architect Sanya will need 27 hours to complete 9 project/s.

//INPUT
using System.Runtime.InteropServices;

string name = Console.ReadLine();
int countOfprojects = int.Parse(Console.ReadLine());
//ACT
int neededHours = countOfprojects * 3;
//OUTPUT
Console.WriteLine($"The architect {name} will need {neededHours} hours to complete {countOfprojects} project/s.");