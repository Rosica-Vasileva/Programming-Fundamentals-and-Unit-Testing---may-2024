
//Input Output 
//85
//75
//47
//17    248.69 

//105
//77
//89
//18.5  586.45

//INPUT

int lengthInCm = int.Parse(Console.ReadLine());
int widthInCm = int.Parse(Console.ReadLine());
int heighInCm = int.Parse(Console.ReadLine());
double  percentage = double.Parse(Console.ReadLine());

//ACT

int volume = lengthInCm * widthInCm * heighInCm;
double volumeInLiters = volume /1000;
double requiredLiters = volumeInLiters * (1 - percentage/100);

//OUTPUT

Console.WriteLine($"{requiredLiters:F2}");
