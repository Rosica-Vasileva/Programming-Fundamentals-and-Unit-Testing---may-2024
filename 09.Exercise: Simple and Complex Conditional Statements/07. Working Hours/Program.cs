//Write a program that checks if the company's office is open:
//Reads an hour of the day (integer number) and a day of the week (string)
//The office's working hours are from 10 AM to 6 PM, Monday through Saturday, inclusive.
//Print "open", if the office is open in the given hour and day of the week
//Print "closed", if the office is closed in the given hour and day of the week

int hourOfTheDay = int.Parse(Console.ReadLine());
string dayOfTheWeek = Console.ReadLine();

if (hourOfTheDay>=10 && hourOfTheDay <= 18)
{
    if (dayOfTheWeek=="Monday" || dayOfTheWeek=="Tuesday" || dayOfTheWeek=="Wednesday" ||
            dayOfTheWeek=="Thursday" ||
            dayOfTheWeek=="Friday" ||
            dayOfTheWeek == "Saturday")
            {
        Console.WriteLine("open");
            }
}

else
{
    Console.WriteLine("close");
}