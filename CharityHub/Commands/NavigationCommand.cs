using CharityHub.Navigation;
using CharityHub.ViewModels;

namespace CharityHub.Commands
{
    internal class NavigationCommand : CommandBase
    {
        private NavigationStore _navigationStore;
        private Func<ViewModelBase> _createViewModel;

        public NavigationCommand(NavigationStore navigationStore, Func<ViewModelBase> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}