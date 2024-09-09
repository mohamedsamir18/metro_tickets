using Microsoft.EntityFrameworkCore;

namespace TicketPricing2.models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Station> Stations { get; set; }
        public DbSet<StationLine> StationsLine { get; set; }
    }
}
