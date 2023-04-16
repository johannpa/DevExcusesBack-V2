using Microsoft.EntityFrameworkCore;

namespace DevExcusesBackV2.Models
{
    public class ExcuseDbContext : DbContext
    {
        public ExcuseDbContext(DbContextOptions<ExcuseDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress; Database=minimalexcusebd; Trusted_Connection=True;TrustServerCertificate=true;");
        }
        public DbSet<Excuse> Excuses => Set<Excuse>();
    }
}
