using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow_engine
{

    public class WorkFlow : IWorkflow
    {
        private readonly List<IServices> _tasks;

        public WorkFlow()
        {
            _tasks = new List<IServices>();
        }


        public void AddServices(IServices obj)
        {
            _tasks.Add(obj);
        }


        public void RemoveServices(IServices obj)
        {
            _tasks.Remove(obj);
        }

        public void Show()
        {
            foreach (var item in _tasks)
            {
                item.Execute();
            }
        }
    }
}
