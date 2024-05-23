using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace CharityHub.DBContext
{
    class CharityHubDbContext
    {
        class MyDBContext : DbContext
        {
            public DbSet<UserContext> Users { get; set; }
            public DbSet<TaskContext> Tasks { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBCharityHub"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}