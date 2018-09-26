using CachedRepository.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CachedRepository.Data
{
	public class SqliteDbContext : DbContext
	{
		public DbSet<VehicleManufacturer> Manufacturers { get; set; }
		public DbSet<VehicleModel> Models { get; set; }

		public SqliteDbContext(DbContextOptions<SqliteDbContext> options) 
			: base (options)
		{
		}
	}
}
