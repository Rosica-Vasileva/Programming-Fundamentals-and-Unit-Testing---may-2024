//Input  Output
//5
//4      28.50 lv.
//13
//9      68.50 lv.

//INPUT
int dogFoodcount = int.Parse(Console.ReadLine());
int catFoodcount = int.Parse(Console.ReadLine());
//ACT
double expenses = dogFoodcount * 2.5 + catFoodcount * 4.00;
//OUTPUT
Console.WriteLine($"{expenses:F2} lv.");
