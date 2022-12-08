
int count = 0;

for (int i = 1; i <=100 ; i++)
{
    if (i % 3 == 0)
    {
        Console.Write(i+" ");
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Total count of divisible numbers is: {count}");