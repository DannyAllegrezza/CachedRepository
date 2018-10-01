using CachedRepository.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CachedRepository.Data.Repositories
{

	public class VehicleManufacturersRepository : EfRepository<VehicleManufacturer>
	{
		private SqliteDbContext _dbContext;
		public VehicleManufacturersRepository(SqliteDbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}

		/// <summary>
		/// NOTE: We are eager loading here
		/// SEE: https://ardalis.com/avoid-lazy-loading-entities-in-asp-net-applications
		/// Get all of the Manufacturers and their associated Models
		/// </summary>
		/// <returns></returns>
		public override IEnumerable<VehicleManufacturer> GetAll()
		{
			return _dbContext.Manufacturers
						.Include(m => m.Models)
						.ToList();
		}
	}
}
