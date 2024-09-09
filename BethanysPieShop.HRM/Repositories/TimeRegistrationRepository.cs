using BethanysPieShop.HRM.Data;
using BethanysPieShop.HRM.Repositories.Interfaces;
using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.HRM.Repositories
{
	public class TimeRegistrationRepository : ITimeRegistrationRepository
	{
		private readonly AppDbContext _appDbContext;
		public TimeRegistrationRepository(IDbContextFactory<AppDbContext> dbContextFactory)
		{
			_appDbContext = dbContextFactory.CreateDbContext();
		}

		public Task<bool> Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<TimeRegistration> Get(int id)
		{
			return await _appDbContext.TimeRegistrations.SingleAsync(e => e.EmployeeId == id);
		}

		public async Task<IEnumerable<TimeRegistration>> GetAll()
		{
			return await _appDbContext.TimeRegistrations.ToListAsync();
		}

		public Task<TimeRegistration> Update(TimeRegistration entity)
		{
			throw new NotImplementedException();
		}

		public async Task<List<TimeRegistration>> GetTimeRegistrationsForEmployee(int employeeId)
		{
			return await _appDbContext
				.TimeRegistrations.Where(tr => tr.EmployeeId == employeeId)
				.OrderBy(tr => tr.StartTime)
				.ToListAsync();
		}

		public async Task<IList<TimeRegistration>> GetPagesTimeRegistrationsForEmployee(int employeeId, int pageSize, int start)
		{
			return await _appDbContext
				.TimeRegistrations.Where(tr => tr.EmployeeId == employeeId)
				.OrderBy(tr => tr.StartTime)
				.Skip(start)
				.Take(pageSize)
				.ToListAsync();
		}

		public async Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId)
		{
			return await _appDbContext.TimeRegistrations.CountAsync(tr => tr.EmployeeId == employeeId);
		}
	}
}
