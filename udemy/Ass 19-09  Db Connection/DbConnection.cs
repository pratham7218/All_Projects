using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public abstract class DbConnection 
    {
        internal string _connectionString;
        public string ConnectionString { get
            {
                return _connectionString;
            }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(_connectionString))
                    {
                        throw new ArgumentException("Can not have null or empty string...!!!");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            } 
        }

        public abstract void OpenConnection(string str);

        public abstract void CloseConnection(string str);
    }
}
