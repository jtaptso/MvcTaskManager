using Microsoft.EntityFrameworkCore;

namespace MvcTaskManager.Models
{
    public class TaskManagerDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source=TAPTSO\\JTAPTSOSQLSERVER; integrated security=yes; initial catalog=TaskManagerDatabase");
        }

    }

}
