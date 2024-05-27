namespace CharityHub.Models.Tasks
{
    interface ITaskFactory
    {
        Fundraising CreateFunraisingTask(string title, string description, DateTime deadlineDate, string bankId, int SumAmount);
        SocialActivity CreateSocialTask(string title, string description, DateTime deadlineDate, string Link);
        PhysicalActivity CreatePhysicalTask(string title, string description, DateTime deadlineDate, string location, DateTime date);
    }
}
