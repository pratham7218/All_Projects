string wish = "ok";
int sum = 0;
do
{
    Console.WriteLine("Enter a number to add");
    int num = Convert.ToInt32(Console.ReadLine());

    sum+=num;

    Console.WriteLine(@"Do you want to continue ??
Press Ok to continue Or any other key to exit");
    wish = Console.ReadLine();
} while (wish=="ok" || wish=="Ok");

Console.WriteLine($"Sum of all entered numbers is: {sum}");