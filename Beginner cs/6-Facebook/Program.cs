Console.WriteLine("Enter names");

string name =string.Empty;
List<string> list = new List<string>();
do
{
    name = Console.ReadLine();
	if (name != string.Empty)
	{
		list.Add(name);
	}
} while (name!= string.Empty);

int count = list.Count;

switch (count)
{
	case 0:
		break;

	case 1:
		Console.WriteLine($"{list[0]} liked your post");
		break;

    case 2:
        Console.WriteLine($"{list[0]} and {list[1]} liked your post");
        break;
	default:
		Console.WriteLine($"{list[0]},{list[1]} and {(list.Count)-2} others liked your post");
		break;
}