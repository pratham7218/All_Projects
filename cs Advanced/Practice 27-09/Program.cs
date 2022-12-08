List<int> list = new List<int>
{
    11,20,93, 43, 75, 63, 27,83,52
};


var cheaper = from num in list where num > 45 select num;

//var cheap = list.Where(e=>e>45).OrderBy(e=>e);
var cheap = list.Where(e => e > 45).OrderBy(e => e).Skip(2);

//cheap = cheap.OrderBy(e=>e);

foreach (var item in cheap)
{
    Console.WriteLine(item);
}


var getSingleNumber = list.Single(a => a > 90);
Console.WriteLine(getSingleNumber);
Console.WriteLine("===========================");


var greater1 = list.Where((a) => a > 45).OrderBy(a => a);
var greater2 = list.OrderBy(e => e).Where(a => a > 45);

foreach (var item in greater1)
{
    Console.WriteLine(item);
}
Console.WriteLine("===========================");
foreach (var item in greater2)
{
    Console.WriteLine(item);
}

Console.WriteLine("===========================");
var isPresent = list.Exists(a=>a==12);
Console.WriteLine(isPresent);