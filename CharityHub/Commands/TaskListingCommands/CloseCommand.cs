using CharityHub.DBContext;

namespace CharityHub.Commands.TaskListingCommands
{
    public class CloseCommand : CommandBase
    {


        public CloseCommand()
        {
            
        }


        public override async void Execute(object? parameter)
        {
            if(parameter is TaskContext task)
            {
                using(var dbContext = new CharityHubDbContext())
                {
                    var closedTask = await dbContext.Tasks.FindAsync(task.Id);
                    if(closedTask != null)
                    {
                        closedTask.IsClosed = true;
                        await dbContext.SaveChangesAsync();
                    }
                }
            }
        }
    }
}
