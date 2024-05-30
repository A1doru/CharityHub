using CharityHub.Commands;
using CharityHub.Commands.TaskListingCommands;
using CharityHub.DBContext;
using CharityHub.Models.Users;
using CharityHub.Navigation;
using CharityHub.ViewModels.MainMenuViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace CharityHub.ViewModels.TaskListingViewModels
{
    public class OrganizationTaskOpenedViewModel : ViewModelBase
    {
        private CharityHubDbContext dbContext;

        public ObservableCollection<TaskContext> Tasks { get; set; }

        private async void LoadTasks()
        {
            try
            {
                var tasks = await dbContext.Tasks.Where(t => t.CreatorId == UserSession.Instance.CurrentUser.Id && 
                                                             t.IsClosed == false).ToListAsync();
                Tasks.Clear();
                foreach (var task in tasks)
                {
                    Tasks.Add(task);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ICommand CloseCommand { get; }
        public ICommand BackCommand { get; }

        public OrganizationTaskOpenedViewModel(NavigationStore navigationStore)
        {
            dbContext = new CharityHubDbContext();
            Tasks = new ObservableCollection<TaskContext>();
            LoadTasks();
            BackCommand = new NavigationCommand(navigationStore, () => new MainMenuCharityOrganizationViewModel(navigationStore));
            CloseCommand = new CloseCommand();
        }
    }
}