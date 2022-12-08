Console.WriteLine("Enter numbers seperated with hyphens");
string wish = "ok";

string str = string.Empty;
while (true)
{
    char read = (char)Console.Read();

    if(read.Equals(' '))
    {
        break;
    }
    str += read;

}

string[] arr = str.Split('-');
List<int> list = new List<int>();

for (int i = 0; i < arr.Length; i++)
{
    int number = Convert.ToInt32(arr[i]);

    if (!list.Contains(number))
    {
        list.Add(number);
    }
    else
    {
        Console.WriteLine("Duplicates are present");
        break;
    }
}

if(list.Count == arr.Length)
{
    Console.WriteLine("No duplicates are present");
}
