using System.Collections.Generic;

namespace CachedRepository.Data.Repositories
{
	public interface IRepository<T> where T : class
	{
		T Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		IEnumerable<T> GetAll();
	}
}
