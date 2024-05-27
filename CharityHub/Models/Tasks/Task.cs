using CharityHub.Models.Users;

namespace CharityHub.Models.Tasks
{
    abstract class Task
    {
        public  int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Creator { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeadlineDate { get; set; }


        //public abstract void CreateTask(string title, string description, DateTime deadlineDate);
    }
}
