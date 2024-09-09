using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Services.Interfaces
{
	public interface IEmployeeDataService
	{
		Task<IEnumerable<Employee>> GetAllEmployees();
		Task<Employee> GetEmployeeDetails(int employeeId);
	}
}
