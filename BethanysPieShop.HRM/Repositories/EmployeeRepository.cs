using BethanysPieShop.HRM.Data;
using BethanysPieShop.HRM.Repositories.Interfaces;
using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.HRM.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly AppDbContext _appDbContext;
		public EmployeeRepository(IDbContextFactory<AppDbContext> dbContextFactory)
		{
			_appDbContext = dbContextFactory.CreateDbContext();
		}

		public Task<bool> Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<Employee> Get(int id)
		{
			return await _appDbContext.Employees.SingleAsync(e => e.EmployeeId == id);
		}

		public async Task<IEnumerable<Employee>> GetAll()
		{
			return await _appDbContext.Employees.ToListAsync();
		}

		public Task<Employee> Update(Employee entity)
		{
			throw new NotImplementedException();
		}
	}
}
