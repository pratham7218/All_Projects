using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCommand
{
    public class DatabaseCommand
    {
        private string _instruction;
        public DatabaseCommand(string instruction , DbConnection obj)
        {
            try
            {
                if (string.IsNullOrEmpty(instruction) || (obj == null))
                {
                    throw new Exception("You must enter an instruction...!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            this._instruction = instruction;
        }



       public void Execute()
        {
            Console.WriteLine($"Command {_instruction} successfully executed...!!!");
        }
    }
}
