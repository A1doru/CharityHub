using CharityHub.Navigation;
using CharityHub.ViewModels.CreatingTaskViewModels;

namespace CharityHub.Commands.TaskCreatingCommands
{
    internal class CreatingTaskSelectorCommand : CommandBase
    {
        private CreatingTaskBaseViewModel _creatingTaskBase;
        private NavigationStore _navigationStore;

        public CreatingTaskSelectorCommand(CreatingTaskBaseViewModel creatingTaskBase, NavigationStore navigationStore)
        {
            _creatingTaskBase = creatingTaskBase;
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            switch (_creatingTaskBase.TaskType)
            {
                case Shared.TaskType.SocialActivity:
                    _navigationStore.CurrentViewModel = new CreatingSocialViewModel(_navigationStore);
                    break;

                case Shared.TaskType.PhysicalActivity:
                    _navigationStore.CurrentViewModel = new CreatingPhysicalViewModel(_navigationStore);
                    break;

                case Shared.TaskType.Fundraising:
                    _navigationStore.CurrentViewModel = new CreatingFundraisingViewModel(_navigationStore);
                    break;
            }
        }
    }
}