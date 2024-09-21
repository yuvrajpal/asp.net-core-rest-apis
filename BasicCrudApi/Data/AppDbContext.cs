using Microsoft.EntityFrameworkCore;
using BasicCrudApi.Models;

namespace BasicCrudApi.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
				: base(options)
		{
		}
		public DbSet<User> Users { get; set; }
	}

}