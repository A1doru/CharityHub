using System.ComponentModel.DataAnnotations;

namespace CharityHub.DBContext
{
    public class TaskContext
    {
        [Key]
        public int? Id { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public bool? IsClosed { get; set; }
        public string? Type { get; set; }

        //поля для SocialActivity
        public string? SocialLink { get; set; }

        //поля для PhysicalActivity
        public string? Location { get; set; }

        public DateTime? Date { get; set; }

        //поля для Fundraisng
        public string? BankId { get; set; }

        public int? SumAmount { get; set; }
        public int? CreatorId { get; set; }
    }
}