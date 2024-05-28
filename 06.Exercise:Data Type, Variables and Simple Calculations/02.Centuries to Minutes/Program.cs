
//Input     Output
//1         1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
//5         5 centuries = 500 years = 182621 days = 4382904 hours = 262974240 minutes

//· Reads an integer number, that represents centuries for conversion
//· Convert centuries to years (1 century = 100 years)
//· Convert years to days (1 year = 365.2422 days)
//· Convert days to hours (1 day = 24 hours)
//· Convert hours to minutes (1 hour = 60 minutes)
//· Print converted data in the following format:
//"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes"

//INPUT

int centuries = int.Parse(Console.ReadLine());

//ACT
int years = centuries * 100;
int days =(int)( years * 365.2422);
int hours = days * 24;
int minutes = hours * 60;

//OUTPUT

Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
