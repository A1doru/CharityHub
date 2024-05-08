using CharityHub.Shared;

namespace CharityHub.Models.Tasks
{
    abstract class TaskBase
    {
        string Title {  get; set; }
        string Description { get; set; }
        TaskType _tasktype { get; set; }


        public abstract void Create();
        public abstract TaskBase GetInfo();
        //public abstract void Update();
        //public abstract void Delete();
    }
}
