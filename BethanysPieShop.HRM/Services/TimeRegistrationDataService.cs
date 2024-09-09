using BethanysPieShop.HRM.Repositories.Interfaces;
using BethanysPieShop.HRM.Services.Interfaces;
using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Services
{
	public class TimeRegistrationDataService(ITimeRegistrationRepository repository) : ITimeRegistrationDataService
	{
		public async Task<IList<TimeRegistration>> GetPagesTimeRegistrationsForEmployee(int employeeId, int pageSize, int start)
		{
			return await repository.GetPagesTimeRegistrationsForEmployee(employeeId, pageSize, start);
		}

		public async Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId)
		{
			return await repository.GetTimeRegistrationCountForEmployeeId(employeeId);
		}

		public async Task<IList<TimeRegistration>> GetTimeRegistrationsForEmployee(int employeeId)
		{
			return await repository.GetTimeRegistrationsForEmployee(employeeId);
		}
	}
}
