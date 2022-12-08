Console.WriteLine("Enter speed limit");
int limit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter car speed");
int carSpeed = Convert.ToInt32(Console.ReadLine());

if (carSpeed <= limit)
{
    Console.WriteLine("Ok");
}
else
{
    int difference = carSpeed - limit;
    int reducedPoints = difference / 5;

    Console.WriteLine($"Demerit points {reducedPoints}");
    if (reducedPoints>=12)
    {
        Console.WriteLine();
        Console.WriteLine(@"License Suspended!!!
As demerit points are above 12");
    }
}