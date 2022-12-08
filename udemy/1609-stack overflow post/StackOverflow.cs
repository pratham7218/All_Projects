class StackOverflow
{

    private string _title;
    public string title {
        get
        {
            return _title;
        } 
        set
        {
            _title = value;
        } }


    
    
    private string _description;
    public string description { get
        {
            return _description;
        }
        set
        {
            _description = value;
        } }

    
    
    private DateTime creationInfo =DateTime.Now;

    
    
    private int count = 0;

    
    
    public void UpVote()
    {
        count++;
    }

    public void DownVote()
    {
        count--;
    }

    void Display()
    {
        Console.WriteLine("====================================================");
        Console.WriteLine($"Title of your page is: {_title}");
        Console.WriteLine($"Description of your page is: {_description}");
        Console.WriteLine($"Total number of votes on this post are: {count}");
        Console.WriteLine($"Creation date of post: {creationInfo.ToString("D")}");
        Console.WriteLine($"Creation time of post: {creationInfo.ToString("hh:mm tt")}");

        Console.WriteLine("====================================================");
    }
    static void Main(string[] args)
    {

        //obj.title = "My First Project";
        //obj.description = "First project was very neat and clean to understand";
        //obj.UpVote();
        //obj.DownVote();

        //obj.Display();

        
        do
        {
            Console.WriteLine("Let's create new post!!!! Are you ready??");
            string input = Console.ReadLine();
            int flag = 0;
            switch (input)
            {
                case "yes":
                    string wish = "y";
                    do
                    {
                        StackOverflow obj = new StackOverflow();

                        Console.WriteLine();
                        Console.WriteLine("Enter Title");
                        obj._title = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Enter Description of post");
                        obj._description = Console.ReadLine();


                        string cont = "yes";
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("Press 1 to upvote and 0 to downvote");
                            int choice = Convert.ToInt32(Console.ReadLine());

                            if (choice == 1)
                            {
                                obj.UpVote();
                            }
                            else if (choice == 0)
                            {
                                obj.DownVote();
                            }

                            Console.WriteLine("Do you wish to continue voting to post");
                            cont = Console.ReadLine();
                        } while (cont == "yes" ||cont== "Yes");

                        Console.WriteLine();
                        obj.Display();
                        Console.WriteLine(@"Do you want to continue?
If yes,Press yes or Yes");
                        wish = Console.ReadLine();
                        Console.Clear();
                    } while (wish == "yes" || wish=="Yes");
                    break;

                case "no":
                    flag = 1;
                    break;
            }

            if (flag==1)
            {
                break;
            }
        } while (true);
    }
}