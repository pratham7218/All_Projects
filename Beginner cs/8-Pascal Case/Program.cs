Console.WriteLine("Enter space seperated string");
string str = Console.ReadLine();

string[] words = str.Split(' ');

for (int i = 0; i < words.Length; i++)
{
    int old = words[i][0];//accessing first letter of each word
    int newFirst=0;
    
    if (old>=97 && old<=122)
    {
        newFirst = old - 32;//converting it to Capital letter
        words[i] = words[i].Replace((char)old, (char)newFirst);
    }

}

foreach (var item in words)
{
    Console.Write(item);
}

