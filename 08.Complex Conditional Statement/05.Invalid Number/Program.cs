//75  invalid  150  (няма изход)  0 (няма изход)


int number = int.Parse(Console.ReadLine());

if (!((number >= 100 && number <= 200) || (number == 0)))
{
    Console.WriteLine("invalid");
}
else
{
    Console.WriteLine();
}