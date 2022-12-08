int count = 0;
Random random = new Random();
while (true)
{
    int number = random.Next() % 10;
    count++;

    Console.WriteLine("Guess the number between 1 and 10 (1 is inclusive)");
    int guess = Convert.ToInt32(Console.ReadLine());
    if(guess == number)
    {
        Console.WriteLine("You Won");
        break;
    }else if(count == 4)
    {
        Console.WriteLine("You lost!!");
        break;
    }
    else
    {
        Console.WriteLine("Give another shot!!");
    }
}