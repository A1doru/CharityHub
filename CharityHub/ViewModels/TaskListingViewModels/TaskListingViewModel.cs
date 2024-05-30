using CharityHub.Commands;
using CharityHub.Commands.TaskListingCommands;
using CharityHub.DBContext;
using CharityHub.Navigation;
using CharityHub.ViewModels.MainMenuViewModels;
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

        public ObservableCollection<KeyValuePair<string, ISortStrategy>> SortMethods { get; set; }

        private KeyValuePair<string, ISortStrategy> _selectedSortMethod;
        public KeyValuePair<string, ISortStrategy> SelectedSortMethod
        {
            get
            {
                return _selectedSortMethod;
            }
            set
            {
                _selectedSortMethod = value;
                OnPropertyChanged(nameof(SelectedSortMethod));
            }
        }


        public ICommand BackCommand { get; }

        public ICommand LearnModeCommand { get; }

        public TaskListingViewModel(NavigationStore navigationStore)
        {
            dbContext = new CharityHubDbContext();
            Tasks = new ObservableCollection<TaskContext>();
            LoadTasks();
            BackCommand = new NavigationCommand(navigationStore, () => new MainMenuVolunteerViewModel(navigationStore));
            LearnModeCommand = new LearnMoreCommand(navigationStore);
        }
    }
}