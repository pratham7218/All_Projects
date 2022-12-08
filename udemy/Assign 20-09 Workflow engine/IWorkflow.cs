namespace Workflow_engine
{
    public interface IWorkflow
    {
        public void AddServices(IServices obj);
        public void RemoveServices(IServices obj);
    }
}
