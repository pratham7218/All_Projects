
//class MyClass
//{


//    //int[] arr = new int[10];
//    //int index=0;
//    static List<int> list = new List<int>();

//    static int flag = 0;

//    public static int myFunc(int num)
//    {
//        static void Digits(int num)
//        {


//            int rem;
//            while (num > 0)
//            {
//                rem = num % 10;
//                num /= 10;

//                if (!list.Contains(rem))
//                {

//                    list.Add(rem);
//                }
//                if (list.Count == 10)
//                {
//                    flag = 1;
//                    break;
//                }
//            }
//        }

//        int multiplication;
//        int i = 0;
//        for (i = 1; i <= 10; i++)
//        {
//            multiplication = num * i;
//            Digits(multiplication);
//            if (flag == 1)
//            {
//                break;
//            }
//        }

//        return i;
//    }

//    static void Main(string[] args)
//    {
//        ////MyClass obj = new MyClass();
//        Console.WriteLine(myFunc(42));
//    }
//}

//Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();

//string str = "abab";
//int count = 0;
//for (int i = 0; i<str.Length; i++)
//{
//	if (keyValuePairs.ContainsKey(str[i]))
//	{
//		count = keyValuePairs[str[i]];
//		keyValuePairs[str[i]] = ++count;

//	}
//	else
//	{
//		keyValuePairs.Add(str[i], 1);
//	}
//}


//foreach (var item in keyValuePairs.Keys)
//{
//	Console.WriteLine(item + " "+ keyValuePairs[item]);
//}

using System.IO.IsolatedStorage;

class MyClass
{
    int flag = 0;
    static readonly object locker = 1;
 
    static void WriteX()
    {
        lock (locker)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i + " ");
            }
        }
    }


    void WriteY()
    {
        lock (locker)
        {
            if (flag == 0)
            {
                flag = 1;
                for (int i = 0; i < 100; i++)
                {

                    Console.Write($"{i} ");
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Thread t = new Thread(WriteX);
        t.Start();

        Thread t2 = new Thread(WriteX);
        t2.Start();

        //for (int i = 0; i < 100; i++)
        //{
        //    Console.Write("y ");
        //}
        //Console.WriteLine();
        ////Console.WriteLine("====================================================");
        ////Console.WriteLine();

        //MyClass obj = new MyClass();
        //MyClass obj2 = new MyClass();

        //new Thread(obj.WriteY).Start();
        //obj2.WriteY();
    }
}
