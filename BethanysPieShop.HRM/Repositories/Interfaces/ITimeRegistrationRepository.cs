using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Repositories.Interfaces
{
	public interface ITimeRegistrationRepository : IRepository<TimeRegistration>
	{
		Task<List<TimeRegistration>> GetTimeRegistrationsForEmployee(int EmployeeId);
		Task<IList<TimeRegistration>> GetPagesTimeRegistrationsForEmployee(int employeeId, int pageSize, int start);
		Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId);
	}
}
