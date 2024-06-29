//Write a program that:

//· Read an integer number n and n lines of products

//· Print a numbered list of all the products ordered by name


int n = int.Parse(Console.ReadLine());
List<string> products = new List<string>();

for(int i = 0; i < n; i++)
{
    string product = Console.ReadLine();
    products.Add(product);
}

products.Sort();
for(int i=0; i < products.Count; i++)
{
    Console.WriteLine($"{i+1}.{products[i]}");

}