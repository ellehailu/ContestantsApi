using Microsoft.EntityFrameworkCore;

namespace ContestantsApi.Models
{
    public class ContestantsApiContext : DbContext{
        public DbSet<BipContestant> BipContestants { get; set;}

        public ContestantsApiContext(DbContextOptions<ContestantsApiContext> options) : base(options) { 
            
        }
    }
}