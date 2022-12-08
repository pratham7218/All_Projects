string path = @"C:\Users\Coditas\Desktop\Ass_0408_srcFolder\Info.txt";

string[] str = File.ReadAllLines(path);

int count = 0; string max = string.Empty;
for (int i = 0; i < str.Length; i++)
{
    string[] arr = str[i].Split(' ');
	max = string.Empty;
	for (int j = 0; j < arr.Length; j++)
	{
		if (arr[j].Length > max.Length)
		{
			max = arr[j];
		}
	}
}

Console.WriteLine(max);



/*
 it is reading data correctly only when data is in sinle line.
If we split data in multiple lines then its combining last word of current line with first word of next line
 */
//string[] arr = str.Split(' ');

//string max = string.Empty;

//int i = 0;
//for (i = 0; i < arr.Length; i++)
//{
//    if (arr[i].Length > max.Length)
//    {
//        max = arr[i];
//    }
//}

//Console.WriteLine(max);