using BethanysPieShop.HRM.Repositories.Interfaces;
using BethanysPieShop.HRM.Services.Interfaces;
using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Services
{
	public class EmployeeDataService(IEmployeeRepository repository) : IEmployeeDataService
	{
		public async Task<IEnumerable<Employee>> GetAllEmployees()
		{
			return await repository.GetAll();
		}

		public async Task<Employee> GetEmployeeDetails(int employeeId)
		{
			return await repository.Get(employeeId);
		}
	}
}
