using CharityHub.DBContext;
using CharityHub.Models.Users;
using CharityHub.Navigation;
using System.Windows;

namespace CharityHub.Commands.TaskListingCommands
{
    class ApplyCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public ApplyCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            if(parameter is TaskContext selcetedTask)
            {
                MessageBox.Show(selcetedTask.Title);

                using(var dbContext = new CharityHubDbContext())
                {
                    var newApplication = new ApplicationContext
                    {
                        TaskId = selcetedTask.Id,
                        UserId = UserSession.Instance.CurrentUser.Id,
                        InProgress = true
                    };
                    dbContext.Applications.Add(newApplication);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
