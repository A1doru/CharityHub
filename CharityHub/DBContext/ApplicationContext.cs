using System.ComponentModel.DataAnnotations;

namespace CharityHub.DBContext
{
    public class ApplicationContext
    {
        [Key]
        public int Id { get; set; }

        public int? TaskId { get; set; }
        public int UserId { get; set; }
        public bool InProgress { get; set; }
    }
}