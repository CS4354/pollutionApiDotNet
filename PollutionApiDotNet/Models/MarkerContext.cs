using Microsoft.EntityFrameworkCore;

namespace PollutionApiDotNet.Models
{
    public class MarkerContext : DbContext
    {
        public MarkerContext(DbContextOptions<MarkerContext> options)
            : base(options)
        {
        }

        public DbSet<Marker> Markers { get; set; }
    }
}
