using CharityHub.Models.Tasks;
using CharityHub.Models.Users;

namespace CharityHub.DBContext
{
    public class TaskBuilder
    {
        private readonly TaskContext _taskContext;

        public TaskBuilder()
        {
            _taskContext = new TaskContext();
        }

        public TaskBuilder WithTask(Models.Tasks.Task task)
        {
            _taskContext.Title = task.Title;
            _taskContext.Description = task.Description;
            _taskContext.CreationDate = task.CreationDate;
            _taskContext.DeadlineDate = task.DeadlineDate;
            _taskContext.IsClosed = false;
            _taskContext.CreatorId = UserSession.Instance.CurrentUser.Id;
            _taskContext.Type = task.Type.ToString();
            _taskContext.Date = null;

            if (task is Fundraising fundraisingTask)
            {
                _taskContext.BankId = fundraisingTask.BankId;
                _taskContext.SumAmount = fundraisingTask.SumAmount;
            }
            else if (task is PhysicalActivity physicalTask)
            {
                _taskContext.Location = physicalTask.Location;
                _taskContext.Date = physicalTask.Date;
            }
            else if (task is SocialActivity socialTask)
            {
                _taskContext.SocialLink = socialTask.SocialLink;
            }

            return this;
        }

        public TaskContext Build()
        {
            return _taskContext;
        }
    }
}