namespace CharityHub.Models.Tasks
{
    public class TaskManager
    {
        private readonly ITaskFactory _taskFactory;

        public TaskManager(ITaskFactory taskFactory)
        {
            _taskFactory = taskFactory;
        }

        public Fundraising CreateFundraisingTask(string title, string description, DateTime dueDate, string bankId, int targetAmount)
        {
            return _taskFactory.CreateFundraisingTask(title, description, dueDate, bankId, targetAmount);
        }

        public SocialActivity CreateSocialActivityTask(string title, string description, DateTime dueDate, string location)
        {
            return _taskFactory.CreateSocialTask(title, description, dueDate, location);
        }

        public PhysicalActivity CreatePhysicalActivityTask(string title, string description, DateTime dueDate, string location, DateTime date)
        {
            return _taskFactory.CreatePhysicalTask(title, description, dueDate, location, date);
        }
    }
}