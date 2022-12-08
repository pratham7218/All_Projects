string path = @"C:\Users\Coditas\Desktop\Ass_0408_srcFolder\Info.txt";

string str = File.ReadAllText(path);

int count = 0;

for (int i = 0; i < str.Length; i++)
{
    if (str[i] == ' ')
    {
        count++;
    }
}




Console.WriteLine($@"Number of words in file located at {path} are
{count+1}");
Console.WriteLine();

