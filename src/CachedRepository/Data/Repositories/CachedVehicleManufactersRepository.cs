using CachedRepository.Data.Models;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;

namespace CachedRepository.Data.Repositories
{
	public class CachedVehicleManufactersRepository : IRepository<VehicleManufacturer>
	{
		private readonly VehicleManufacturersRepository _repository;
		private readonly IMemoryCache _cache;

		private const string CacheKey = "Manufacturers";
		private MemoryCacheEntryOptions _cacheOptions;

		public CachedVehicleManufactersRepository(VehicleManufacturersRepository repository, IMemoryCache cache)
		{
			_repository = repository;
			_cache = cache;

			// Setup the cache config
			_cacheOptions = new MemoryCacheEntryOptions()
				.SetAbsoluteExpiration(relative: TimeSpan.FromSeconds(5));
		}

		public IEnumerable<VehicleManufacturer> GetAll()
		{
			return _cache.GetOrCreate(CacheKey, entry =>
			{
				entry.SetOptions(_cacheOptions);
				return _repository.GetAll();
			});
		}

		public VehicleManufacturer Add(VehicleManufacturer entity)
		{
			throw new NotImplementedException();
		}

		public void Update(VehicleManufacturer entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(VehicleManufacturer entity)
		{
			throw new NotImplementedException();
		}
	}
}
