//· Number of packages of pens - integer in the range [0...100].
//· Number of packets of markers - integer in the range [0...100].
//· Liters of board cleaner - an integer in the range [0... 50].
//· Discount percentage - integer in the range [0...100].· Number of packages of pens - integer in the range [0...100].
//· Number of packets of markers - integer in the range [0...100].
//· Liters of board cleaner - an integer in the range [0... 50].
//· Discount percentage - integer in the range [0...100].

//INPUT

double packagePensPrice = 5.80;
double packageMarkerPrice = 7.20;
double boardCleanerPrice = 1.20;

double penPackages = double.Parse(Console.ReadLine());
double markerPackages = double.Parse(Console.ReadLine());
double boardCleanerLiters = double.Parse(Console.ReadLine());
double discount = double.Parse(Console.ReadLine());

//ACT

double packagePensCosts = penPackages * packagePensPrice;
double packageMarkersCosts = markerPackages * packageMarkerPrice;
double boardCleanerCosts = boardCleanerLiters * boardCleanerPrice;

double totalCosts = packagePensCosts + packageMarkersCosts + boardCleanerCosts;
double discountAmount = totalCosts * (discount / 100);
double totalCostsAffterDiscount = totalCosts - discountAmount;

//OUTPUT

Console.WriteLine(totalCostsAffterDiscount);



