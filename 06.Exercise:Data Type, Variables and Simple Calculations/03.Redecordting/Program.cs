//Input   Exit 
//10      727.09
//11
//4
//8

//5       286.52
//10
//10
//1

//INPUT

int nylonAmount =int.Parse(Console.ReadLine());
int paintAmount = int.Parse(Console.ReadLine());
int thinnerAmount = int.Parse(Console.ReadLine());
int hoursOfWork = int.Parse(Console.ReadLine());

double nylonPrice = 1.50;
double paintPrice = 14.50;
double thinnerPrice = 5;
double bagsPrice = 0.40;

//ACT

double priceForAllNylon = (nylonAmount + 2) * nylonPrice;
double priceForAllPaint = (paintAmount * 1.1) * paintPrice; ;  //add 10%
double priceForAllThinner = thinnerAmount * thinnerPrice;
double materialPrice = priceForAllNylon + priceForAllPaint + priceForAllThinner + bagsPrice;
double priceForWorkers = materialPrice * 0.3 * hoursOfWork;  //30%
double finalPrice = materialPrice + priceForWorkers;

//OUTPUT

Console.WriteLine(finalPrice);



