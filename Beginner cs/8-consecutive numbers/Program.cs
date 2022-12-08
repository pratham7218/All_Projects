using System.Security;

Console.WriteLine("Enter numbers in string format seperated with hyphens");

string str = Console.ReadLine();

string[] arr = str.Split('-');

int count = 0;
for (int i = 0; i < arr.Length-1; i++)
{

    int current = Convert.ToInt32(arr[i]);
    int next = Convert.ToInt32(arr[i+1]);

    if (next < current)
    {
        int temp = current;
        current = next;
        next = temp;
    }

    int difference = next - current;
    if(difference == 1)
    {
        count++;
    }
}

int stopper = (arr.Length / 2) + 1;
if (count == stopper)
{
    Console.WriteLine("Consecutive");
}
else
{
    Console.WriteLine("Not Consecutive");
}