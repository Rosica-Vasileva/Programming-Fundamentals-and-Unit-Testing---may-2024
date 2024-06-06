//Three athletes finish in a certain number of seconds (between 1 and 50).
//Write a program that:
//Read three integers - the athletes' times in seconds, from console
//Calculate their total time in the format "minutes:seconds"
//Note: The seconds should be displayed with leading zero (2 as "02", 7 as "07", 35 as "35").

int timeInSecond1 = int.Parse(Console.ReadLine());
int timeInSecond2 = int.Parse(Console.ReadLine());
int timeInSecond3 = int.Parse(Console.ReadLine());

int sumTimeInSecond = timeInSecond1 + timeInSecond2 + timeInSecond3;
int timeInHoure = sumTimeInSecond / 60;
int timeInSecond = sumTimeInSecond % 60;

if (timeInSecond < 10)
{
    Console.WriteLine($"{ timeInHoure}:{timeInSecond:D2}");
}
