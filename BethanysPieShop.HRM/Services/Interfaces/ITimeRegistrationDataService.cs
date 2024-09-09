using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Services.Interfaces
{
	public interface ITimeRegistrationDataService
	{
		Task<IList<TimeRegistration>> GetTimeRegistrationsForEmployee(int employeeId);
		Task<IList<TimeRegistration>> GetPagesTimeRegistrationsForEmployee(int employeeId, int pageSize, int start);
		Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId);
	}
}
