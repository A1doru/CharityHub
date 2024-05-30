using CharityHub.Commands.TaskListingCommands;
using CharityHub.DBContext;
using CharityHub.Navigation;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace CharityHub.ViewModels.TaskListingViewModels
{
    public class TaskListingViewModel : ViewModelBase
    {
        private CharityHubDbContext dbContext;

        public ObservableCollection<TaskContext> Tasks { get; set; }

        private async void LoadTasks()
        {
            try
            {
                var tasks = await dbContext.Tasks.ToListAsync();
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

        public ICommand ApplyCommand { get; }

        public TaskListingViewModel(NavigationStore navigationStore)
        {
            dbContext = new CharityHubDbContext();
            Tasks = new ObservableCollection<TaskContext>();
            LoadTasks();
            ApplyCommand = new ApplyCommand(navigationStore);
        }
    }
}