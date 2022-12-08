//HashSet<int> hs = new HashSet<int>();
//hs.Add(0);
//hs.Add(1);
//hs.Add(2);
//hs.Add(0);

//List<int> hs2 = new List<int>(hs);

//foreach (var item in hs2)
//{
//    Console.WriteLine(item);
//}


class MyClass
{
    public string myName;
    public void Introduce(string name)
    {
        Console.WriteLine($"My name is {name}");
    }

    public static MyClass Name(string name)
    {
        MyClass myClass = new MyClass();
        myClass.myName = name;
        return myClass;
    }
//=========================================================================================
    public string overloaded(string str,int i)
    {
        return str;
    }

    public void overloaded(string str)
    {
        Console.WriteLine($"void");
    }
//=========================================================================================
public void Add(params int[] numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        Console.WriteLine(sum);
    }

//=========================================================================================

    static void Main(string[] args)
    {
        MyClass obj = new MyClass();

        //var name = MyClass.Name("Prathamesh");
        // name.Introduce("Piyush");


        //obj.overloaded("abc");
        //Console.WriteLine(obj.overloaded("abc"));

        //obj.Add(new int[] {1,2,3,4,5});
        //obj.Add(1, 2, 3, 4, 5);
        
    }
}