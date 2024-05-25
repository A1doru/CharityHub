using System.Windows;
using System.Windows.Controls;


namespace CharityHub.ViewModels.CreatingTaskViewModels
{
    public class TaskTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FundRaisingTemplate { get; set; }
        public DataTemplate PhysicalActivityTemplate { get; set; }
        public DataTemplate SocialActivityTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is FundRaising)
                return FundRaisingTemplate;
            else if (item is PhysicalActivity)
                return PhysicalActivityTemplate;
            else if (item is SocialActivity)
                return SocialActivityTemplate;

            // Вернуть null или шаблон по умолчанию, если тип не найден
            return base.SelectTemplate(item, container);
        }
    }

    public class TaskBase
    {
        // Общие свойства для всех задач
    }

    public class FundRaising : TaskBase
    {
        public string Amount { get; set; }
        public string Description { get; set; }
        //public ICommand SubmitCommand { get; set; }
    }

    public class PhysicalActivity : TaskBase
    {
        public string ActivityName { get; set; }
        public string Duration { get; set; }
        // public ICommand StartCommand { get; set; }
    }

    public class SocialActivity : TaskBase
    {
        public string EventName { get; set; }
        public string Location { get; set; }
        public DateTime EventDate { get; set; }
        //public ICommand JoinCommand { get; set; }
    }
}