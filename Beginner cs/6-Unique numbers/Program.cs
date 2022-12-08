Console.WriteLine("Enter 5 numbers");

var numbers = new int[5];
int number;
for (int i = 0; i < 5; i++)
{
    number = Convert.ToInt32(Console.ReadLine());
    if (!numbers.Contains(number))
    {
        numbers[i] = number;
    }
    else
    {

        while (numbers.Contains(number))
        {
            Console.WriteLine(@"Error!!
Number already present.Enter another number");
            number = Convert.ToInt32(Console.ReadLine());
        }
        numbers[i] = number;
    }
}

Array.Sort(numbers);

Console.WriteLine();
Console.WriteLine("Sorted numbers are");
foreach (var item in numbers)
{
    Console.Write(item + " ");
}