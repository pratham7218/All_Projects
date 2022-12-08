Console.WriteLine("Enter time in {HH:MM} format");
string str = Console.ReadLine();

TimeOnly dt;
int flag = 0;
try
{
    dt = TimeOnly.Parse(str);
}
catch (Exception)
{
    flag = 1;
    Console.WriteLine("Invalid");
}

if (flag==0)
{
    Console.WriteLine("Valid");
}



