//Input    Output
//2 Minutes = 2880
//5 Minutes = 7200
//7 Minutes = 10080

//INPUT
int days = int.Parse(Console.ReadLine());

//ACT 
int minutes = days * 24 * 60;

//OUTPUT
Console.WriteLine($"Minutes={minutes}");
