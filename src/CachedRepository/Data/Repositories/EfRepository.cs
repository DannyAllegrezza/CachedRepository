using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CachedRepository.Data.Repositories
{
	public class EfRepository<T> : IRepository<T> where T : class
	{
		private readonly SqliteDbContext _dbContext;

		public EfRepository(SqliteDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public T Add(T entity)
		{
			_dbContext.Set<T>().Add(entity);
			_dbContext.SaveChanges();

			return entity;
		}

		public void Delete(T entity)
		{
			_dbContext.Set<T>().Remove(entity);
			_dbContext.SaveChanges();
		}

		public IEnumerable<T> GetAll()
		{
			return _dbContext.Set<T>().AsEnumerable();
		}

		public void Update(T entity)
		{
			_dbContext.Entry(entity).State = EntityState.Modified;
			_dbContext.SaveChanges();
		}
	}
}
