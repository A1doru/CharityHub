using CharityHub.Shared;

namespace CharityHub.Models.Tasks
{
    public abstract class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CreatorId { get; set; }

        public DateTime CreationDate = DateTime.Now;
        public DateTime DeadlineDate { get; set; }
        public TaskType Type { get; set; }
        public bool IsClosed { get; set; }
    }
}