using BethanysPieShop.HRM.Data;
using BethanysPieShop.HRM.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.HRM.Repositories
{
	public class Repository<T> : IRepository<T>, IDisposable where T : class
	{
		protected readonly AppDbContext _appDbContext;
		protected readonly DbSet<T> _entities;

		public Repository(IDbContextFactory<AppDbContext> dbContextFactory)
		{
			_appDbContext = dbContextFactory.CreateDbContext();
			_entities = _appDbContext.Set<T>();
		}

		public async Task<bool> Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<T> Get(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<T>> GetAll()
		{
			throw new NotImplementedException();
		}

		public async Task<T> Update(T entity)
		{
			throw new NotImplementedException();
		}
		public void Dispose()
		{
			_appDbContext.Dispose();
		}
	}
}
