using CharityHub.DBContext;
using System.Windows;

namespace CharityHub.Models.Tasks
{
    public class TaskFactory : ITaskFactory
    {
        private TaskContext _taskContext { get; set; }

        public Fundraising CreateFundraisingTask(string title, string description, DateTime deadlineDate, string bankId, int SumAmount)
        {
            Fundraising newTask = new Fundraising
            {
                Title = title,
                Description = description,
                DeadlineDate = deadlineDate,
                BankId = bankId,
                SumAmount = SumAmount,
                Type = Shared.TaskType.Fundraising
            };
            AddTaskToDB(newTask);
            return newTask;
        }

        public PhysicalActivity CreatePhysicalTask(string title, string description, DateTime deadlineDate, string location, DateTime date)
        {
            PhysicalActivity newTask = new PhysicalActivity
            {
                Title = title,
                Description = description,
                DeadlineDate = deadlineDate,
                Location = location,
                Date = date,
                Type = Shared.TaskType.PhysicalActivity
            };
            AddTaskToDB(newTask);
            return newTask;
        }

        public SocialActivity CreateSocialTask(string title, string description, DateTime deadlineDate, string Link)
        {
            SocialActivity newTask = new SocialActivity
            {
                Title = title,
                Description = description,
                DeadlineDate = deadlineDate,
                SocialLink = Link,
                Type = Shared.TaskType.SocialActivity
            };
            AddTaskToDB(newTask);
            return newTask;
        }

        private void AddTaskToDB(Task task)
        {
            var taskBuilder = new TaskBuilder();
            var taskContext = taskBuilder.WithTask(task).Build();

            if (task != null)
            {
                try
                {
                    using (var connection = new CharityHubDbContext())
                    {
                        connection.Tasks.Add(taskContext);
                        connection.SaveChanges();
                    }
                }
                catch
                {
                    MessageBox.Show("Check your input, please");
                }
            }
        }
    }
}