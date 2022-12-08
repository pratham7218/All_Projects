using DatabaseConnection;

//SqlConnection obj = new SqlConnection("SQL");

//obj.OpenConnection("SQL");
//obj.CloseConnection("SQL");


//OracleConnection obj2 = new OracleConnection("Oracle");

//obj2.OpenConnection("");
//obj2.CloseConnection("Oracle");


string wish = "y";
do
{
    Console.WriteLine("Press 1 for SQL");
    Console.WriteLine("Press 2 for oracle");
    TimeSpan duration;



    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            SqlConnection obj = new SqlConnection("SQL");

            string inner = "y";
            do
            {
                Console.WriteLine("Press 1 to open the connection");
                Console.WriteLine("Press 2 to close the connection");

                int innerChoice = Convert.ToInt32(Console.ReadLine());
                DateTime pgmStart = DateTime.Now;

                switch (innerChoice)
                {

                    case 1:
                        Console.WriteLine("Enter a string to open connection");
                        string str = Console.ReadLine();
                        //obj.OpenConnection(str);

                        DateTime openSql = DateTime.Now;

                        TimeSpan sqlDuration = openSql - pgmStart;

                        try
                        {
                            if (sqlDuration >= new TimeSpan(0, 0, 5))
                            {
                                //obj.OpenConnection(str);
                                throw new Exception("Connection timed out...!!!");
                            }
                            else
                            {
                                obj.OpenConnection(str);
                                sqlDuration = new TimeSpan(0,0,0);
                            }
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter a string to close connection");
                        string str1 = Console.ReadLine();
                        openSql = DateTime.MinValue;
                        obj.CloseConnection(str1);
                        break;
                }

                Console.WriteLine("Do you want to continue with SQL?");
                inner = Console.ReadLine();
                Console.Clear();

            } while (inner == "y" || inner == "Y");
            break;


        case 2:
            OracleConnection obj1 = new OracleConnection("Oracle");

            string inner1 = "y";
            do
            {
                Console.WriteLine("Press 1 to open the connection");
                Console.WriteLine("Press 2 to close the connection");

                int innerChoice = Convert.ToInt32(Console.ReadLine());

                DateTime pgmStart = DateTime.Now;

                switch (innerChoice)
                {
                    case 1:
                        Console.WriteLine("Enter a string to open connection");
                        string str = Console.ReadLine();
                        DateTime openOracle = DateTime.Now;

                        TimeSpan oracleDuration = openOracle - pgmStart;

                        try
                        {
                            if (oracleDuration >= new TimeSpan(0, 0, 5))
                            {
                                throw new Exception("Connection timed out...!!!");
                            }
                            else
                            {
                                obj1.OpenConnection(str);
                            }
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter a string to close connection");
                        string str1 = Console.ReadLine();
                        openOracle = DateTime.MinValue;

                        obj1.CloseConnection(str1);
                        break;
                }

                Console.WriteLine("Do you want to continue with Oracle?");
                inner1 = Console.ReadLine();
                Console.Clear();

            } while (inner1 == "y" || inner1 == "Y");
            break;
    }

    Console.WriteLine("Do you want to continue?");
    wish = Console.ReadLine();
    Console.Clear();

} while (wish=="y" || wish == "Y");