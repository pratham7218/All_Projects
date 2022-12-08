using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Workflow_engine
{

    public class SendMessage : IServices
    {
        public void Execute()
        {
            Console.WriteLine("Sending msg...");
        }
    }

    public class SendMail : IServices
    {
        public void Execute()
        {
            Console.WriteLine("Sending mail...");
        }
    }

    public class CallService : IServices
    {
        public void Execute()
        {
            Console.WriteLine("Calling service...");
        }
    }

    public class SendLetter : IServices
    {
        public void Execute()
        {
            Console.WriteLine("Letter sent...");
        }
    }
}
