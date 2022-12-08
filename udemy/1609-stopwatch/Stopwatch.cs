class Stopwatch
{

    private DateTime _start;

    private TimeSpan _duration;

    void Reset()
    {
        _start = DateTime.MinValue;
    }
    public void start()
    {
        int flag = 0;
        if (_start != DateTime.MinValue)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Can't start again...Watch has already started!!!");
            flag = 1;
        }

        if (flag == 0)
        {
            _start = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Timer started!!!");
        }
    }

    public void end()
    {
        if (_start == DateTime.MinValue)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Watch hasn't been started yet!!!");
        }
        else
        {
            _duration = DateTime.Now - _start;
            Reset();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Total duration is {_duration.Hours}:{_duration.Minutes}:{_duration.Seconds}Hours");
        }


    }
    static void Main(string[] args)
    {

        Stopwatch watch = new Stopwatch();

        string instruction = "start";
        while (instruction == "start" || instruction == "stop")
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter \"start\" to Start timer & Enter \"stop\" to stop the timer");
            instruction = Console.ReadLine();

            switch (instruction)
            {
                case "start":
                    watch.start();
                    break;

                case "stop":
                    watch.end();
                    break;

            }


        }


    }
}