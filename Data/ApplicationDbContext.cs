using Microsoft.EntityFrameworkCore;
using Person.Models;

namespace Person.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
		public DbSet<Family> Families { get; set; }
    }
}
