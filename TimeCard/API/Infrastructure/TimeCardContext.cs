using Microsoft.EntityFrameworkCore;
using TimeCard.API.Model;

namespace TimeCard.API.Infrastructure
{
    public class TimeCardContext : DbContext
    {
        public DbSet<TimeCards> TimeCard { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:morashportal.database.windows.net,1433;Initial Catalog=TimeCardDb;Persist Security Info=False;User ID=rmoli082;Password=Po19830797rn;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

    }
}
