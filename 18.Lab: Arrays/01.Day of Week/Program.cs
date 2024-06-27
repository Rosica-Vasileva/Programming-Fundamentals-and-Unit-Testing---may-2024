//Write a program that:
//· Reads an integer number from the console
//· If the number is in range [1…7] print:
//o "Monday" for number 1
//o "Tuesday" for number 2
//o "Wednesday" for number 3
//o "Thursday" for number 4
//o "Friday" for number 5
//o "Saturday" for number 6
//o "Sunday" for number 7
//· If the number is out of the given range print "Invalid day!"


string[] days =
{
    "Monady",
    "Tuesday",
    "Wednesady",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday",
};

int dayIndex = int.Parse(Console.ReadLine());
if(dayIndex<1 || dayIndex > 7)
{
    Console.WriteLine("Invalid day! ");
    return;
}

Console.WriteLine(days[dayIndex - 1]);
