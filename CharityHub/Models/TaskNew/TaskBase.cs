namespace TestConsole.TaskNew
{

    abstract class TaskBase
    {
        protected string Title { get; }
        protected string Description { get;  }
        protected DateTime CreationDate { get; }
        protected DateTime DeadLine { get; }

        //public bool IsClosed { get; set; }
        //public DateTime ClosingDate { get; set; } 

        protected TaskBase()
        {
             
        }


    }
}
