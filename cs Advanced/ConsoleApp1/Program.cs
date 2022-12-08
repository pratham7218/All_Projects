using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class MyClass
{
    //public delegate void first(int x,int y);
    //public event first AddMyEvent;



    //static void Add(int a , int b)
    //{
    //    Console.WriteLine(a+b);
    //}

    //static void mul(int a , int b)
    //{
    //    Console.WriteLine(a*b);
    //}
    //public MyClass()
    //{
        //AddMyEvent += mul;

        //AddMyEvent += Add;

    //}


    public static short ActionDemo(short a,short b)
    {
        Console.WriteLine("Action demo method...!!!");
        return a;
    }

    //Predicate fn: Is a fn that takes some input and returns boolean value
    static bool LessThan5(int a)
    {
        return a < 5;
    }


    static event Action<string, string> EventWithoutDelegate;
    static void MethodForEventWithoutDelegate(string a , string b)
    {
        Console.WriteLine("This is method for \"just event\" without delegate.");
    }


    static event Func<string, int,string> JustEventWithReturnType;
    public static string JustEventWithReturnTypeMethod(string a, int b)
    {
        return $"{a} is the string returned with just event.";
    }

    static void Main(string[] args)
    {
        
        //MyClass obj = new MyClass();
        //obj.AddMyEvent(12,13);

        //first DelegateObj = new first(mul);
        //DelegateObj(8, 9);


        //Action<Int16,Int16> obj1 = ActionDemo;        //Action<> has void return type
        //obj1(3,4);


        Func<Int16, Int16, Int16> action = ActionDemo;  //Function<> has void return type
        action(1,2);


        //Lambda expression
        Func<int,int> square = number=>number*number;
        Console.WriteLine(square(12));


        Func<int, int, int> add = (num1,num2) => num1+num2;
        Console.WriteLine(add(12, 13));


        List<int> list = new List<int> { 11, 4, 2, 4, 5, 6, 1, 0 };

        List<int> smallerElements =list.FindAll(number => number<5);
        //List<int> smallerElements =list.FindAll(LessThan5);


        foreach (var item in smallerElements)
        {
            Console.WriteLine(item);
        }


        EventWithoutDelegate += MethodForEventWithoutDelegate;
        EventWithoutDelegate("a", "b");


        JustEventWithReturnType += JustEventWithReturnTypeMethod;
        Console.WriteLine(JustEventWithReturnType("abc", 2));
    }
}