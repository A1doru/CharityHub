namespace CharityHub.Models.Tasks
{
    public interface ITaskFactory
    {
        Fundraising CreateFundraisingTask(string title, string description, DateTime deadlineDate, string bankId, int SumAmount);
        SocialActivity CreateSocialTask(string title, string description, DateTime deadlineDate, string Link);
        PhysicalActivity CreatePhysicalTask(string title, string description, DateTime deadlineDate, string location, DateTime date);
    }
}
