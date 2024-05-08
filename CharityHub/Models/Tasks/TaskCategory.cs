namespace CharityHub.Models.Tasks
{
    class TaskCategory : TaskBase
    {
        private List<TaskBase> _requests;

        public TaskCategory()
        {
            _requests = new List<TaskBase>();
        }

        public override void Create()
        {

        }

        public override TaskBase GetInfo()
        {
            return this;
        }
    }
}
