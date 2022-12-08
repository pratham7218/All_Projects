using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCommand
{
    public class SqlConnection : DbConnection
    {

        public SqlConnection(string str)
        {
            base._connectionString = str;
        }

        int flag = 0;int count = 0;
        public override void OpenConnection(string connection)
        {
         
            if (connection.Equals(base.ConnectionString))
            {

               
                if (count != 0)
                {
                    Console.WriteLine(@"Connection already established...!!!");
                }
                else
                {
                    Console.WriteLine("SQL Connection Established Successfully");
                    flag = 1;
                }
                
                count++;
            }
            else
            {
                flag = 1;
                try
                {
                    throw new Exception("Not a valid open request...!!!");
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }



        }

        public override void CloseConnection(string connection)
        {
            try
            {
                if (flag == 0)
                {
                    throw new Exception("Connection not established yet...!!!");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            
            if (connection.Equals(base.ConnectionString) && flag==1)
            {
                Console.WriteLine("SQL Connection Closed Successfully");
                count = 0;
            }
            else if(!connection.Equals(base.ConnectionString) && flag==1) 
            {
                try
                {
                    throw new Exception("Not a valid close request");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
