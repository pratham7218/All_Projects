class Staff
{
    int i = 0;
    
    public void Exception1()
    {
        try
        {
            if (i == 0)
            {
                throw new Exception("i is 0");
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
}
//class Doctor : Staff
//{

//}
//class Nurse : Staff
//{

//}

//class Technician : Staff
//{

//}


class MyExceptions : Exception // Custom exception
{
    public void Exception1(string msg) 
    {
        try
        {
            throw new Exception(msg);
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
}

class MyClass
{

    public int Number { get; set; }
    static void Main(string[] args)
    {

        //Staff dr = new Doctor();
        //Staff nr = new Nurse();
        //Staff tc = new Technician();


        //if (dr is Staff)
        //{
        //    Console.WriteLine("Is of same type");
        //}
        //else
        //{
        //    Console.WriteLine("Is of diff types");
        //}





        //if (nr is Nurse)
        //{
        //    Console.WriteLine("Is of same type");
        //}
        //else
        //{
        //    Console.WriteLine("Is of diff types");
        //}






        //if (Object.ReferenceEquals(dr,nr))
        //{
        //    Console.WriteLine("same type");
        //}
        //else
        //{
        //    Console.WriteLine("diff type");
        //}

        
        MyClass obj = new MyClass();

        obj.Number = 1732;//Setting a property 

        //Doctor dr = new Doctor();
        //dr.Exception1();

        Staff st = new Staff();

        MyExceptions exceptions = new MyExceptions();
        exceptions.Exception1("Hii this is custom exception");
        
        
    }

}