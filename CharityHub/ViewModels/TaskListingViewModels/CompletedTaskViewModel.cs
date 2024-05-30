using CharityHub.DBContext;
using CharityHub.Models.Users;
using CharityHub.Navigation;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Windows;

namespace CharityHub.ViewModels.TaskListingViewModels
{
    public class CompletedTaskViewModel : ViewModelBase
    {
        private CharityHubDbContext dbContext;

        public ObservableCollection<TaskContext> Tasks { get; set; }

        private async void LoadTasks()
        {
            try
            {
                var tasks = await dbContext.Tasks.Where(t => t.Id == UserSession.Instance.CurrentUser.Id && t.IsClosed == false)
                                                 .ToListAsync();
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

        public CompletedTaskViewModel(NavigationStore navigationStore)
        {
            dbContext = new CharityHubDbContext();
            Tasks = new ObservableCollection<TaskContext>();
            LoadTasks();
        }
    }
}