using System.Text;

var arr1 = new[] { 1, 2, 3, 4, 5, 6, 7 };

Array.Clear(arr1, 0, 2);//setting items to 0.(excluding index 2)
foreach (var item in arr1)
{
	Console.WriteLine(item);
}

Console.WriteLine("================================================================================");
var arrayToCopy = new int[4];
Array.Copy(arr1, arrayToCopy, 4);//copy first 4 items to arrayToCopy
foreach (var item in arrayToCopy)
{
    Console.WriteLine(item);
}

Console.WriteLine("================================================================================");



var arr = new int[3, 5];

int count = 0;
for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 5; j++)
	{
		arr[i,j] = count++;
		Console.Write(arr[i,j]+" ");	
	}
	Console.WriteLine();
}

Console.WriteLine("================================================================================");
Console.WriteLine("Lists");

List<int> list = new List<int>();

list.AddRange(new int[4] { 6, 5, 4, 3 });
list.Add(1);
list.AddRange(new List<int> { 11,6,12,13});


foreach (var item in list)
{
	Console.WriteLine(item);
}

list.Remove(6);//it'll remove only one 6 which is occurring at first.
for (int i = 0; i < list.Count; i++)
{
	if (list[i] == 1)
		list.Remove(1);//it'll remove every 6 present
	/*here foreach loop will fail cz once 1st 6 is removed,collection will get modified and same operation can not
	be performed on modified collection.Cz initially size of collection will be calculated and once we remove any
	element then size changes and foreach loop will fail.but in case of for loop condition will be modified every time
	*/
}


Console.WriteLine("================================================================================");
Console.WriteLine("Date Time");

var dt = DateTime.Now;
var time = dt.ToLongTimeString();
Console.WriteLine("long time:{0}",time);
var date = dt.ToLongDateString();
Console.WriteLine("long date:{0}",date);

var stime = dt.ToShortTimeString();
Console.WriteLine("short time:{0}", stime);
var sdate = dt.ToShortDateString();
Console.WriteLine("short date:{0}", sdate);


var ts = new TimeSpan(1, 2, 10);
ts=ts.Subtract(new TimeSpan(0, 2, 0));//timespan is immutable
Console.WriteLine(ts);
Console.WriteLine(TimeSpan.Parse("01:09:52"));//converts string to timespan

Console.WriteLine("================================================================================");
Console.WriteLine("strings");
//stringbuilder is optimised for manipulation of a string but not for searching operations
int a = '9' - '0';//converts '9' to 9 i.e. character 9 to int 9
Console.WriteLine(a);

var builder = new StringBuilder();
builder
	.Append("abcd")
	.Insert(2, "pqr");
//both Append() and Insert() will be applied to builder
Console.WriteLine(builder);
Console.WriteLine(new String('a',9));

Console.WriteLine("================================================================================");
Console.WriteLine("File");
//File contains all static methods BUT FileInfo has instance methods
var create = Directory.CreateDirectory(@"C:\Users\Coditas\Desktop\Demo Folder");
var files = Directory.GetFiles(@"C:\Users\Coditas\Desktop\Demo Folder","*.*",SearchOption.AllDirectories);
//	*.*		will iterate through all folders and subfolders
//	we can replace second star with extension that we need to search

foreach (var file in files)
{
	Console.WriteLine(file);
}