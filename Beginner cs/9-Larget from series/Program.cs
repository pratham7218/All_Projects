Console.WriteLine("Enter comma seperated numbers");
string str = Console.ReadLine();

var arr = str.Split(',');

int largest = 0;
foreach (var item in arr)
{
    int number = Convert.ToInt32(item);

    if(number> largest)
    {
        largest = number;
    }
}

Console.WriteLine($"Largest number from list is: {largest}");