using System.Collections.ObjectModel;

namespace CharityHub.ViewModels.MainMenuViewModels
{
    internal class MainMenuViewModel : ViewModelBase
    {
        public ObservableCollection<TaskBase> Tasks { get; set; }

        public MainMenuViewModel()
        {
            Tasks = new ObservableCollection<TaskBase>
            {
                new FundRaising { Amount = "100", Description = "Fundraising for charity"},
                new PhysicalActivity { ActivityName = "Running", Duration = "30 minutes"},
                new SocialActivity { EventName = "Community Meetup", Location = "Park", EventDate = DateTime.Now}
            };
        }
    }
}