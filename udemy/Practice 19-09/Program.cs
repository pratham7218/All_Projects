class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }

    public void DrawNormal()
    {
        Console.WriteLine("Drawing a normal shape");

    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }

    public void DrawNormal()
    {
        Console.WriteLine("Drawing a normal Circle");

    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Reactangle");
    }

    public void DrawNormal()
    {
        Console.WriteLine("Drawing a normal Reactangle");

    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }

    public void DrawNormal()
    {
        Console.WriteLine("Drawing a normal Square");

    }
}

class Caller
{
    static void Main(string[] args)
    {
        Circle c = new Circle();
        Rectangle r = new Rectangle();
        Square s = new Square();

        Shape c1 = new Circle();
        Shape c2 = new Rectangle();


        c.Draw();//Calls overriden method in respective class
        r.Draw();//Calls overriden method in respective class
        s.Draw();//Calls overriden method in respective class
        //==============================================================
        c1.Draw();//Calls Overridden
        c1.DrawNormal();//Calls method in Shape class
        //==============================================================
        c2.DrawNormal();//Calls method in Shape class
        //==============================================================
        Shape shape = new Shape();
        shape.Draw();//Calls method in Shape class


        //var cr = new Circle();
        //cr.DrawNormal();

        Console.WriteLine("==========================================================");
        DateTime dt = DateTime.Now.AddMinutes(5.0);

        DateTime dt1 = DateTime.Now;

        TimeSpan TS = dt - dt1; 

    }
}