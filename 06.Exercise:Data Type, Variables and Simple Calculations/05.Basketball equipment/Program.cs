

//· Basketball sneakers – their price is 40% less than the fee for one year
//· Basketball uniform – its price is 20% cheaper than that of sneakers
//· Basketball ball – its price is 1 / 4 of the price of the basketball uniform
//· Basketball accessories – their price is 1 / 5 of the price of the basketball ball

//INPUT  OUTPUT
//365    811.76
//550    1223.2

//INPUT 

int feeForOneYear = int.Parse(Console.ReadLine());

//ACT

double sneakersPrice = feeForOneYear *0.6; //60%
double uniformPrice = sneakersPrice * 0.8; //80%
double ballPrice = uniformPrice / 4;
double accessoriesPrice = ballPrice / 5;
double totalPrice = feeForOneYear + sneakersPrice + uniformPrice + ballPrice + accessoriesPrice;

//OUTPUT

Console.WriteLine(totalPrice);
