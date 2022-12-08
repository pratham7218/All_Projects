string str = "Hello there My name is Prathamesh";

int max = 5;
var op = from word in str.Split(' ') where word.Length > max select word;

foreach (var item in op)
{
    Console.WriteLine(item);
}