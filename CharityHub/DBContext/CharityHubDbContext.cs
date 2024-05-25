using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Configuration;

namespace CharityHub.DBContext
{
    class CharityHubDbContext : DbContext
    {
        public DbSet<UserContext> Users { get; set; }
        public DbSet<TaskContext> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCharityHub"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString).LogTo(Console.WriteLine, LogLevel.Information); ;
        }
    }
}