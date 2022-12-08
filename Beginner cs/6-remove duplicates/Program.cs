string wish = "ok";

List<int> unique = new List<int>();

int number = 0;
do
{
    Console.WriteLine("Enter number");
    number = Convert.ToInt32(Console.ReadLine());
    
    if (!unique.Contains(number))
    {
        unique.Add(number);
    }

    Console.WriteLine("Press ok to enter numbers");
    wish = Console.ReadLine();
} while (wish =="ok" || wish=="Ok");

Console.WriteLine();
Console.WriteLine("Unique elements are");
foreach (var item in unique)
{
    Console.Write(item+ " ");
}

