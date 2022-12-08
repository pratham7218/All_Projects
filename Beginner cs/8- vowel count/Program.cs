using System.IO.IsolatedStorage;

Console.WriteLine("Enter a string:");
string str = Console.ReadLine();

string vowels = "aeiou";

str = str.ToLower();

int count = 0;

foreach (var character in str)
{
    if(vowels.Contains(character))
        count++;
}

Console.WriteLine($"Number of vowels are: {count}");