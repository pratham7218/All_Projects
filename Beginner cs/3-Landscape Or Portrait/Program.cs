Console.WriteLine("Enter Height");
int height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width");
int width = Convert.ToInt32(Console.ReadLine());

var answer = (height==width)?"Square shaped frame":((height > width) ? "Portrait" : "Landscape");
Console.WriteLine(answer);