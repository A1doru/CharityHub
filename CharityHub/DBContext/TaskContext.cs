using CharityHub.Shared;

namespace CharityHub.DBContext
{
    class TaskContext
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public bool IsClosed { get; set; }
        public TaskType Type { get; set; }
        //поля для SocialActivity
        public string Link { get; set; }
        //поля для PhysicalActivity
        public string Location { get; set; }
        public DateTime Date { get; set; }
        //поля для Fundraisng
        public string BankId { get; set; }
        public int SumAmount { get; set; }

    }
}