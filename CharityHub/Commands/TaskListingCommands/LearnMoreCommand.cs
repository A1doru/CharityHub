using CharityHub.DBContext;
using CharityHub.Navigation;
using CharityHub.ViewModels.TaskApplyViewModels;
using System.Windows;

namespace CharityHub.Commands.TaskListingCommands
{
    public class LearnMoreCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public LearnMoreCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            if (parameter is TaskContext selectedTask)
            {
                if(selectedTask.Type == "Fundraising") _navigationStore.CurrentViewModel = new FundraisingApplyViewModel(selectedTask, _navigationStore);
                else if(selectedTask.Type == "PhysicalActivity") _navigationStore.CurrentViewModel = new PhysicalActivityApplyViewModel(selectedTask, _navigationStore);
                else if(selectedTask.Type == "SocialActivity") _navigationStore.CurrentViewModel = new SocialActivityApplyViewModel(selectedTask, _navigationStore);
                else
                {
                    MessageBox.Show("Incorrect task type");
                }
            }
        }
    }
}