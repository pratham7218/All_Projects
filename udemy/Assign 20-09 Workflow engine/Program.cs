using Workflow_engine;

WorkFlow flow = new WorkFlow();
flow.AddServices(new SendMessage());
flow.AddServices(new SendMail());
flow.AddServices(new CallService());
flow.AddServices(new SendLetter());

flow.Show();