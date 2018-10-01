using CachedRepository.Data;
using CachedRepository.Data.Models;
using CachedRepository.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CachedRepository.Configuration
{
	/// <summary>
	/// Using this pattern of moving your ASP.NET Core Startup configuration into extension classes 
	/// is really useful. It keeps a nice, separation of concerns and cleans up your "ConfigureServices"
	/// method.
	/// </summary>
	public static class ConfigureServicesExtensions
	{
		public static IServiceCollection ConfigureDatabase(this IServiceCollection services, IConfiguration config)
		{
			//services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
			services.AddScoped<IRepository<VehicleManufacturer>, CachedVehicleManufactersRepository>();
			services.AddScoped(typeof(EfRepository<>));
			services.AddScoped<VehicleManufacturersRepository>();

			services.AddEntityFrameworkSqlite();

			var connectionString = config.GetConnectionString("VehicleManufacturers");

			services.AddDbContext<SqliteDbContext>(
				options => options.UseSqlite(connectionString));

			return services;
		}
	}
}
