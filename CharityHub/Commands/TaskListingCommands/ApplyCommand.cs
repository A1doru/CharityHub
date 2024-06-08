using CharityHub.DBContext;
using CharityHub.Models.Users;
using CharityHub.Navigation;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace CharityHub.Commands.TaskListingCommands
{
    public class ApplyCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public ApplyCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            Task.Run(async () =>
            {
                if (parameter is TaskContext selcetedTask)
                {
                    using (var dbContext = new CharityHubDbContext())
                    {
                        var newApplication = new ApplicationContext
                        {
                            TaskId = selcetedTask.Id,
                            UserId = UserSession.Instance.CurrentUser.Id,
                            InProgress = true
                        };
                        if (!await isCreated(newApplication))
                        {
                            dbContext.Applications.Add(newApplication);
                            dbContext.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("You already applied for this task");
                        }
                    }
                }
            }).Wait();
        }

        private async Task<bool> isCreated(ApplicationContext applicationContext)
        {
            using (var dbContext = new CharityHubDbContext())
            {
                return await dbContext.Applications.AnyAsync(a => a.UserId == UserSession.Instance.CurrentUser.Id &&
                                                                  a.TaskId == applicationContext.TaskId);
            }
        }
    }
}