//1. Number of pages in the current book – an integer in the range [1... 1000].
//2. Pages that he reads in 1 hour – an integer in the range [1... 1000].
//3. The number of days he needs to finish the book – an integer in the range [1... 1000].1. Number of pages in the current book – an integer in the range [1... 1000].

//INPUT 

int pages = int.Parse(Console.ReadLine());
int pagesReadOneHour = int.Parse(Console.ReadLine());
int numberOfDay = int.Parse(Console.ReadLine());

//ACT

int totalReadingtime = pages / pagesReadOneHour;
int requiredPerDay = totalReadingtime / numberOfDay;

//OUTPUT 

Console.WriteLine(requiredPerDay);