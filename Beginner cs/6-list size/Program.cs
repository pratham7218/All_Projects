Console.WriteLine("Enter comma seperated numbers");
string numbers = Console.ReadLine();

var charArray = numbers.Split(',');

if (charArray.Length < 5)
{

    charArray = Array.Empty<string>();
    while (charArray.Length<5)
    {
    Console.WriteLine("Invalid list");
    Console.WriteLine("Retry!!");
    Console.WriteLine("Enter comma seperated numbers");
        numbers = Console.ReadLine();
        charArray = numbers.Split(',');
    }
}

Array.Sort(charArray);

Console.WriteLine($@"3 smallest elements are
{charArray[0]}
{charArray[1]}
{charArray[2]}");
