//• Chicken menu – 10.35 lv.
//• Menu with fish – 12.40 lv.
//• Vegetarian menu – 8.15 lv.
//Number of chicken menus – integer in the range [0 ... 99]
//Number of menus with fish – integer in the range [0 ... 99]
//Number of vegetarian menus – an integer in the range [0 ... 99]

//INPUT

double chickenPriceMenu = 10.35;
double fishPriceMenu = 12.40;
double vegetarianPriceMenu = 8.15;
double deliveryPrice = 2.5;
double dessert = 0;

int chickenMenuCosts = int.Parse(Console.ReadLine());
int fishMenuCosts = int.Parse(Console.ReadLine());
int vegetarianMenuCosts = int.Parse(Console.ReadLine());

//ACT

double allChickenPrice = chickenMenuCosts * chickenPriceMenu;
double allFishPrice = fishMenuCosts * fishPriceMenu;
double allVegetarianPrice = vegetarianMenuCosts * vegetarianPriceMenu;

double totalCostsOfMenu = allChickenPrice + allFishPrice + allVegetarianPrice;
double dessertPrice = totalCostsOfMenu * 0.2;
double totalOrderPrice = totalCostsOfMenu + dessertPrice + deliveryPrice;

Console.WriteLine(totalOrderPrice);


