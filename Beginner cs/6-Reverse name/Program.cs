Console.WriteLine("Enter your name");
string str = Console.ReadLine();

var charArray = str.ToCharArray();
Array.Reverse(charArray);

Console.WriteLine(charArray);