
namespace CharityHub.Models.Tasks
{
    class TaskFactory : ITaskFactory
    {
        public Fundraising CreateFunraisingTask(string title, string description, DateTime deadlineDate, string bankId, int SumAmount)
        {
            return new Fundraising
            {
                Title = title,
                Description = description,
                DeadlineDate = deadlineDate,
                BankId = bankId,
                SumAmount = SumAmount
            };
        }

        public PhysicalActivity CreatePhysicalTask(string title, string description, DateTime deadlineDate, string location, DateTime date)
        {
            return new PhysicalActivity
            {
                Title = title,
                Description = description,
                DeadlineDate = deadlineDate,
                Location = location,
                Date = date
            };
        }

        public SocialActivity CreateSocialTask(string title, string description, DateTime deadlineDate, string Link)
        {
            return new SocialActivity
            {
                Title = title,
                Description = description,
                DeadlineDate = deadlineDate,
                SocialLink = Link
            };
        }
    }
}
