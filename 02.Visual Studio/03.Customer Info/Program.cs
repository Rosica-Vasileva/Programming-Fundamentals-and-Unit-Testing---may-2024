
//INPUT Desislava Topuzakova d.topuzakova@softuni.bg 
//OUTPUT Customer: Desislava Topuzakova(dtopuzakova @softuni.bg)
//INPUT Ivan Ivanov i.ivanov@abv.bg
//OUTPUT Customer: Ivan Ivanov(i.ivanov @abv.bg)

string firstName = Console.ReadLine();
string lastName = Console.ReadLine();
string email = Console.ReadLine();

Console.WriteLine($"Customer:{firstName} {lastName} ({email})");